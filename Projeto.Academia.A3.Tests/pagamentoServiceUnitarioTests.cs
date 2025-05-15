using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Academia.A3.Tests
{
   public class pagamentoServiceUnitarioTests
    {
        private readonly FakePagamentoService _service;

        public pagamentoServiceUnitarioTests()
        {
            _service = new FakePagamentoService();
        }

        [Fact]
        public void GerarPagamentosPendentes_DeveCriar12PagamentosComSituacaoPendente()
        {
            int alunoId = 100;

            bool resultado = _service.GerarPagamentosPendentes(alunoId);

            Assert.True(resultado);

            var pagamentos = _service.ListarPagamentosPorAluno(alunoId);
            Assert.NotNull(pagamentos);
            Assert.Equal(12, pagamentos.Count);

            foreach (var pagamento in pagamentos)
            {
                Assert.Equal(alunoId, pagamento.AlunoId);
                Assert.Equal("Pendente", pagamento.Situacao);
                Assert.Null(pagamento.DataPagamento);

                // Mes no formato MM/yyyy
                Assert.Matches(@"^\d{2}/\d{4}$", pagamento.Mes);
            }
        }

        [Fact]
        public void AlterarSituacaoPagamentoPorId_DeveAlterarSituacaoParaPagoSePendente()
        {
            int alunoId = 101;
            _service.GerarPagamentosPendentes(alunoId);
            var pagamento = _service.ListarPagamentosPorAluno(alunoId).First();

            bool alterou = _service.AlterarSituacaoPagamentoPorId(pagamento.PagamentoId);

            Assert.True(alterou);

            var pagamentosAtualizados = _service.ListarPagamentosPorAluno(alunoId);
            var pagamentoAtualizado = pagamentosAtualizados.First(p => p.PagamentoId == pagamento.PagamentoId);

            Assert.Equal("Pago", pagamentoAtualizado.Situacao);
            Assert.NotNull(pagamentoAtualizado.DataPagamento);
            Assert.InRange(pagamentoAtualizado.DataPagamento.Value, DateTime.Now.AddMinutes(-1), DateTime.Now.AddMinutes(1));
        }

        [Fact]
        public void AlterarSituacaoPagamentoPorId_NaoDeveAlterarSePagamentoNaoExistirOuNaoForPendente()
        {
            int alunoId = 102;
            _service.GerarPagamentosPendentes(alunoId);
            var pagamento = _service.ListarPagamentosPorAluno(alunoId).First();

            // Primeiro alterar para pago
            bool alterouPrimeiraVez = _service.AlterarSituacaoPagamentoPorId(pagamento.PagamentoId);
            Assert.True(alterouPrimeiraVez);

            // Tentar alterar novamente (já pago)
            bool alterouSegundaVez = _service.AlterarSituacaoPagamentoPorId(pagamento.PagamentoId);
            Assert.False(alterouSegundaVez);

            // Tentar alterar pagamento inexistente
            bool alterouPagamentoInexistente = _service.AlterarSituacaoPagamentoPorId(9999);
            Assert.False(alterouPagamentoInexistente);
        }

        [Fact]
        public void ListarPagamentosPorAluno_DeveRetornarListaOrdenadaPorMes()
        {
            int alunoId = 103;
            _service.GerarPagamentosPendentes(alunoId);

            var pagamentos = _service.ListarPagamentosPorAluno(alunoId);

            Assert.NotEmpty(pagamentos);

            // Checar se está ordenado por data (convertendo o Mes para DateTime)
            DateTime mesAnterior = DateTime.MinValue;
            foreach (var pagamento in pagamentos)
            {
                DateTime mesAtual = DateTime.ParseExact("01/" + pagamento.Mes, "dd/MM/yyyy", null);
                Assert.True(mesAtual >= mesAnterior);
                mesAnterior = mesAtual;
            }
        }
    }
}

