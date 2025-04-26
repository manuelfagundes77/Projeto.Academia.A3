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

namespace Projeto.Academia.A3.View
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }


        //mudança de tela
        private void button1_Click(object sender, EventArgs e)
        {      //MENU ADICIONAR MEMBRO
            Formulario formulario = new Formulario();
            formulario.Show(); // Abre a nova tela
            this.Hide(); // Fecha a tela de login
        }

        //mudança de tela
        private void irTelaAddFuncionario_Click(object sender, EventArgs e)
        {
            TelaAdicionarFuncionario telafunc = new TelaAdicionarFuncionario();
            telafunc.Show();
            this.Hide();
        }
       

       
        //Fechar programa ao aperta no X 
        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show(
            "Deseja realmente deslogar?",
            "Confirmação",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
            );

            if (resultado == DialogResult.Yes)
            {
                TelaLogin telaLogin = new TelaLogin();
                telaLogin.Show();
                this.Hide();
            }
            // Se clicar em "Não", nada acontece
        }
    }
}
