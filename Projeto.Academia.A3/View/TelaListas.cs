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
    public partial class TelaListas : Form
    {
        private PagamentoController _pagamentoController;
        private MembroController _membroController;
        private Membro _membroBuscado;
       

        public TelaListas()
        {
            InitializeComponent();
            _membroController = new MembroController();
            _pagamentoController = new PagamentoController(); // Inicializa o controlador
        }

        private void TelaListas_Load(object sender, EventArgs e)
        {
            
            dataGrid.CellMouseMove += dataGrid_CellMouseMove;
        }

        // Método para carregar membros no DataGridView
        private void CarregarPagamentosNoGrid(int alunoId)
        {
            // Obtém a lista de pagamentos
            var pagamentos = _pagamentoController.ListarPagamentos(alunoId);

            // Define a lista como fonte de dados
            dataGrid.DataSource = pagamentos;

            // Adiciona botão "Confirmar Pagamento" se ainda não existir
            if (dataGrid.Columns["Confirmar"] == null)
            {
                DataGridViewButtonColumn btnConfirmar = new DataGridViewButtonColumn();
                btnConfirmar.Name = "Confirmar";
                btnConfirmar.Text = "Confirmar Pagamento";
                btnConfirmar.UseColumnTextForButtonValue = true;
                btnConfirmar.DefaultCellStyle.ForeColor = Color.Green;
                btnConfirmar.DefaultCellStyle.Font = new Font("Arial", 8.25F, FontStyle.Bold);

                dataGrid.Columns.Add(btnConfirmar);
            }

          

            // Faz o grid ocupar todo o espaço horizontal disponível
            dataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            // Ajusta colunas (opcional)
            dataGrid.Columns["PagamentoId"].Visible = false;
            dataGrid.Columns["Situacao"].Width = 80;
            dataGrid.Columns["Confirmar"].Width = 140;
            dataGrid.Columns["AlunoId"].Width = 40;

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // Obtém o CPF digitado no campo de busca
            string cpf = campoBusca.Text.Trim();
            //  MessageBox.Show("CPF buscado: " + cpf);

            if (!string.IsNullOrEmpty(cpf))
            {
                // Chama o método no controlador para buscar o membro
                Membro membro = _membroController.BuscarMembroPorCPF(cpf);


                //Recupera o objeto do controller com os dados
                if (membro != null)
                {
                    _membroBuscado = membro;


                    // carrega os pagamentos do aluno
                    CarregarPagamentosNoGrid(membro.AlunoId); // Passa o ID aqui!
                    labelNome.Text = membro.Nome;
                    campoBusca.Text = string.Empty;

                }
                else
                {
                    // MessageBox.Show("membro não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, insira um CPF para buscar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // metodo para poder apertar no botao dentro da tebala confirmar
        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica se clicou em uma célula válida e se é a coluna do botão "Confirmar"
            if (e.RowIndex >= 0 && dataGrid.Columns[e.ColumnIndex].Name == "Confirmar")
            {
                // Obtém o PagamentoId da linha clicada
                int pagamentoId = Convert.ToInt32(dataGrid.Rows[e.RowIndex].Cells["PagamentoId"].Value);

                // Verifica a situação atual antes de confirmar
                string situacaoAtual = dataGrid.Rows[e.RowIndex].Cells["Situacao"].Value.ToString();

                if (situacaoAtual == "Pago")
                {
                    MessageBox.Show("Este pagamento já foi confirmado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Caixa de diálogo para confirmação personalizada
                DateTime dataPagamento = Convert.ToDateTime(dataGrid.Rows[e.RowIndex].Cells["DataPagamento"].Value);
                string mesAnoReferencia = dataPagamento.ToString("MMMM 'de' yyyy", new System.Globalization.CultureInfo("pt-BR"));

                // Caixa de diálogo para confirmação
                DialogResult resultado = MessageBox.Show(
                $"Deseja realmente confirmar o pagamento do mês de {mesAnoReferencia}?",
                "Confirmação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );

                if (resultado == DialogResult.Yes)
                {
                    // Confirma o pagamento
                    _pagamentoController.AlterarSituacaoPagamento(pagamentoId);

                    // Atualiza o grid com o alunoId que foi buscado
                    if (_membroBuscado != null)
                    {
                        CarregarPagamentosNoGrid(_membroBuscado.AlunoId); // Passa o alunoId aqui
                    }
                }
            }
        }

        //so para mostrar o hand ao passar no btn
        private void dataGrid_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var coluna = dataGrid.Columns[e.ColumnIndex];
                if (coluna.Name == "Confirmar")
                {
                    dataGrid.Cursor = Cursors.Hand;
                }
                else
                {
                    dataGrid.Cursor = Cursors.Default;
                }
            }
            else
            {
                dataGrid.Cursor = Cursors.Default;
            }
        }

       
    }
    
}
