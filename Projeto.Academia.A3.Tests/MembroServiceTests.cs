using Projeto.Academia.A3.Models;
using Projeto.Academia.A3.Services;
using Moq;
using Xunit;
using MySql.Data.MySqlClient;

using Projeto.Academia.A3.Data;
using Projeto.Academia.A3.inteface;
using System.Data;

namespace Projeto.Academia.A3.Tests
{
    public class MembroServiceTests
    {


        [Fact]
        public void Test_AdicionarMembro_DeveInserirComSucesso()
        {
            // Arrange: Criar os dados do novo membro
            var random = new Random();
            string FakeCpf = random.Next(1000, 9999).ToString();

            var novoMembro = new Membro
            {
                Nome = "Teste Adiciona Membro",
                CPF = FakeCpf,
                Telefone = "11999999999",
                Endereco = "Rua Teste, 123"
            };

            // Act: Chamar o método AdicionarMembro
            var membroService = new MembroService();
            bool resultado = membroService.AdicionarMembro(novoMembro);

            // Log do resultado da inserção
            Console.WriteLine("Resultado do método AdicionarMembro: " + FakeCpf + " " + resultado);

            // Espera se que o metodo retorne true se a inserçao foi bem sucedida
            Assert.True(resultado);

            //try
            //{
            //    using (var conexao = Conexao.ObterConexao())
            //    {
            //        var comando = new MySqlCommand("SELECT LAST_INSERT_ID();", conexao);
            //        int idInserido = Convert.ToInt32(comando.ExecuteScalar());

            //        bool excluido = membroService.ExcluirMembro(idInserido);
            //        Console.WriteLine($"Membro com ID {idInserido} excluído apos insercaoo: {excluido}");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Erro ao excluir após inserção: " + ex.Message);
            //}


        }


        [Fact]
        public void Test_ExcluirMembro_DeveExcluirComSucesso()
        {
            // Arrange: Criar membro só para este teste
            var random = new Random();
            string fakeCpf = random.Next(1000, 9999).ToString();

            var membroParaExcluir = new Membro
            {
                Nome = "Teste Exclusão",
                CPF = fakeCpf,
                Telefone = "11999999999",
                Endereco = "Rua Teste, 456"
            };

            var membroService = new MembroService();
            bool inserido = membroService.AdicionarMembro(membroParaExcluir);
            Assert.True(inserido, "Falha ao inserir membro para teste de exclusao.");

            int alunoIdInserido;

            // Obter o ID do último inserido
            using (var conexao = Conexao.ObterConexao())
            {
                var comando = new MySqlCommand("SELECT LAST_INSERT_ID();", conexao);
                alunoIdInserido = Convert.ToInt32(comando.ExecuteScalar());
            }

            Assert.True(alunoIdInserido > 0, "ID inválido do membro inserido.");

            // Act
            bool resultadoExclusao = membroService.ExcluirMembro(alunoIdInserido);

            // Assert
            Assert.True(resultadoExclusao, "Falha ao excluir o membro.");
        }

        [Fact]
        public void Test_BuscarMembroPorCPF_DeveRetornarMembro()
        {
            // Arrange
            string cpf = "08926157458";  // CPF de exemplo
            var membroService = new MembroService();

            // Act
            Membro membro = membroService.BuscarMembroPorCPF(cpf);

            // Assert
            Assert.NotNull(membro);  // Verifica se um membro foi encontrado
            Assert.Equal(cpf, membro.CPF);  // Verifica se o CPF corresponde
            Console.WriteLine($"Membro encontrado: {membro.Nome}, ID: {membro.AlunoId}");
        }


        [Fact]
        public void Test_EditarMembro_DeveAlterarTelefoneComSucesso()
        {
            // Arrange: Definir o CPF do membro que queremos editar
            string cpf = "08926157458";  // CPF de exemplo

            var random = new Random();
            string telefoneAlterado = "119" + random.Next(10000000, 99999999).ToString(); // Novo telefone 

            // Buscar o membro original pelo CPF
            var membroService = new MembroService();
            Membro membro = membroService.BuscarMembroPorCPF(cpf);

            // Verificar se o membro foi encontrado
            Assert.NotNull(membro);  // Verifica se um membro foi encontrado

            // Alterar o telefone
            membro.Telefone = telefoneAlterado;

            // Act: Chamar o metodo EditarMembro
            bool edicaoBemSucedida = membroService.EditarMembro(membro);

            // Assert: Verificar se a edição foi sucedida
            Assert.True(edicaoBemSucedida, "Falha ao editar o membro.");

            // Buscar o membro novamente para garantir que a alteração foi feita
            Membro membroBuscado = membroService.BuscarMembroPorCPF(cpf);

            // Verificar se o telefone foi alterado
            Assert.Equal(telefoneAlterado, membroBuscado.Telefone);
            Console.WriteLine($"Membro encontrado: {membroBuscado.Nome}, Novo telefone: {membroBuscado.Telefone}");
        }

