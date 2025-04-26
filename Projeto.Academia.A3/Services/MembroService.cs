using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Projeto.Academia.A3.Data;
using Projeto.Academia.A3.Models;
using System.Windows.Forms;

namespace Projeto.Academia.A3.Services
{
    public class MembroService
    {
        // Método para adicionar um novo Membro
        public bool AdicionarMembro(Membro membro)
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
                    return true; // Se o comando foi bem-sucedido, retorna true
                }
                else
                {
                    return false; // Se não houve inserção, retorna false
                }
            }
            catch (Exception ex)
            {
                // Em caso de erro, exibe a mensagem de erro
                MessageBox.Show("Erro ao adicionar membro: " + ex.Message);
                return false;
            }
            finally
            {
                // Fecha a conexão após a operação
                Conexao.FecharConexao(conexao);
            }
        }
    }
}
