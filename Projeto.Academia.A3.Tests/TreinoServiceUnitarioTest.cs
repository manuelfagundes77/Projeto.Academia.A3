using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.Academia.A3.Models;

namespace Projeto.Academia.A3.Tests
{
    public class TreinoServiceUnitarioTests
    {
        private readonly FakeTreinoService _fakeService;

        public TreinoServiceUnitarioTests()
        {
            _fakeService = new FakeTreinoService();//criação do fake para usar como moq
        }

        [Fact]
        public void ObterTreinosPorFuncionario_RetornaTreinosCorretos()
        {
            // Arrange
            int funcionarioId = 100;

            // Act
            var resultado = _fakeService.ObterTreinosPorFuncionario(funcionarioId);

            // Assert
            Assert.NotNull(resultado);
            Assert.True(resultado.Count > 0, "Deve retornar pelo menos um treino para o funcionário.");
            Assert.All(resultado, t => Assert.Equal(funcionarioId, _fakeService.ObterTreinoPorId(t.TreinoId).FuncionarioId));
        }

        [Fact]
        public void ObterTreinoPorId_TreinoExistente_RetornaTreino()
        {
            // Arrange
            int treinoId = 1;

            // Act
            var treino = _fakeService.ObterTreinoPorId(treinoId);

            // Assert
            Assert.NotNull(treino);
            Assert.Equal(treinoId, treino.TreinoId);
        }

        [Fact]
        public void ObterTreinoPorId_TreinoNaoExistente_RetornaNull()
        {
            // Arrange
            int treinoIdInexistente = 999;

            // Act
            var treino = _fakeService.ObterTreinoPorId(treinoIdInexistente);

            // Assert
            Assert.Null(treino);
        }

        [Fact]
        public void AdicionarTreino_DeveAdicionarTreinoNaLista()
        {
            // Arrange
            var novoTreino = new Treino
            {
                TreinoId = 99,
                AlunoId = 20,
                FuncionarioId = 100,
                Tipo = "Flexibilidade",
                Descricao = "Treino de alongamento",
                Duracao = "30",
                DataInicio = DateTime.Today
            };

            // Act
            _fakeService.AdicionarTreino(novoTreino);
            var treinoAdicionado = _fakeService.ObterTreinoPorId(99);

            // Assert
            Assert.NotNull(treinoAdicionado);
            Assert.Equal("Flexibilidade", treinoAdicionado.Tipo);
        }

        [Fact]
        public void RemoverTreino_TreinoExistente_DeveRemoverERetornarTrue()
        {
            // Arrange
            int treinoId = 1;

            // Act
            var resultado = _fakeService.RemoverTreino(treinoId);
            var treinoDepoisRemover = _fakeService.ObterTreinoPorId(treinoId);

            // Assert
            Assert.True(resultado);
            Assert.Null(treinoDepoisRemover);
        }

        [Fact] 
        public void RemoverTreino_TreinoNaoExistente_RetornaFalse()
        {
            // Arrange
            int treinoIdInexistente = 1000;

            // Act
            var resultado = _fakeService.RemoverTreino(treinoIdInexistente);

            // Assert
            Assert.False(resultado);
        }
    }
}
