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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {      //MENU ADICIONAR MEMBRO
            Formulario formulario = new Formulario();
            formulario.Show(); // Abre a nova tela
            this.Hide(); // Fecha a tela de login
        }

        private void button2_Click(object sender, EventArgs e)
        {       
            //menu ADICIONAR FUNCIONARIO

        }

        private void Menu_Load(object sender, EventArgs e)
        {
            
        }
    }
}
