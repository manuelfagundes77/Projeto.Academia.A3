using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Projeto.Academia.A3.Data;
using Projeto.Academia.A3.Models;

namespace Projeto.Academia.A3.Services
{
    public class FuncionarioService
    {
        // Método para validar o login do funcionário
        public bool ValidarLogin(string login, string senha)
        {
            string query = "SELECT * FROM funcionario WHERE Login = @login AND Senha = @senha";

            using (MySqlConnection conexao = Conexao.ObterConexao())
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, conexao);
                    cmd.Parameters.AddWithValue("@login", login);
                    cmd.Parameters.AddWithValue("@senha", senha);

                    MySqlDataReader reader = cmd.ExecuteReader();
                    return reader.HasRows; // Retorna true se encontrar algum funcionário com o login e senha fornecidos
                }
                catch (Exception ex)
                {
                    throw new Exception("Erro ao validar login: " + ex.Message);
                }
            }
        }

        // Método para adicionar um novo funcionário
        public bool AdicionarFuncionario(Funcionario funcionario)
        {
            string query = "INSERT INTO funcionario (Nome, Cargo, Login, Senha) VALUES (@Nome, @Cargo, @Login, @Senha)";

            using (MySqlConnection conexao = Conexao.ObterConexao())
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, conexao);
                    cmd.Parameters.AddWithValue("@Nome", funcionario.Nome);
                    cmd.Parameters.AddWithValue("@Cargo", funcionario.Cargo);
                    cmd.Parameters.AddWithValue("@Login", funcionario.Login);
                    cmd.Parameters.AddWithValue("@Senha", funcionario.Senha);

                    int resultado = cmd.ExecuteNonQuery(); // Retorna o número de linhas afetadas

                    return resultado > 0; // Retorna true se pelo menos uma linha for afetada (inserção bem-sucedida)
                }
                catch (Exception ex)
                {
                    throw new Exception("Erro ao adicionar funcionário: " + ex.Message);
                }
            }
        }
    }
}
