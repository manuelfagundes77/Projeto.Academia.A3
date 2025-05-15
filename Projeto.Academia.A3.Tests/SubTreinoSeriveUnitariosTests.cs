using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.Academia.A3.Models;

namespace Projeto.Academia.A3.Tests
{
   
    public class SubTreinoServiceUnitarioTests
    {
        // Criamos uma instancia da FakeSubTreinoService para usar nos testes
        private readonly FakeSubTreinoService _service;

        // Construtor da classe de teste - aqui inicializamos o serviço fake
        public SubTreinoServiceUnitarioTests()
        {
            _service = new FakeSubTreinoService();
        }

        // Teste para verificar se ao adicionar um SubTreino valido retorna um ID positivo (> 0)
        [Fact] 
        public void AdicionarSubTreino_Valido_RetornaIdPositivo()
        {
            // Criamos um SubTreino novo com dados validos
            var novoSubTreino = new SubTreino { TreinoId = 10, Nome = "Teste SubTreino" };

            // Chamamos o metodo para adicionar o SubTreino e guardamos o id retornado
            int id = _service.AdicionarSubTreino(novoSubTreino);

            // Verificamos se o id e maior que zero (esperado para sucesso)
            Assert.True(id > 0);
        }

     

        // Teste para adicionar uma lista valida de SubTreinos e esperar que retorne true (sucesso)
        [Fact]
        public void AdicionarListaSubTreinos_ListaValida_RetornaTrue()
        {
            // Criamos uma lista com dois SubTreinos validos (nome preenchido)
            var lista = new List<SubTreino>
            {
                new SubTreino { Nome = "SubTreino 1" },
                new SubTreino { Nome = "SubTreino 2" }
            };

            // Chamamos o metodo para adicionar a lista ao treino de id 5
            bool resultado = _service.AdicionarListaSubTreinos(lista, 5);

            // Verificamos se o metodo retornou true, indicando sucesso na inclusao
            Assert.True(resultado);
        }


        // Teste para obter a lista de SubTreinos com Exercicios para um treino que existe (id = 1)
        [Fact]
        public void ObterSubTreinosComExercicios_TreinoExistente_RetornaSubTreinos()
        {
            // O fake ja inicia com 2 SubTreinos com TreinoId = 1, entao esperamos pegar essa lista
            var lista = _service.ObterSubTreinosComExercicios(1);

            // Verificamos se a lista nao esta vazia
            Assert.NotEmpty(lista);
            // Verificamos se todos os SubTreinos retornados tem TreinoId igual a 1
            Assert.All(lista, st => Assert.Equal(1, st.TreinoId));
        }

        // Teste para obter lista de SubTreinos para um treino que nao existe (id 999), deve retornar lista vazia
        [Fact]
        public void ObterSubTreinosComExercicios_TreinoInexistente_RetornaListaVazia()
        {
            var lista = _service.ObterSubTreinosComExercicios(999);

            // Verificamos se a lista esta vazia, pois nao existe treino com esse id
            Assert.Empty(lista);
        }
    }
}
