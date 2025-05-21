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

namespace Projeto.Academia.A3.View
{
    public partial class TelaHistorico : Form
    {
        private Membro _membro;
        private TreinoController _treinoController;
        private SubTreinoController _subTreinoController;

        public TelaHistorico(Membro membro)
        {
            InitializeComponent();
            _membro = membro;
            _treinoController = new TreinoController();
            _subTreinoController = new SubTreinoController();

            // Ja mostra due passou a PESSOA CORRETA
            labelID.Text = _membro.Nome;
            labelNome.Text = _membro.AlunoId.ToString();
        }

        private void TelaHistorico_Load(object sender, EventArgs e)
        {
            carregarTreinos();
           formatarTabela();
        }

        private void formatarTabela()
        {
            // Esconde as colunas desnecessarias (caso tenha colunas extras)
            dataView.Columns["AlunoId"].Visible = false; // Esconde a coluna AlunoId
            dataView.Columns["TreinoId"].Visible = false; 
            dataView.Columns["Tipo"].DisplayIndex = 0; // Tipo na primeira posicao
            dataView.Columns["Descricao"].DisplayIndex = 1; 
            dataView.Columns["Duracao"].DisplayIndex = 3; 
            dataView.Columns["DataInicio"].DisplayIndex = 2;

            // Muda o texto do cabeçalho
            dataView.Columns["Duracao"].HeaderText = "Duração Até";

            // Formatar a coluna DataInicio
            foreach (DataGridViewRow row in dataView.Rows)
            {
                if (row.Cells["DataInicio"].Value != null)
                {
                    DateTime dataInicio = (DateTime)row.Cells["DataInicio"].Value;
                    row.Cells["DataInicio"].Value = Projeto.Academia.A3.Utils.Uteis.FormatarData(dataInicio);
                }
            }
        }

        private void carregarTreinos()
        {
            var treinos = _treinoController.ObterTreinos(_membro.AlunoId);

            dataView.DataSource = treinos;
        }

      

        private void panelVoltar_Click(object sender, EventArgs e)
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

        private void dataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CarregarExerciciosNosListBox(int treinoId)
        {
            listaExercicioA.Items.Clear();
            listaExercicioB.Items.Clear();
            listaExercicioC.Items.Clear();

            var subTreinos = _subTreinoController.ObterSubTreinosComExercicios(treinoId);//volta do BANCO todos os SUBtreinos  pelo ID do treino com seus respectivos exercicios

            foreach (var subTreino in subTreinos)
            {
                foreach (var exercicio in subTreino.Exercicios)
                {
                    string item = $"{exercicio.NomeExercicio} - {exercicio.Serie}x{exercicio.Repeticoes}"; // formatação da escrita

                    if (subTreino.Nome.StartsWith("A", StringComparison.OrdinalIgnoreCase))
                    {
                        listaExercicioA.Items.Add(item);
                    }
                    else if (subTreino.Nome.StartsWith("B", StringComparison.OrdinalIgnoreCase))
                    {
                        listaExercicioB.Items.Add(item);
                    }
                    else if (subTreino.Nome.StartsWith("C", StringComparison.OrdinalIgnoreCase))
                    {
                        listaExercicioC.Items.Add(item);
                    }
                }
            }
        }

        private void dataView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int treinoId = Convert.ToInt32(dataView.Rows[e.RowIndex].Cells["TreinoId"].Value);
                CarregarExerciciosNosListBox(treinoId);
            }
        }
    }
}
