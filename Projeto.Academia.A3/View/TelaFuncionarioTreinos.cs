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

namespace Projeto.Academia.A3.View
{
    public partial class TelaFuncionarioTreinos : Form
    {
        public TelaFuncionarioTreinos()
        {
            InitializeComponent();
        }

        private void TelaFuncionarioTreinos_Load(object sender, EventArgs e)
        {
            FuncionarioController controller = new FuncionarioController();
            var funcionarios = controller.ObterTodosFuncionarios();

            if (funcionarios != null)
            {
                comboBoxFuncionarios.DataSource = funcionarios;
                comboBoxFuncionarios.DisplayMember = "Nome";
                comboBoxFuncionarios.ValueMember = "FuncionarioId";
                comboBoxFuncionarios.SelectedIndex = -1; // Nenhum selecionado por padrão
            }

            comboBoxFuncionarios.SelectedIndexChanged += comboBoxFuncionarios_SelectedIndexChanged;
        }

        private void comboBoxFuncionarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxFuncionarios.SelectedIndex != -1)
            {
                int funcionarioId = Convert.ToInt32(comboBoxFuncionarios.SelectedValue);
                CarregarTreinosDoFuncionario(funcionarioId);//chama o metodo que carrega  todos os treinos do funcionario selecionado
            }
        }


        private void CarregarTreinosDoFuncionario(int funcionarioId)
        {

            TreinoController controller = new TreinoController();
            var treinos = controller.ObterTreinosPorFuncionario(funcionarioId);//funcao que recupera do Banco todos os treinso por ID

            if (treinos != null && treinos.Any())
            {
                // Defina o DataSource primeiro
                tabelaTreinos.DataSource = null;
                tabelaTreinos.DataSource = treinos; //preenche a tabela

                // Ocultar as colunas desnecessárias (se necessário)
                //    tabelaTreinos.Columns["FuncionarioId"].Visible = false;
                OrganizarTabela(); 
            }
            else
            {
                MessageBox.Show("Nenhum treino encontrado para este funcionário.");
            }
        }

        private void tabelaTreinos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void OrganizarTabela()
        {
            // Ordena as colunas
            tabelaTreinos.Columns["NomeAluno"].DisplayIndex = 0;  
            tabelaTreinos.Columns["Descricao"].DisplayIndex = 1;  
            tabelaTreinos.Columns["DataInicio"].DisplayIndex = 2; 
            tabelaTreinos.Columns["Duracao"].DisplayIndex = 3;
            tabelaTreinos.Columns["Tipo"].DisplayIndex = 4;


            // Ocultar colunas 
            tabelaTreinos.Columns["TreinoId"].Visible = false;    // Ocultar a coluna TreinoId

            tabelaTreinos.Columns["NomeAluno"].Width = 120;
            tabelaTreinos.Columns["DataInicio"].Width = 85; 
            tabelaTreinos.Columns["Descricao"].Width = 140;


            //tabelaTreinos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //tabelaTreinos.AutoResizeColumns();

        }


    }
}
