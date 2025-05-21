using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projeto.Academia.A3.Controller;
using Projeto.Academia.A3.Models;
using Projeto.Academia.A3.Utils;

namespace Projeto.Academia.A3.View
{
    public partial class TelaTreino : Form
    {
        private Membro _membro;
        private List<Exercicio> listaDeExercicios = new List<Exercicio>();
        private List<Exercicio> listaDeExerciciosB = new List<Exercicio>(); // Tipo B
        private List<Exercicio> listaDeExerciciosC = new List<Exercicio>(); // Tipo C
        public TelaTreino(Membro membro)
        {
            InitializeComponent();
            _membro = membro;

            labelNome.Text = _membro.Nome;
        }

        private void TelaTreino_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private bool ValidarCamposTreino()
        {
            if (selecionarTipo.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecione um tipo de treino.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(campoDescricao.Text))
            {
                MessageBox.Show("Por favor, preencha a descrição do treino.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (listaExercicios.Items.Count == 0 || listaExerciciosB.Items.Count == 0 || listaExerciciosC.Items.Count == 0)
            {
                MessageBox.Show("Adicione pelo menos um exercício a cada subtreino.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            //
            return true;
        }


        private void btnAdicionarTreino_Click(object sender, EventArgs e)
        {
           

            if (!ValidarCamposTreino())
                return;

            // Obter os valores dos campos do formulário
            string tipo = selecionarTipo.SelectedItem.ToString(); // Tipo do treino
            string descricao = campoDescricao.Text; // Descrição do treino
            DateTime dataInicio = pegaData.Value; // Data de início
            string duracaoFormatada = Uteis.FormatarData(dataDuracao.Value);

            // Criar um objeto Treino com os dados fornecidos
            Treino novoTreino = new Treino
            {
                AlunoId = _membro.AlunoId, 
                Tipo = tipo,
                Descricao = descricao,
                Duracao = duracaoFormatada,
                DataInicio = dataInicio,
                 FuncionarioId = FuncionarioLogado.Funcionario?.FuncionarioId
            };

            // Criar um controlador do Treino
            TreinoController treinoController = new TreinoController();

           

            // Chamar o metodo AdicionarTreino do controlador
            int treinoId = treinoController.AdicionarTreino(novoTreino);

            if (treinoId > 0)
            {   
                //criado na view 
                AdicionarSubtreinosComExercicios(treinoId);

                MessageBox.Show("Treino e subtreinos com exercícios adicionados com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                MessageBox.Show("Erro ao adicionar o treino.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            selecionarTipo.SelectedIndex = -1; // Limpa o ComboBox
            campoDescricao.Text = string.Empty; // Limpa o campo 
            pegaData.Value = DateTime.Today; // reseta a data para hj
            dataDuracao.Value = DateTime.Today; //  reseta a  duracao para hj
        }

        //metodo para chamar o controller que salva os exercicios no bd
        private bool AdicionarExerciciosAoTreino(int SubTreinoID, List<Exercicio> listaExercicios)
        {
            ExerciciosController exerciciosController = new ExerciciosController();

            foreach (var exercicio in listaExercicios)
            {
                exercicio.SubTreinoId = SubTreinoID; 
                bool sucesso = exerciciosController.AdicionarExercicio(exercicio);

                if (!sucesso)
                {
                    MessageBox.Show("Erro ao adicionar exercício. volta do controler", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            return true;
        }

        //Metodo criado para  mostrar  listBox na view e salvar nas lista abc referente aos tipo de treino
        private void AdicionarExercicioNaListaCorreta(Exercicio exercicio)
        {
            if (selecionaSubtreino.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecione um tipo de subtreino (A, B ou C).", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string tipoSelecionado = selecionaSubtreino.SelectedItem.ToString();

            switch (tipoSelecionado)
            {
                case "Tipo A":
                    listaDeExercicios.Add(exercicio);
                    listaExercicios.Items.Add(exercicio);
                    break;
                case "Tipo B":
                    listaDeExerciciosB.Add(exercicio);
                    listaExerciciosB.Items.Add(exercicio);
                    break;
                case "Tipo C":
                    listaDeExerciciosC.Add(exercicio);
                    listaExerciciosC.Items.Add(exercicio);
                    break;
                default:
                    MessageBox.Show("Tipo de subtreino inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
            }
        }



        private void btnVoltar_Click(object sender, EventArgs e)
        {
            MenuLayout menuLayout = this.ParentForm as MenuLayout;
            if (menuLayout != null)
            {
                menuLayout.GetType()
                          .GetMethod("AbrirFormNoPainel", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)
                          .Invoke(menuLayout, new object[] { new TelaAdicionarTreino(_membro) });
            }
            else
            {
                MessageBox.Show("MenuLayout não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //metodo criado para criar o exercicio e chamar o metodo adicionarexercicionalistacorreta ex a b c
        private void btnAddExercicio_Click(object sender, EventArgs e)
        {

            // Verificar se todos os campos necessários estão preenchidos
            if (selecionaExercicio.SelectedItem == null || selecionaSerie.SelectedItem == null || selecionaRepeticoes.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecione todos os campos: exercício, série e repetições.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obter os valores dos campos
            string nomeExercicio = selecionaExercicio.SelectedItem.ToString();
            string serie = selecionaSerie.SelectedItem.ToString();
            string repeticoes = selecionaRepeticoes.SelectedItem.ToString();

            // Criar o objeto Exercicio
            Exercicio novoExercicio = new Exercicio
            {
                NomeExercicio = nomeExercicio,
                Serie = serie,
                Repeticoes = repeticoes
            };

            AdicionarExercicioNaListaCorreta(novoExercicio);

            // Limpar os campos da selecao
            selecionaExercicio.SelectedIndex = -1;
            selecionaSerie.SelectedIndex = -1;
            selecionaRepeticoes.SelectedIndex = -1;

        }

        //metodo para colocoar no btn criartreino para ser chamdo  cria o subtreino e chama o metodo add exercicio 
        private void AdicionarSubtreinosComExercicios(int treinoId)
        {
            SubTreinoController subTreinoController = new SubTreinoController();
            ExerciciosController exerciciosController = new ExerciciosController();

            // Subtreino A
            if (listaDeExercicios.Any())
            {
                SubTreino subA = new SubTreino
                {
                    Nome = "A - Peito",  
                    TreinoId = treinoId
                };

                int subAId = subTreinoController.AdicionarSubTreino(subA);
           
              AdicionarExerciciosAoTreino(subAId, listaDeExercicios);
            }

            // Subtreino B
            if (listaDeExerciciosB.Any())
            {
                SubTreino subB = new SubTreino
                {
                    Nome = "B - Pernas",  
                    TreinoId = treinoId
                };

                int subBId = subTreinoController.AdicionarSubTreino(subB);
                
                AdicionarExerciciosAoTreino(subBId, listaDeExerciciosB);
            }

            // Subtreino C
            if (listaDeExerciciosC.Any())
            {
                SubTreino subC = new SubTreino
                {
                    Nome = "C - Costas",  
                    TreinoId = treinoId
                };

                int subCId = subTreinoController.AdicionarSubTreino(subC);
               
                AdicionarExerciciosAoTreino(subCId, listaDeExerciciosC);
            }
        }

        private void listaExercicios_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            RemoverExercicioSelecionado(listaExercicios, listaDeExercicios);
        }

        private void listaExerciciosB_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            RemoverExercicioSelecionado(listaExerciciosB, listaDeExerciciosB);
        }

        private void listaExerciciosC_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            RemoverExercicioSelecionado(listaExerciciosC, listaDeExerciciosC);

        }

        private void RemoverExercicioSelecionado(ListBox listBox, List<Exercicio> lista)
        {
            if (listBox.SelectedItem is Exercicio exercicioSelecionado)
            {
                var resultado = MessageBox.Show(
                    $"Deseja remover o exercício \"{exercicioSelecionado.NomeExercicio}\"?",
                    "Confirmar Remoção",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (resultado == DialogResult.Yes)
                {
                    listBox.Items.Remove(exercicioSelecionado);
                    lista.Remove(exercicioSelecionado);
                }
            }
        }

    }
}
