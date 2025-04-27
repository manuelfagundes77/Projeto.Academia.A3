using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Projeto.Academia.A3.Controller;
using Projeto.Academia.A3.Data;
using Projeto.Academia.A3.Models;

namespace Projeto.Academia.A3.View
{
    public partial class TelaLogin : Form
    {
        private FuncionarioController _funcionarioController;
        public TelaLogin()
        {
            InitializeComponent();
            _funcionarioController = new FuncionarioController();
        }

        private void TelaLogin_Load(object sender, EventArgs e)
        {
            // Teste de conexão
            MySqlConnection conexao = Conexao.ObterConexao();

            if (conexao != null)
            {
                Conexao.FecharConexao(conexao);
            }
            else
            {
                // Aqui você pode fazer algo em caso de erro na conexão, como mostrar uma mensagem
            }
        }

        private void btnLogar_Click(object sender, EventArgs e)
        { // Lógica para validar o login e senha
            string login = campoLogin.Text;
            string senha = campoSenha.Text;

            bool loginValido = _funcionarioController.ValidarLogin(login, senha);

            if (loginValido)
            {
                // Se o login for válido, busca os dados do funcionário
                Funcionario funcionarioLogado = _funcionarioController.BuscarFuncionarioPorLogin(login, senha); // Método para buscar os dados do funcionário

                // Armazenando o funcionário logado na classe FuncionarioLogado
                FuncionarioLogado.Funcionario = funcionarioLogado;

                // Abre a tela principal
                MenuLayout menuLayout = new MenuLayout();
                menuLayout.Show(this);
                this.Hide(); // Fecha a tela de login
            }
            else
            {
                // Se o login for inválido, mostra um alerta
                MessageBox.Show("Login ou Senha incorretos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TelaLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
