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
                // Chama o método que adiciona os exercícios ao treino
                bool exerciciosAdicionados = AdicionarExerciciosAoTreino(treinoId, listaDeExercicios);

                if (exerciciosAdicionados)
                {
                 //   MessageBox.Show("Treino e exercícios adicionados com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
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

        private bool AdicionarExerciciosAoTreino(int treinoId, List<Exercicio> listaExercicios)
        {
            foreach (var exercicio in listaExercicios)
            {
                exercicio.TreinoId = treinoId; // Associa o treinoId ao exercício

                // Chamar o controlador para adicionar o exercício
                ExerciciosController exerciciosController = new ExerciciosController();
                bool sucesso = exerciciosController.AdicionarExercicio(exercicio);

                if (!sucesso)
                {
                    MessageBox.Show("Erro ao adicionar exercício.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false; // Retorna falso se houve erro
                }
            }

            return true; // Retorna verdadeiro se todos os exercícios foram adicionados com sucesso
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

            // Adicionar o exercício à lista na ListBox
            listaExercicios.Items.Add(novoExercicio);

            // Adicionar o exercício à lista de exercícios global para chamar quando adicionar o treino
            listaDeExercicios.Add(novoExercicio);

            // Limpar os campos de seleção após adicionar
            selecionaExercicio.SelectedIndex = -1;
            selecionaSerie.SelectedIndex = -1;
            selecionaRepeticoes.SelectedIndex = -1;

        }

      
    }
}
