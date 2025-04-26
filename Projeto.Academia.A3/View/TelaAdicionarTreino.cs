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
    public partial class TelaAdicionarTreino : Form
    {
        // Instancia o controlador de membros
        private MembroController _membroController;
        public TelaAdicionarTreino()
        {
            InitializeComponent();
            // Inicializa o MembroController
            _membroController = new MembroController();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            // Captura os dados dos campos
            string nome = campoNome.Text.Trim();
            string cpf = campoCPF.Text.Trim();
            string telefone = campoTelefone.Text.Trim();
            string endereco = campoEndereco.Text.Trim();

            // Valida os campos antes de enviar para o controlador
            if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(cpf) || string.IsNullOrEmpty(telefone) || string.IsNullOrEmpty(endereco))
            {
                MessageBox.Show("Todos os campos devem ser preenchidos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Exibe a caixa de diálogo de confirmação antes de editar
            DialogResult result = MessageBox.Show("Tem certeza que deseja editar os dados do membro?", "Confirmar Edição", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Se o usuário confirmar a edição
            if (result == DialogResult.Yes)
            {
                // Cria o objeto Membro
                Membro membro = new Membro
                {
                    AlunoId = int.Parse(labelID.Text), // Obtém o ID do membro
                    Nome = nome,
                    CPF = cpf,
                    Telefone = telefone,
                    Endereco = endereco
                };

                // Chama o controlador para editar o membro
                _membroController.EditarMembro(membro);
            }
            // Se o usuário clicar em "Não", não faz nada
            else
            {
                MessageBox.Show("Edição cancelada.", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

      

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // Obtém o CPF digitado no campo de busca
            string cpf = campoBusca.Text.Trim();

            if (!string.IsNullOrEmpty(cpf))
            {
                // Chama o método no controlador para buscar o membro
                Membro membro = _membroController.BuscarMembroPorCPF(cpf);

                if (membro != null)
                {
                    // Exibe os dados do membro nos campos
                    campoNome.Text = membro.Nome;
                    campoCPF.Text = membro.CPF;
                    campoTelefone.Text = membro.Telefone;
                    campoEndereco.Text = membro.Endereco;
                    labelID.Text = membro.AlunoId.ToString(); // Exibe o ID, que não pode ser alterado
                }
            }
            else
            {
                MessageBox.Show("Por favor, insira um CPF para buscar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
