using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.Academia.A3.Models;
using Projeto.Academia.A3.Services;
using System.Windows.Forms;

namespace Projeto.Academia.A3.Controller
{
    public class PagamentoController
    {
        private PagamentoService _pagamentoService;

        public PagamentoController()
        {
            _pagamentoService = new PagamentoService(); // Instancia a classe de serviços
        }

        // Método para alterar a situação do pagamento para "Pago" usando o PagamentoId
        public void AlterarSituacaoPagamento(int pagamentoId)
        {
            bool sucesso = _pagamentoService.AlterarSituacaoPagamentoPorId(pagamentoId); // Alterar para 'Pago' no serviço

            if (sucesso)
            {
                MessageBox.Show("Pagamento atualizado para 'Pago' com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Erro ao atualizar o pagamento.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // lista para retorna pagamentos do aluno
        public List<Pagamento> ListarPagamentos(int alunoId)
        {
            List<Pagamento> pagamentos = _pagamentoService.ListarPagamentosPorAluno(alunoId);

            if (pagamentos != null && pagamentos.Count > 0)
            {
                return pagamentos;
            }
            else
            {
                MessageBox.Show("Nenhum pagamento encontrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return new List<Pagamento>(); // Retorna uma lista vazia se não houver pagamentos
            }
        }

    }   
}
