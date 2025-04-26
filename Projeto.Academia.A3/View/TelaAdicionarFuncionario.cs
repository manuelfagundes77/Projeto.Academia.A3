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
    public partial class TelaAdicionarFuncionario : Form
    {
        private FuncionarioController funcionarioController = new FuncionarioController();
        public TelaAdicionarFuncionario()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = campoNome.Text;
            string cargo = selecionarCargo.SelectedItem?.ToString();
            string login = campoLogin.Text;
            string senha = campoSenha.Text;

            if (string.IsNullOrWhiteSpace(nome) || cargo == "Selecione" || string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(senha))
            {
                MessageBox.Show("Preencha todos os campos corretamente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                bool sucesso = funcionarioController.AdicionarFuncionario(nome, cargo, login, senha);
                if (sucesso)
                {
                    MessageBox.Show("Funcionário cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    campoNome.Text = "";
                    selecionarCargo.SelectedIndex = 0; // volta pra "Selecione" (índice 0)
                    campoLogin.Text = "";
                    campoSenha.Text = "";
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar funcionário.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void TelaAdicionarFuncionario_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
