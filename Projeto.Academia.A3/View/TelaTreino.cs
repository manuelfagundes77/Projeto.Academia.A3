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

        private void btnAdicionarTreino_Click(object sender, EventArgs e)
        {
            // Verificar se foi selecionado um tipo de treino
            if (selecionarTipo.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecione um tipo de treino.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Verificar se a descrição está vazia
            if (string.IsNullOrWhiteSpace(campoDescricao.Text))
            {
                MessageBox.Show("Por favor, preencha a descrição do treino.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obter os valores dos campos do formulário
            string tipo = selecionarTipo.SelectedItem.ToString(); // Tipo do treino
            string descricao = campoDescricao.Text; // Descrição do treino
            DateTime dataInicio = pegaData.Value; // Data de início
            string duracaoFormatada = Uteis.FormatarData(dataDuracao.Value);

            // Criar um objeto Treino com os dados fornecidos
            Treino novoTreino = new Treino
            {
                AlunoId = _membro.AlunoId, // Usando o AlunoId que foi passado para o formulário
                Tipo = tipo,
                Descricao = descricao,
                Duracao = duracaoFormatada,
                DataInicio = dataInicio
            };

            // Criar um controlador do Treino
            TreinoController treinoController = new TreinoController();

           

            // Chamar o método AdicionarTreino do controlador
            int treinoId = treinoController.AdicionarTreino(novoTreino);

            if (treinoId > 0)
            {
                AdicionarSubtreinosComExercicios(treinoId);

                MessageBox.Show("Treino e subtreinos com exercícios adicionados com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                MessageBox.Show("Erro ao adicionar o treino.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            selecionarTipo.SelectedIndex = -1; // Limpa a seleção do ComboBox
            campoDescricao.Text = string.Empty; // Limpa o campo de descrição
            pegaData.Value = DateTime.Today; // Reseta a data para hoje
            dataDuracao.Value = DateTime.Today; // Também reseta a duração para hoje
        }

        private bool AdicionarExerciciosAoTreino(int SubTreinoID, List<Exercicio> listaExercicios)
        {
            ExerciciosController exerciciosController = new ExerciciosController();

            foreach (var exercicio in listaExercicios)
            {
                exercicio.SubTreinoId = SubTreinoID; // <- CORRETO AGORA
                bool sucesso = exerciciosController.AdicionarExercicio(exercicio);

                if (!sucesso)
                {
                    MessageBox.Show("Erro ao adicionar exercício. volta do controler", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            return true;
        }

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

            // Limpar os campos de seleção após adicionar
            selecionaExercicio.SelectedIndex = -1;
            selecionaSerie.SelectedIndex = -1;
            selecionaRepeticoes.SelectedIndex = -1;

        }

        private void AdicionarSubtreinosComExercicios(int treinoId)
        {
            SubTreinoController subTreinoController = new SubTreinoController();
            ExerciciosController exerciciosController = new ExerciciosController();

            // Subtreino A
            if (listaDeExercicios.Any())
            {
                SubTreino subA = new SubTreino
                {
                    Nome = "A - Peito",  // ou você pode montar dinamicamente se quiser
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
                    Nome = "B - Pernas",  // ou outro nome de sua escolha
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
                    Nome = "C - Costas",  // ou qualquer nome que você prefira
                    TreinoId = treinoId
                };

                int subCId = subTreinoController.AdicionarSubTreino(subC);
               
                AdicionarExerciciosAoTreino(subCId, listaDeExerciciosC);
            }
        }



    }
}
