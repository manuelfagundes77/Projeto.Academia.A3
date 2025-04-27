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
    public partial class TelaTreino : Form
    {
        private Membro _membro;
        public TelaTreino(Membro membro)
        {
            InitializeComponent();
            _membro = membro;

            labelNome.Text = _membro.Nome;
        }

        private void TelaTreino_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAdicionarTreino_Click(object sender, EventArgs e)
        {
            // Obter os valores dos campos do formulário
            string tipo = selecionarTipo.SelectedItem.ToString(); // Tipo do treino
            string descricao = campoDescricao.Text; // Descrição do treino
            DateTime dataInicio = pegaData.Value; // Data de início
            string duracaoFormatada = Uteis.FormatarData(dataDuracao.Value);

            // Criar um objeto Treino com os dados fornecidos
            Treino novoTreino = new Treino
            {
                AlunoId = _membro.AlunoId, // Usando o AlunoId que foi passado para o formulário
                Tipo = tipo,
                Descricao = descricao,
                Duracao = duracaoFormatada,
                DataInicio = dataInicio
            };

            // Criar um controlador do Treino
            TreinoController treinoController = new TreinoController();

            // Chamar o método AdicionarTreino do controlador
            treinoController.AdicionarTreino(novoTreino);
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            MenuLayout menuLayout = this.ParentForm as MenuLayout;
            if (menuLayout != null)
            {
                menuLayout.GetType()
                          .GetMethod("AbrirFormNoPainel", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)
                          .Invoke(menuLayout, new object[] { new TelaAdicionarTreino(_membro) });
            }
            else
            {
                MessageBox.Show("MenuLayout não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
