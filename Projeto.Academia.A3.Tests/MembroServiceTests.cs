using Projeto.Academia.A3.Models;
using Projeto.Academia.A3.Services;
using Moq;
using Xunit;
using MySql.Data.MySqlClient;

using Projeto.Academia.A3.Data;

namespace Projeto.Academia.A3.Tests
{
    public class MembroServiceTests
    {
       

        //[Fact]
        //public void Test_AdicionarMembro_DeveInserirComSucesso()
        //{
        //    // Arrange: Criar os dados do novo membro
        //    var random = new Random();
        //    string FakeCpf = random.Next(1000, 9999).ToString();

        //    var novoMembro = new Membro
        //    {
        //        Nome = "Teste Adiciona Membro",
        //        CPF = FakeCpf,
        //        Telefone = "11999999999",
        //        Endereco = "Rua Teste, 123"
        //    };

        //    // Act: Chamar o método AdicionarMembro
        //    var membroService = new MembroService();
        //    bool resultado = membroService.AdicionarMembro(novoMembro);

        //    // Log do resultado da inserção
        //    Console.WriteLine("Resultado do método AdicionarMembro: " + FakeCpf + " " + resultado);

        //    // Espera-se que o método retorne true se a inserção foi bem-sucedida
        //    Assert.True(resultado);

        //    try
        //    {
        //        using (var conexao = Conexao.ObterConexao())
        //        {
        //            var comando = new MySqlCommand("SELECT LAST_INSERT_ID();", conexao);
        //            int idInserido = Convert.ToInt32(comando.ExecuteScalar());

        //            bool excluido = membroService.ExcluirMembro(idInserido);
        //            Console.WriteLine($"Membro com ID {idInserido} excluído apos insercaoo: {excluido}");
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine("Erro ao excluir após inserção: " + ex.Message);
        //    }


        //}


        //[Fact]
        //public void Test_ExcluirMembro_DeveExcluirComSucesso()
        //{
        //    // Arrange: Criar membro só para este teste
        //    var random = new Random();
        //    string fakeCpf = random.Next(1000, 9999).ToString();

        //    var membroParaExcluir = new Membro
        //    {
        //        Nome = "Teste Exclusão",
        //        CPF = fakeCpf,
        //        Telefone = "11999999999",
        //        Endereco = "Rua Teste, 456"
        //    };

        //    var membroService = new MembroService();
        //    bool inserido = membroService.AdicionarMembro(membroParaExcluir);
        //    Assert.True(inserido, "Falha ao inserir membro para teste de exclusao.");

        //    int alunoIdInserido;

        //    // Obter o ID do último inserido
        //    using (var conexao = Conexao.ObterConexao())
        //    {
        //        var comando = new MySqlCommand("SELECT LAST_INSERT_ID();", conexao);
        //        alunoIdInserido = Convert.ToInt32(comando.ExecuteScalar());
        //    }

        //    Assert.True(alunoIdInserido > 0, "ID inválido do membro inserido.");

        //    // Act
        //    bool resultadoExclusao = membroService.ExcluirMembro(alunoIdInserido);

        //    // Assert
        //    Assert.True(resultadoExclusao, "Falha ao excluir o membro.");
        //}

        [Fact]
        public void Test_BuscarMembroPorCPF_DeveRetornarMembro()
        {
            // Arrange
            string cpf = "08926157458";  // CPF de exemplo, você pode substituir com um CPF válido
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





    }

}
