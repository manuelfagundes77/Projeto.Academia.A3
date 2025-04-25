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
    public partial class Formulario : Form
     
    {
        private MembroController membroController;

        public Formulario()
        {
            InitializeComponent();
            membroController = new MembroController();
            this.FormClosing += new FormClosingEventHandler(this.Formulario_FormClosing);
        }


        private void Formulario_Load(object sender, EventArgs e)
        {

        }

        private void btnAdicionarMembro_Click(object sender, EventArgs e)
        {
            // Pegando os dados dos campos
            string nome = campoNome.Text;
            string cpf = campoCPF.Text;
            string endereco = CampoEndereço.Text;
            string telefone = campoTelefone.Text;
            DateTime dataCadastro = dateTimePicker1.Value;

            
            Membro novoMembro = new Membro
            {
                Nome = nome,
                CPF = cpf,
                Endereco = endereco,
                Telefone = telefone,
                DataCadastro = dataCadastro
            };

            // Chama o Controller para adicionar o membro
            membroController.AdicionarMembro(novoMembro);

            MessageBox.Show("Membro Adicionado com Sucesso!");

            // Limpa os campos
            campoNome.Clear();
            campoCPF.Clear();
            CampoEndereço.Clear();
            campoTelefone.Clear();
        }

       

        //Fechar programa de vez
        private bool jaConfirmouFechamento = false;
        private void Formulario_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!jaConfirmouFechamento)
            {
                e.Cancel = true; // Impede o fechamento enquanto a confirmação não ocorre

                DialogResult resultado = MessageBox.Show("Tem certeza que deseja fechar?",
                                                         "Confirmar Fechamento",
                                                         MessageBoxButtons.YesNo,
                                                         MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    jaConfirmouFechamento = true;
                    Environment.Exit(0); // Encerra tudo imediatamente
                }
            }
        }
    }
}
