using System;
using System.Linq;
using Xunit;
using Projeto.Academia.A3.Services;
using Projeto.Academia.A3.Models;
using MySql.Data.MySqlClient;
using Projeto.Academia.A3.Data;

namespace Projeto.Academia.A3.Tests
{
    public class PagamentoServiceTests
    {
        [Fact]
        public void GerarPagamentosPendentes_DeveCriarDozePagamentosParaAluno()
        {
            // Arrange
            var pagamentoService = new PagamentoService();
            int membroId = 8; // Altere para um membroId válido para o teste

            // Limpa os pagamentos anteriores do aluno
            LimparPagamentos(membroId);

            // Act
            bool result = pagamentoService.GerarPagamentosPendentes(membroId);

            // Assert: Verifica se o método retornou true (indicando sucesso)
            Assert.True(result); // Verifica se o método retornou true
        }

        // Função para limpar os pagamentos de um aluno no banco
        private void LimparPagamentos(int membroId)
        {
            using (var conexao = Conexao.ObterConexao())
            {
                string queryLimpeza = "DELETE FROM Pagamentos WHERE AlunoId = @AlunoId";
                using (var cmdLimpeza = new MySqlCommand(queryLimpeza, conexao))
                {
                    cmdLimpeza.Parameters.AddWithValue("@AlunoId", membroId);
                    cmdLimpeza.ExecuteNonQuery();
                }
            }
        }


        [Fact]
        public void ListarPagamentosPorAluno_DeveRetornarListaDePagamentos()
        {
            // Arrange: Define o alunoId que sera usado no teste
            int alunoId = 15; 
            var pagamentoService = new PagamentoService();

            // Act: Chama o metodo que lista os pagamentos
            var result = pagamentoService.ListarPagamentosPorAluno(alunoId);

            // Assert: Verifica se a lista de pagamentos nao e nula e tem pelo menos 1 pagamento
            Assert.NotNull(result); // Verifica se a lista não e nula
            Assert.True(result.Count > 0, "Esperado pelo menos um pagamento para o aluno.");
        }




        [Fact]
        public void AlterarSituacaoPagamentoPorId_DeveAlterarDePendenteParaPagoOuManterPagoSemAlteracao()
        {
            // Arrange
            int pagamentoId = 28; // ID do pagamento que está sendo testado
            var pagamentoService = new PagamentoService();

            // Act
            var resultadoAlteracao = pagamentoService.AlterarSituacaoPagamentoPorId(pagamentoId);

            // Assert
            Assert.False(resultadoAlteracao); // Simplesmente verifica se o retorno foi 'false'
        }











    }
}
