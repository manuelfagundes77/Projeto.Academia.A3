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
    public class TreinoService
    {
        // Método para adicionar um novo treino
        public int AdicionarTreino(Treino treino)
        {
            MySqlConnection conexao = Conexao.ObterConexao();
            if (conexao == null)
            {
                return -1;
            }

            try
            {
                string query = "INSERT INTO treinos (AlunoId, Tipo, Descricao, Duracao, DataInicio, FuncionarioId) " +
                       "VALUES (@AlunoId, @Tipo, @Descricao, @Duracao, @DataInicio, @FuncionarioId); SELECT LAST_INSERT_ID();";


                MySqlCommand cmd = new MySqlCommand(query, conexao);

                cmd.Parameters.AddWithValue("@AlunoId", treino.AlunoId);
                cmd.Parameters.AddWithValue("@Tipo", treino.Tipo);
                cmd.Parameters.AddWithValue("@Descricao", treino.Descricao);
                cmd.Parameters.AddWithValue("@Duracao", treino.Duracao);
                cmd.Parameters.AddWithValue("@DataInicio", treino.DataInicio);

                // FuncionarioId  considerando se ele for nulo ou nao
                if (treino.FuncionarioId.HasValue)
                {
                    cmd.Parameters.AddWithValue("@FuncionarioId", treino.FuncionarioId.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@FuncionarioId", DBNull.Value);
                }

                // IMPORTANTE: executa o comando e pega o ID gerado
                int treinoId = Convert.ToInt32(cmd.ExecuteScalar());

                return treinoId;// RETORNA o ID criado do treino para adicionar aos exercicios 
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao adicionar treino: {ex.Message}");
                return -1;
            }
            finally
            {
                Conexao.FecharConexao(conexao);
            }
        }

        // Metodo para obter todos os treinos de um aluno 
        public List<Treino> ObterTreinos(int alunoId)
        {
            MySqlConnection conexao = Conexao.ObterConexao();
            if (conexao == null)
            {
                return null; 
            }

            List<Treino> treinos = new List<Treino>(); //cria uma lista do tipo treino para salva os treinos
            try
            {
                string query = "SELECT * FROM treinos WHERE AlunoId = @AlunoId ORDER BY TreinoId DESC";
                MySqlCommand cmd = new MySqlCommand(query, conexao);
                cmd.Parameters.AddWithValue("@AlunoId", alunoId);

                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Treino treino = new Treino
                    {
                        TreinoId = reader.GetInt32("TreinoId"),
                        AlunoId = reader.GetInt32("AlunoId"),
                        Tipo = reader.GetString("Tipo"),
                        Descricao = reader.GetString("Descricao"),
                        Duracao = reader.GetString("Duracao"),
                        DataInicio = reader.GetDateTime("DataInicio"),
                        FuncionarioId = reader.IsDBNull(reader.GetOrdinal("FuncionarioId"))
                                ? (int?)null
                                : reader.GetInt32("FuncionarioId")
                    };

                    treinos.Add(treino);
                }

                return treinos;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao obter treinos: {ex.Message}");
                return null;
            }
            finally
            {
                Conexao.FecharConexao(conexao);
            }
        }

        //public List<Treino> ObterTreinosPorFuncionario(int funcionarioId)
        //{
        //    MySqlConnection conexao = Conexao.ObterConexao();
        //    if (conexao == null)
        //    {
        //        return null;
        //    }

        //    List<Treino> treinos = new List<Treino>();
        //    try
        //    {
        //        string query = "SELECT * FROM treinos WHERE FuncionarioId = @FuncionarioId ORDER BY TreinoId DESC";
        //        MySqlCommand cmd = new MySqlCommand(query, conexao);
        //        cmd.Parameters.AddWithValue("@FuncionarioId", funcionarioId);

        //        MySqlDataReader reader = cmd.ExecuteReader();
        //        while (reader.Read())
        //        {
        //            Treino treino = new Treino
        //            {
        //                TreinoId = reader.GetInt32("TreinoId"),
        //                AlunoId = reader.GetInt32("AlunoId"),
        //                Tipo = reader.GetString("Tipo"),
        //                Descricao = reader.GetString("Descricao"),
        //                Duracao = reader.GetString("Duracao"),
        //                DataInicio = reader.GetDateTime("DataInicio"),
        //                FuncionarioId = reader.IsDBNull(reader.GetOrdinal("FuncionarioId"))
        //                        ? (int?)null
        //                        : reader.GetInt32("FuncionarioId")
        //            };

        //            treinos.Add(treino);
        //        }

        //        return treinos;
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine($"Erro ao obter treinos do funcionário: {ex.Message}");
        //        return null;
        //    }
        //    finally
        //    {
        //        Conexao.FecharConexao(conexao);
        //    }
        //}


        public List<TreinoComAlunoDTO> ObterTreinosPorFuncionario(int funcionarioId)
        {
            MySqlConnection conexao = Conexao.ObterConexao();
            if (conexao == null)
            {
                return null;
            }

            List<TreinoComAlunoDTO> treinos = new List<TreinoComAlunoDTO>();
            try
            {
                string query = @"
                                SELECT 
                                    t.TreinoId,
                                    t.AlunoId,
                                    m.Nome AS NomeAluno,
                                    t.Tipo,
                                    t.Descricao,
                                    t.Duracao,
                                    t.DataInicio,
                                    t.FuncionarioId
                                FROM treinos t
                                JOIN membros m ON t.AlunoId = m.AlunoId
                                WHERE t.FuncionarioId = @FuncionarioId
                                ORDER BY t.TreinoId DESC";


                MySqlCommand cmd = new MySqlCommand(query, conexao);
                cmd.Parameters.AddWithValue("@FuncionarioId", funcionarioId);

                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    TreinoComAlunoDTO treino = new TreinoComAlunoDTO
                    {
                        TreinoId = reader.GetInt32("TreinoId"),
                        Tipo = reader.GetString("Tipo"),
                        Descricao = reader.GetString("Descricao"),
                        Duracao = reader.GetString("Duracao"),
                        DataInicio = reader.GetDateTime("DataInicio").Date, // .date e para retorna so  dia
                        NomeAluno = reader.GetString("NomeAluno")
                    };

                    treinos.Add(treino);
                }

                return treinos;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao obter treinos do funcionário: {ex.Message}");
                return null;
            }
            finally
            {
                Conexao.FecharConexao(conexao);
            }
        }









    }
}
