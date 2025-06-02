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
using Projeto.Academia.A3.Utils;

namespace Projeto.Academia.A3.View
{
    public partial class TelaAreaMembro : Form
    {
        // Instancia o controlador de membros
        private MembroController _membroController;
        private Membro _membroBuscado;

        public TelaAreaMembro()
        {
            InitializeComponent();
            // Inicializa o MembroController
            _membroController = new MembroController();
        }

        //Segundo construtor Para passar dados e chamar a tela em outro canto  voltando dados 
        public TelaAreaMembro(Membro membro) : this()
        {
            _membroBuscado = membro;
            PreencherCamposComMembro(membro);
        }

        // Exibe os dados do membro nos campos
        private void PreencherCamposComMembro(Membro membro)
        {
            if (membro != null)
            {
                campoNome.Text = membro.Nome;
                campoCPF.Text = membro.CPF;
                campoTelefone.Text = membro.Telefone;
                campoEndereco.Text = membro.Endereco;
                labelID.Text = membro.AlunoId.ToString();// Exibe o ID, que nao pode ser alterado
                labelData.Text = Uteis.FormatarData(membro.DataCadastro); // Exibe o Data de Cadastro que não pode ser alterado
            }
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

            // Exibe a caixa de dialogo de confirmação antes de editar
            DialogResult result = MessageBox.Show("Tem certeza que deseja editar os dados do membro?", "Confirmar Edição", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Se o usuario confirmar a edicao
            if (result == DialogResult.Yes)
            {
                // Cria o objeto Membro
                Membro membro = new Membro
                {
                    AlunoId = int.Parse(labelID.Text), // Obtem o ID do membro
                    Nome = nome,
                    CPF = cpf,
                    Telefone = telefone,
                    Endereco = endereco
                };

                // Chama o controlador para editar o membro
                _membroController.EditarMembro(membro);
            }
            // Se o usuário clicar nao  faz nada
            else
            {
                MessageBox.Show("Edição cancelada.", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // Obtem o CPF digitado no campo de busca
            string cpf = campoBusca.Text.Trim();

            if (!string.IsNullOrEmpty(cpf))
            {
                // Chama o metodo no controlador para buscar o membro
                Membro membro = _membroController.BuscarMembroPorCPF(cpf);


                //Recupera o objeto do controller com os dados
                if (membro != null)
                {
                    _membroBuscado = membro; 
                                            

                    PreencherCamposComMembro(membro);

                }
            }
            else
            {
                MessageBox.Show("Por favor, insira um CPF para buscar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            // Obtem o nome do membro exibido para mostrar na primeira confirmacao
            string nomeMembro = campoNome.Text.Trim();

            // Verifica se o nome esta preenchido, ou seja, se o membro esta exibido
            if (string.IsNullOrEmpty(nomeMembro))
            {
                MessageBox.Show("Nenhum membro foi selecionado para exclusão.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Primeira confirmacao exibe o nome do membro que sera excluido
            DialogResult result1 = MessageBox.Show($"Tem certeza que deseja excluir o membro {nomeMembro}?",
                                                   "Confirmar Exclusão",
                                                   MessageBoxButtons.YesNo,
                                                   MessageBoxIcon.Question);

            if (result1 == DialogResult.Yes)
            {
                // Segunda confirmacao: avisa que a exclusao e permanente
                DialogResult result2 = MessageBox.Show("Você está prestes a excluir os dados permanentemente. Deseja continuar?",
                                                       "Confirmar Exclusão Permanente",
                                                       MessageBoxButtons.YesNo,
                                                       MessageBoxIcon.Warning);

                if (result2 == DialogResult.Yes)
                {
                    // Obtém o ID do membro a ser excluido
                    int alunoId = int.Parse(labelID.Text);

                    // Chama o controlador para excluir o membro com base no ID
                    _membroController.ExcluirMembro(alunoId);

                    // Exibe uma mensagem de sucesso
                    MessageBox.Show($"Membro {nomeMembro} excluído com sucesso.",
                                    "Exclusão Concluída",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);

                    campoNome.Text = string.Empty;
                    campoCPF.Text = string.Empty;
                    campoTelefone.Text = string.Empty;
                    campoEndereco.Text = string.Empty;
                    labelID.Text = string.Empty;
                    labelData.Text = string.Empty;
                    campoBusca.Text = string.Empty;

                }
                else
                {
                    MessageBox.Show("Exclusão cancelada.", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Exclusão cancelada.", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        private void TelaAdicionarTreino_Load(object sender, EventArgs e)
        {

        }

        private void btnAbrirHistoricoDeTreino_Click(object sender, EventArgs e)
        {
            //ESSE CODIGO FAZ COM QUE TROQUE A TELA  DENTRO DO LAYOUT sem TER NO MENU O BOTAO
            if (_membroBuscado != null)
            {
                MenuLayout menuLayout = this.ParentForm as MenuLayout;
                if (menuLayout != null)
                {
                    menuLayout.GetType()
                              .GetMethod("AbrirFormNoPainel", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)
                              .Invoke(menuLayout, new object[] { new TelaHistorico(_membroBuscado) });
                }
                else
                {
                    MessageBox.Show("MenuLayout não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, busque um aluno antes de abrir o histórico.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnAbrirNovotreino_Click(object sender, EventArgs e)
        {
            //ESSE CODIGO FAZ COM QUE TROQUE A TELA  DENTRO DO LAYOUT sem TER NO MENU O BOTAO
            if (_membroBuscado != null)
            {
                MenuLayout menuLayout = this.ParentForm as MenuLayout;
                if (menuLayout != null)
                {
                    menuLayout.GetType()
                              .GetMethod("AbrirFormNoPainel", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)
                              .Invoke(menuLayout, new object[] { new TelaTreino(_membroBuscado) });
                }
                else
                {
                    MessageBox.Show("MenuLayout não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, busque um aluno antes de abrir o histórico.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
