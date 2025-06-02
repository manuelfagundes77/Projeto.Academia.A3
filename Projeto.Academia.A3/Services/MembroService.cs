using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using Projeto.Academia.A3.Data;
using Projeto.Academia.A3.inteface;
using Projeto.Academia.A3.Models;



namespace Projeto.Academia.A3.Services
{
    public class MembroService
    {

        

       
        public MembroService()
        {
            
        }

        private readonly IConexao _conexao;

        public MembroService(IConexao conexao)
        {
            _conexao = conexao;
        }


        //  adicionar um novo Membro SALVA
        public bool AdicionarMembro(Membro membro) //volta um booleanoo
        {
            // Criar a conexão com o banco de dados
            MySqlConnection conexao = Conexao.ObterConexao();

            if (conexao == null)
            {
                return false; // Se a conexão falhar, retorna false
            }

            try
            {
                // Comando SQL para inserir um novo Membro
                string query = "INSERT INTO Membros (Nome, CPF, Telefone, Endereco) " +
                               "VALUES (@Nome, @CPF, @Telefone, @Endereco)";

                MySqlCommand comando = new MySqlCommand(query, conexao);
                comando.Parameters.AddWithValue("@Nome", membro.Nome);
                comando.Parameters.AddWithValue("@CPF", membro.CPF);
                comando.Parameters.AddWithValue("@Telefone", membro.Telefone);
                comando.Parameters.AddWithValue("@Endereco", membro.Endereco);

                int resultado = comando.ExecuteNonQuery();

                if (resultado > 0)
                {
                    string idQuery = "SELECT LAST_INSERT_ID()";
                    MySqlCommand idComando = new MySqlCommand(idQuery, conexao);
                    int alunoId = Convert.ToInt32(idComando.ExecuteScalar()); // Recupera o ID gerado automaticamente

                    // Agora podemos chamar o serviço de pagamentos com o AlunoId
                    var pagamentoService = new PagamentoService(); // LIGAR DEPOIISSS
                    pagamentoService.GerarPagamentosPendentes(alunoId); //LIGAR DEPOISS

                    return true; // Se o comando foi bem-sucedido, retorna true
                }
                else
                {
                    return false; // Se não houve inserção, retorna false
                }
            }
            catch (Exception ex)
            {
             
                Console.WriteLine("Erro ao adicionar membro: " + ex.Message); // Log de erro sem usar a interface gráfica
                return false;
            }
            finally
            {
                // Fecha a conexão após a operação
                Conexao.FecharConexao(conexao);
            }
        }

       


        //  listar todos os membros
        public List<Membro> ListarMembros()  
        {
            List<Membro> membros = new List<Membro>();
            MySqlConnection conexao = Conexao.ObterConexao();

            if (conexao == null)
            {
                return null;
            }

            try
            {
                string query = "SELECT * FROM Membros";
                MySqlCommand comando = new MySqlCommand(query, conexao);
                MySqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Membro membro = new Membro
                    {
                        AlunoId = reader.GetInt32("AlunoId"), // Corrigido para AlunoId
                        Nome = reader.GetString("Nome"),
                        CPF = reader.GetString("CPF"),
                        Telefone = reader.GetString("Telefone"),
                        Endereco = reader.GetString("Endereco"),
                        DataCadastro = reader.GetDateTime("DataCadastro") // Supondo que haja esse campo na tabela
                    };
                    membros.Add(membro);
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Erro ao listar membros: " + ex.Message);
                Console.WriteLine("Erro ao listar membros: " + ex.Message);
                return null;
            }
            finally
            {
                Conexao.FecharConexao(conexao);
            }

            return membros;
        }

