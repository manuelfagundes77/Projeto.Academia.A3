using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.Academia.A3.Models;

namespace Projeto.Academia.A3.Tests
{
    public class FuncionarioServiceUnitarioTests
    {
        [Fact]
        public void ValidarLogin_DeveRetornarTrue_QuandoLoginESenhaValidos()
        {
            var service = new FakeFuncionarioService();
            bool resultado = service.ValidarLogin("ad", "123");
            Assert.True(resultado);
        }

        [Fact]
        public void ValidarLogin_DeveRetornarFalse_QuandoLoginOuSenhaInvalidos()
        {
            var service = new FakeFuncionarioService();
            bool resultado = service.ValidarLogin("invalido", "senhaErrada");
            Assert.False(resultado);
        }

        [Fact]
        public void AdicionarFuncionario_DeveRetornarTrue_QuandoFuncionarioNovo()
        {
            var service = new FakeFuncionarioService();
            var novoFuncionario = new Funcionario
            {
                Nome = "Maria",
                Cargo = "Assistente",
                Login = "maria",
                Senha = "senha321"
            };

            bool resultado = service.AdicionarFuncionario(novoFuncionario);
            Assert.True(resultado);
        }

        [Fact]
        public void AdicionarFuncionario_DeveRetornarFalse_QuandoLoginJaExistente()
        {
            var service = new FakeFuncionarioService();
            var funcionarioExistente = new Funcionario
            {
                Nome = "João Silva",
                Cargo = "Gerente",
                Login = "joao",
                Senha = "senha123"
            };

            bool resultado = service.AdicionarFuncionario(funcionarioExistente);
            Assert.False(resultado);
        }

        [Fact]
        public void BuscarFuncionarioPorLogin_DeveRetornarFuncionario_QuandoExistente()
        {
            var service = new FakeFuncionarioService();
            var funcionario = service.BuscarFuncionarioPorLogin("ad", "123");
            Assert.NotNull(funcionario);
            Assert.Equal("ad", funcionario.Login);
        }

        [Fact]
        public void BuscarFuncionarioPorLogin_DeveRetornarNull_QuandoNaoExistente()
        {
            var service = new FakeFuncionarioService();
            var funcionario = service.BuscarFuncionarioPorLogin("usuarioInvalido", "senhaErrada");
            Assert.Null(funcionario);
        }

        [Fact]
        public void ObterTodosFuncionarios_DeveRetornarListaNaoVazia()
        {
            var service = new FakeFuncionarioService();
            var funcionarios = service.ObterTodosFuncionarios();
            Assert.NotNull(funcionarios);
            Assert.NotEmpty(funcionarios);
        }
    }
}
