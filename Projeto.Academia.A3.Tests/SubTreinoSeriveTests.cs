using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.Academia.A3.Models;
using Projeto.Academia.A3.Services;

namespace Projeto.Academia.A3.Tests
{
    public class SubTreinoServiceTests
    {

        [Fact]
        public void AdicionarSubTreino_DeveAdicionarSubTreinoComSucesso()
        {
            // Arrange
            // Criação do objeto treino
            var dataInicio = DateTime.Now;  // Data e hora atual para DataInicio
            var treino = new Treino
            {
                AlunoId = 8,  // ID do aluno
                Tipo = "Musculação",
                Descricao = "Teste 5SUBTREINO",
                Duracao = "2025",  
                DataInicio = dataInicio,  // Data de início do treino com a data e hora atual
                FuncionarioId = 1 // ID do funcionario 
            };

           
            var _treinoService = new TreinoService();
            int treinoId = _treinoService.AdicionarTreino(treino);

            // Verifica se o treino foi adicionado corretamente
            Assert.NotEqual(-1, treinoId);  // O ID retornado deve ser diferente de -1 se for adicionado com sucesso

            // Criaçao do objeto subtreino relacionado ao treino criado
            var subTreino = new SubTreino
            {
                TreinoId = treinoId,  // Usando o ID do treino recemcriado
                Nome = "A - Peito"  // Nome do subtreino
            };

            // Instanciando o serviço que adiciona o subtreino
            var _subTreinoService = new SubTreinoService(); 
            int subTreinoId = _subTreinoService.AdicionarSubTreino(subTreino);

            // Assert
            Assert.NotEqual(-1, subTreinoId);  // O ID retornado deve ser diferente de -1 se o subtreino foi adicionado com sucesso
        }

        [Fact]
        public void ObterTreinos_DeveRetornarTreinosDoAlunoId8()
        {
            // Arrange
            var alunoId = 8; // ID do aluno

            var _treinoService = new TreinoService();

            // Act - Obter os treinos do aluno com ID 8
            var treinosObtidos = _treinoService.ObterTreinos(alunoId);

            // Assert - Verifica se a lista de treinos nao e nula e se contem treinos
            Assert.NotNull(treinosObtidos);  // A lista nao pode ser nula
            Assert.True(treinosObtidos.Count > 0, "A lista de treinos não deve estar vazia");  // A lista deve ter ao menos um treino
        }

        [Fact]
        public void ObterTreinosPorFuncionario_DeveRetornarTreinosDoFuncionarioId1()
        {
            // Arrange
            var funcionarioId = 1; // ID do funcionário que estamos buscando os treinos

            var _treinoService = new TreinoService();

            // Act - Obter os treinos do funcionário com ID 1
            var treinosObtidos = _treinoService.ObterTreinosPorFuncionario(funcionarioId);

            // Assert - Verifica se a lista de treinos não é nula e se contém treinos
            Assert.NotNull(treinosObtidos);  // A lista não pode ser nula
            Assert.True(treinosObtidos.Count > 0, "A lista de treinos não deve estar vazia");  // A lista deve ter ao menos um treino
        }





    }








}
