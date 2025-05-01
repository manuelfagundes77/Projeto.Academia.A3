using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projeto.Academia.A3.Models;

namespace Projeto.Academia.A3.View
{
    public partial class MenuLayout : Form
    {
        public MenuLayout()
        {
            InitializeComponent();
        }

        private void MenuLayout_Load(object sender, EventArgs e)
        {
            verificarLogado();
        }

        private void verificarLogado()
        {
            // Verifica se o funcionário está logado e altera o texto do labelLogado
            if (FuncionarioLogado.Funcionario != null)
            {
                // Exibe o nome do funcionário logado no label
                labelLogado.Text = "Bem-vindo, " + FuncionarioLogado.Funcionario.Nome;
                panelLuzVerde.Visible = true;  // Torna o painel visível da luz verde 
            }
            else
            {
                labelLogado.Text = "Nenhum funcionário logado";
                panelLuzVerde.Visible = false;  
            }
        }

        private void AbrirFormNoPainel(Form form)
        {
            panelPrincipal.Controls.Clear(); // Limpa o painel
            form.TopLevel = false; // Fala para o form "se comportar" como um controle
            form.FormBorderStyle = FormBorderStyle.None; // Tira a borda e o botão de fechar
            form.Dock = DockStyle.Fill; // Faz ocupar todo o painel
            panelPrincipal.Controls.Add(form); // Adiciona dentro do painel
            form.Show(); // Exibe
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormNoPainel(new TelaAdicionarFuncionario());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirFormNoPainel(new Formulario());
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pagamentos_Click(object sender, EventArgs e)
        {
            AbrirFormNoPainel(new TelaListas());
        }

        private void areaBranca_Paint(object sender, PaintEventArgs e)
        {
            AbrirFormNoPainel(new TelaLogo());
        }

        private void areaBranca_Click(object sender, EventArgs e)
        {
            AbrirFormNoPainel(new TelaLogo());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void adicionarTreino_Click(object sender, EventArgs e)
        {
            AbrirFormNoPainel(new TelaAdicionarTreino());
        }

        private void MenuLayout_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void panelLuzVerde_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelPrincipal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buscarTreinoFunc_Click(object sender, EventArgs e)
        {
            AbrirFormNoPainel(new TelaFuncionarioTreinos());
        }
    }
}
