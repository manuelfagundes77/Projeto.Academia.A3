using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.Academia.A3.Models;
using Projeto.Academia.A3.Services;

namespace Projeto.Academia.A3.Tests
{
    public class FuncionarioServiceTest
    {
        [Fact]
        public void Test_ValidarLogin_DeveRetornarTrueQuandoLoginValido()
        {
            // Arrange
            string login = "ad";
            string senha = "123";
            var funcionarioService = new FuncionarioService();

            // Act
            bool resultado = funcionarioService.ValidarLogin(login, senha);

            // Assert
            Assert.True(resultado);
        }

        [Fact]
        public void Test_ValidarLogin_DeveRetornarFalseQuandoLoginInvalido()
        {
            // Arrange
            string login = "invalido";
            string senha = "senhaErrada"; // Login e senha inválidos
            var funcionarioService = new FuncionarioService();

            // Act
            bool resultado = funcionarioService.ValidarLogin(login, senha);

            // Assert
            Assert.False(resultado); // Espera que o login seja invalido
        }

        [Fact]
        public void Test_AdicionarFuncionario_DeveAdicionarComSucesso()
        {
            // Arrange
            var random = new Random();
            string FakeLogin = random.Next(1000, 9999).ToString();
            var funcionario = new Funcionario
            {
                Nome = "João Silva "+ FakeLogin,
                Cargo = "Gerente",
                Login = "joao.silva" + FakeLogin,
                Senha = "senha123"
            };
            var funcionarioService = new FuncionarioService();

            // Act
            bool resultado = funcionarioService.AdicionarFuncionario(funcionario);

            // Assert
            Assert.True(resultado); // Espera-se que o funcionario seja adicionado com sucesso
        }

        [Fact]
        public void Test_BuscarFuncionarioPorLogin_DeveRetornarFuncionario()
        {
            // Arrange
            string login = "ad";
            string senha = "123"; // Substitua com um login valido
            var funcionarioService = new FuncionarioService();

            // Act
            Funcionario funcionario = funcionarioService.BuscarFuncionarioPorLogin(login, senha);

            // Assert
            Assert.NotNull(funcionario); // Espera que o funcionario seja encontrado
            Assert.Equal(login, funcionario.Login); // Verifica se o login corresponde
        }

      

        [Fact]
        public void Test_ObterTodosFuncionarios_DeveRetornarListaDeFuncionarios()
        {
            // Arrange
            var funcionarioService = new FuncionarioService();

            // Act
            List<Funcionario> funcionarios = funcionarioService.ObterTodosFuncionarios();

            // Assert
            Assert.NotNull(funcionarios); // Espera que a lista de funcionarios não seja nula
            Assert.NotEmpty(funcionarios); // Espera que a lista de funcionarios contenha itens
        }
    }
}
