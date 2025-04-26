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
    public partial class TelaListas : Form
    {
        private MembroController _membroController;

        public TelaListas()
        {
            InitializeComponent();
            _membroController = new MembroController(); // Inicializa o controlador
        }

        private void TelaListas_Load(object sender, EventArgs e)
        {
            CarregarMembrosNoGrid();
        }

        // Método para carregar membros no DataGridView
        private void CarregarMembrosNoGrid()
        {
            // Obtém a lista de membros do controlador
            var membros = _membroController.ListarMembros();

            // Define a lista de membros como a fonte de dados para o DataGridView
            dataGrid.DataSource = membros;

            // Adiciona as colunas de botões Editar e Excluir
            if (dataGrid.Columns["Editar"] == null) // Verifica se a coluna Editar já existe
            {
                DataGridViewButtonColumn btnEditar = new DataGridViewButtonColumn();
                btnEditar.Name = "Editar";
                btnEditar.Text = "Editar";
                btnEditar.UseColumnTextForButtonValue = true;  // Para garantir que o texto seja exibido
                dataGrid.Columns.Add(btnEditar);
            }

            if (dataGrid.Columns["Excluir"] == null) // Verifica se a coluna Excluir já existe
            {
                DataGridViewButtonColumn btnExcluir = new DataGridViewButtonColumn();
                btnExcluir.Name = "Excluir";
                btnExcluir.Text = "Excluir";
                btnExcluir.UseColumnTextForButtonValue = true;  // Para garantir que o texto seja exibido
                                                              
                btnExcluir.DefaultCellStyle.ForeColor = Color.Red;  // Cor do texto
                btnExcluir.DefaultCellStyle.Font = new Font("Arial", 8.25F, FontStyle.Bold); // Remove o negrito, define fonte e tamanho

                dataGrid.Columns.Add(btnExcluir);
            }

            // Ajusta a largura das colunas, se necessário
            dataGrid.Columns["AlunoId"].Width = 50;
        }
    }
}