        //buscar por CPF, volta do banco 
        public Membro BuscarMembroPorCPF(string cpf)
        {
            Membro membro = null;
            MySqlConnection conexao = Conexao.ObterConexao();

            if (conexao == null)
            {
                return null; // Se a conexão falhar, retorna null
            }

            try
            {
                string query = "SELECT * FROM Membros WHERE CPF = @CPF";
                MySqlCommand comando = new MySqlCommand(query, conexao);
                comando.Parameters.AddWithValue("@CPF", cpf);
                MySqlDataReader reader = comando.ExecuteReader();

                if (reader.Read())
                {
                    membro = new Membro
                    {
                        AlunoId = reader.GetInt32("AlunoId"),
                        Nome = reader.GetString("Nome"),
                        CPF = reader.GetString("CPF"),
                        Telefone = reader.GetString("Telefone"),
                        Endereco = reader.GetString("Endereco"),
                        DataCadastro = reader.GetDateTime("DataCadastro")
                    };
                }
            }
            catch (Exception ex)
            {
              //  MessageBox.Show("Erro ao buscar membro: " + ex.Message);
                Console.WriteLine("Erro ao buscar membro: " + ex.Message);
            }
            finally
            {
                Conexao.FecharConexao(conexao);
            }

            return membro;
        }

        public bool EditarMembro(Membro membro)  //busca por ID do membro //volta um booleanoo
        {
            MySqlConnection conexao = Conexao.ObterConexao();

            if (conexao == null)
            {
                return false;
            }

            try
            {
                // Buscar os dados atuais do membro no banco de dados
                string queryBuscar = "SELECT * FROM Membros WHERE AlunoId = @AlunoId"; //Seleciona pelo ID
                MySqlCommand comandoBuscar = new MySqlCommand(queryBuscar, conexao);
                comandoBuscar.Parameters.AddWithValue("@AlunoId", membro.AlunoId);
                MySqlDataReader reader = comandoBuscar.ExecuteReader();

                if (!reader.Read())
                {
                    reader.Close();
                    return false; // Membro não encontrado
                }

                // Verifica se houve alguma mudança nos dados
                bool houveAlteracao = false;

                // Verificar cada campo
                if (reader.GetString("Nome") != membro.Nome)
                    houveAlteracao = true;
                if (reader.GetString("CPF") != membro.CPF)
                    houveAlteracao = true;
                if (reader.GetString("Telefone") != membro.Telefone)
                    houveAlteracao = true;
                if (reader.GetString("Endereco") != membro.Endereco)
                    houveAlteracao = true;

                reader.Close(); // Fecha o reader após a leitura

                // Se não houve alteração, retorna false
                if (!houveAlteracao)
                    return false;

                // Caso tenha havido alguma mudança, realiza a edição no banco
                string queryUpdate = "UPDATE Membros SET Nome = @Nome, CPF = @CPF, Telefone = @Telefone, Endereco = @Endereco WHERE AlunoId = @AlunoId";

                MySqlCommand comandoUpdate = new MySqlCommand(queryUpdate, conexao);
                comandoUpdate.Parameters.AddWithValue("@Nome", membro.Nome);
                comandoUpdate.Parameters.AddWithValue("@CPF", membro.CPF);
                comandoUpdate.Parameters.AddWithValue("@Telefone", membro.Telefone);
                comandoUpdate.Parameters.AddWithValue("@Endereco", membro.Endereco);
                comandoUpdate.Parameters.AddWithValue("@AlunoId", membro.AlunoId);

                int resultado = comandoUpdate.ExecuteNonQuery();

                // Retorna true se a edição for bem-sucedida, caso contrário retorna false
                return resultado > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            finally
            {
                Conexao.FecharConexao(conexao);
            }
        }

        public bool ExcluirMembro(int alunoId)  //exclui o membro pelo ID
        {
            MySqlConnection conexao = Conexao.ObterConexao();

            if (conexao == null)
            {
                return false;
            }

            try
            {
                // Comando para excluir o membro pelo ID
                string queryDelete = "DELETE FROM Membros WHERE AlunoId = @AlunoId";

                MySqlCommand comandoDelete = new MySqlCommand(queryDelete, conexao);
                comandoDelete.Parameters.AddWithValue("@AlunoId", alunoId);

                int resultado = comandoDelete.ExecuteNonQuery();

                // Retorna true se a exclusão for bem-sucedida
                return resultado > 0;
            }
            catch (Exception ex)
            {
               // MessageBox.Show("Erro ao excluir membro: " + ex.Message);
                Console.WriteLine("Erro ao excluir membro: " + ex.Message);
                return false;
            }
            finally
            {
                Conexao.FecharConexao(conexao);
            }
        }








    }
}
