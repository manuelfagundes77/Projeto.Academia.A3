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
        // Metodo para validar o login do funcionario
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
                    return reader.HasRows; // Retorna true se encontrar algum funcionario com o login e senha fornecidos
                }
                catch (Exception ex)
                {
                    throw new Exception("Erro ao validar login: " + ex.Message);
                }
            }
        }

        // Metodo para adicionar um novo funcionario
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

                    int resultado = cmd.ExecuteNonQuery(); // Retorna o numero de linhas afetadas

                    return resultado > 0; // Retorna true se pelo menos uma linha for afetada (inserção bem sucedida)
                }
                catch (Exception ex)
                {
                    throw new Exception("Erro ao adicionar funcionário: " + ex.Message);
                }
            }
        }

        public Funcionario BuscarFuncionarioPorLogin(string login, string senha)
        {
            // Aqui você busca os dados do funcionário no banco
            string query = "SELECT * FROM funcionario WHERE Login = @login AND Senha = @senha";

            using (MySqlConnection conexao = Conexao.ObterConexao())
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, conexao);
                    cmd.Parameters.AddWithValue("@login", login);
                    cmd.Parameters.AddWithValue("@senha", senha);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        reader.Read(); // Avança para o primeiro resultado
                        return new Funcionario
                        {
                            FuncionarioId = reader.GetInt32("FuncionarioId"),
                            Nome = reader.GetString("Nome"),
                            Cargo = reader.GetString("Cargo"),
                            Login = reader.GetString("Login"),
                            Senha = reader.GetString("Senha")
                        };
                    }

                    return null; // Se não encontrar o funcionário
                }
                catch (Exception ex)
                {
                    throw new Exception("Erro ao buscar funcionário: " + ex.Message);
                }
            }
        }

        //retorna lista todos os funcionarios
        public List<Funcionario> ObterTodosFuncionarios()
        {
            MySqlConnection conexao = Conexao.ObterConexao();
            if (conexao == null) return null;

            List<Funcionario> funcionarios = new List<Funcionario>();

            try
            {
                string query = "SELECT FuncionarioId, Nome FROM funcionario";
                MySqlCommand cmd = new MySqlCommand(query, conexao);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Funcionario func = new Funcionario
                    {
                        FuncionarioId = reader.GetInt32("FuncionarioId"),
                        Nome = reader.GetString("Nome")
                    };

                    funcionarios.Add(func);
                }

                return funcionarios;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao obter funcionários: {ex.Message}");
                return null;
            }
            finally
            {
                Conexao.FecharConexao(conexao);
            }
        }


    }
}
