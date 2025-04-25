using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto.Academia.A3.View
{
    public partial class TelaLogin : Form
    {
        public TelaLogin()
        {
            InitializeComponent();
        }

        private void TelaLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            // Lógica para validar o login e senha
            string login = campoLogin.Text;
            string senha = campoSenha.Text;

            // Verifica se o login e senha são corretos
            if (login == "ad" && senha == "123")
            {
                // Se for, abre a tela principal (Formulario)
                //   Formulario formulario = new Formulario();
                //   formulario.Show(); // Abre a nova tela

                Menu menu = new Menu();
                menu.Show(this);
                this.Hide(); // Fecha a tela de login
            }
            else
            {
                // Se não for, mostra um alerta
                MessageBox.Show("Login ou Senha incorretos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
