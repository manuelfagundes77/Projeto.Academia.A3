using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.Academia.A3.Models;
using Projeto.Academia.A3.Services;

namespace Projeto.Academia.A3.Tests
{
    public class TreinoServiceTest

    {
        private readonly TreinoService _treinoService;

        public TreinoServiceTest()
        {

            _treinoService = new TreinoService();
        }
        [Fact]
        public void AdicionarTreino_DeveAdicionarTreinoComSucesso()
        {
            // Arrange
            var dataInicio = DateTime.Now;  // Data e hora atual para DataInicio
            var treino = new Treino
            {
                AlunoId = 8,  // ID do aluno conforme informado
                Tipo = "Musculação",
                Descricao = "Treino de força",
                Duracao = "2025",  // Duracao é a mesma que DataInicio
                DataInicio = dataInicio,  // Data de início do treino com a data e hora atual
                FuncionarioId = 1 // ID do funcionário conforme informado
            };

            // Act
            int treinoId = _treinoService.AdicionarTreino(treino);

            // Assert
            Assert.NotEqual(-1, treinoId);  // O ID retornado deve ser diferente de -1 se for adicionado com sucesso
        }

        [Fact]
        public void ObterTreinos_DeveRetornarTreinos_QuandoAlunoIdExistente()
        {
            // Arrange
            var treinoService = new TreinoService();
            int alunoId = 8;

            // Act
            List<Treino> resultado = treinoService.ObterTreinos(alunoId);

            // Assert
            Assert.NotNull(resultado);
            Assert.True(resultado.Count > 0, "Esperado pelo menos um treino.");
        }


        [Fact]
        public void ObterTreinosPorFuncionario_DeveRetornarTreinos_QuandoFuncionarioIdExistente()
        {
            var treinoService = new TreinoService();
            int funcionarioId = 1;

            List<TreinoComAlunoDTO> resultado = treinoService.ObterTreinosPorFuncionario(funcionarioId);

            Assert.NotNull(resultado);
            Assert.True(resultado.Count > 0, "Esperado pelo menos um treino para o funcionário.");
        }




    }
}
