using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Projeto.Academia.A3.Data
{
   public class Conexao
    {
        // Variáveis para os dados de conexão
        private static string servidor = "localhost";
        private static string usuario = "root";
        private static string senha = "123456789";
        private static string bancoDeDados = "dbacademia";

        // Método para obter a string de conexão
        private static string ObterConexaoString()
        {
            return $"server={servidor};user id={usuario};password={senha};database={bancoDeDados}";
        }

        // Método para abrir a conexão
        public static MySqlConnection ObterConexao()
        {
            MySqlConnection conexao = new MySqlConnection(ObterConexaoString());

            try
            {
                conexao.Open();
              //  MessageBox.Show("Conexão com o banco de dados realizada com sucesso!");
                Console.WriteLine("Conexão com o banco de dados realizada com sucesso!");
                return conexao;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar ao banco de dados: " + ex.Message);
                return null;
            }
        }

        // Método para fechar a conexão
        public static void FecharConexao(MySqlConnection conexao)
        {
            if (conexao != null && conexao.State == System.Data.ConnectionState.Open)
            {
                conexao.Close();
            }
        }
    }
}