        [Fact]
        public void ListarMembros_DeveRetornarMembros()
        {
            // Act
            var membros = new MembroService().ListarMembros();

            // Assert
            Assert.NotNull(membros);  // Verifica se não retornou nulo
            Assert.True(membros.Count > 0);  // Verifica se retornou algum membro
            Assert.All(membros, membro =>
            {
                Assert.NotNull(membro.Nome);  // Verifica se o nome do membro não é nulo
                Assert.NotNull(membro.CPF);   // Verifica se o CPF do membro não é nulo
                Assert.NotNull(membro.Telefone); // Verifica se o telefone do membro não é nulo
                Assert.NotNull(membro.Endereco); // Verifica se o endereço do membro não é nulo
            });
        }


        [Fact]
        public void ListarMembros_DeveRetornarFakeUNITARIO()
        {
            // Arrange
            IMembroService service = new MembroServiceFake();

            // Act
            var membros = service.ListarMembros();

            // Assert
            Assert.NotNull(membros);
            Assert.Single(membros);
            Assert.Equal("Manuel", membros[0].Nome);
        }

        [Fact]
        public void BuscarMembroPorCPF_QuandoExistirMembro_RetornarMembroUNITARIO()
        {
            // Arrange
            var fakeData = new List<Dictionary<string, object>>
        {
            new Dictionary<string, object>
            {
                { "AlunoId", 1 },
                { "Nome", "João Silva" },
                { "CPF", "12345678900" },
                { "Telefone", "123456789" },
                { "Endereco", "Rua Exemplo, 123" },
                { "DataCadastro", DateTime.Now }
            }
        };

            // Cria o fake reader com os dados simulados
            var fakeReader = new FakeMySqlDataReader(fakeData);

            // Aqui, vamos testar o método modificado para usar o fake
            var service = new FakeMySqlDataReader(fakeData);

            // Act
            var membro = service.BuscarMembroPorCPFComFake("12345678900", fakeReader);

            // Assert
            Assert.NotNull(membro);
            Assert.Equal(1, membro.AlunoId);
            Assert.Equal("João Silva", membro.Nome);
            Assert.Equal("12345678900", membro.CPF);
            Assert.Equal("123456789", membro.Telefone);
            Assert.Equal("Rua Exemplo, 123", membro.Endereco);
        }



        [Fact]
        public void AdicionarMembro_DeveRetornarTrue_QuandoInsercaoForBemSucedidaUnitario()
        {
            // Arrange
            var conexaoFake = new ConexaoFake();
            var comandoInsercaoFake = new FakeMySqlCommand(true); // simula inserção com sucesso
            var comandoIdFake = new FakeMySqlCommand(true);

            var service = new MembroServiceFakeComAdicao(conexaoFake, comandoInsercaoFake, comandoIdFake);

            var novoMembro = new Membro
            {
                Nome = "Carlos Silva",
                CPF = "12312312312",
                Telefone = "11999998888",
                Endereco = "Rua da Praia, 100"
            };

            // Act
            bool resultado = service.AdicionarMembro(novoMembro);

            // Assert
            Assert.True(resultado);
        }


        [Fact]
        public void EditarMembro_DeveRetornarTrue_QuandoAlteracaoForDetectadaUNITARIO()
        {
            var conexaoFake = new ConexaoFake();

            var dadosFake = new List<Dictionary<string, object>>
        {
            new Dictionary<string, object>
            {
                {"Nome", "Carlos Silva"},
                {"CPF", "12312312312"},
                {"Telefone", "11999998888"},
                {"Endereco", "Rua da Praia, 100"}
            }
        };
            var readerFake = new FakeMySqlDataReader(dadosFake);

            var comandoUpdateFake = new FakeMySqlCommand(true); // simula update bem sucedido

            var service = new MembroServiceFakeComEdicao(conexaoFake, readerFake, comandoUpdateFake);

            var membroEditado = new Membro
            {
                Nome = "Carlos Silva Editado",
                CPF = "12312312312",
                Telefone = "11999998888",
                Endereco = "Rua da Praia, 100"
            };

            bool resultado = service.EditarMembro(membroEditado);

            Assert.True(resultado);
        }

        [Fact]
        public void ExcluirMembro_DeveRetornarTrue_QuandoExclusaoForBemSucedidaUnitario()
        {
            var conexaoFake = new ConexaoFake();
            var comandoDeleteFake = new FakeMySqlCommand(true); // true simula exclusão bem-sucedida

            var service = new MembroServiceFakeComExclusao(conexaoFake, comandoDeleteFake);

            int alunoIdParaExcluir = 42;

            bool resultado = service.ExcluirMembro(alunoIdParaExcluir);

            Assert.True(resultado);
        }







    }

}
