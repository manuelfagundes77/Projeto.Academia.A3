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
    public class ExerciciosService
    {
        public bool AdicionarExercicio(Exercicio exercicio)
        {
            MySqlConnection conexao = Conexao.ObterConexao();
            if (conexao == null)
            {
                return false;
            }

            try
            {
                string query = @"INSERT INTO exercicios 
                         (SubTreinoId, Nome, Serie, Repeticoes)
                         VALUES (@SubTreinoId, @Nome, @Serie, @Repeticoes)";

                MySqlCommand cmd = new MySqlCommand(query, conexao);

                cmd.Parameters.AddWithValue("@SubTreinoId", exercicio.SubTreinoId); // Agora usando SubTreinoId
                cmd.Parameters.AddWithValue("@Nome", exercicio.NomeExercicio);
                cmd.Parameters.AddWithValue("@Serie", exercicio.Serie);
                cmd.Parameters.AddWithValue("@Repeticoes", exercicio.Repeticoes);

                int resultado = cmd.ExecuteNonQuery();
                return resultado > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao adicionar exercício: ao service {ex.Message}");
                return false;
            }
            finally
            {
                Conexao.FecharConexao(conexao);
            }
        }

        public bool AdicionarListaExercicios(List<Exercicio> listaExercicios, int SubTreinoId)
        {
            bool sucesso = true;

            foreach (var exercicio in listaExercicios)
            {
                exercicio.SubTreinoId = SubTreinoId;
                if (!AdicionarExercicio(exercicio))
                {
                    sucesso = false;
                }
            }

            return sucesso;
        }

        //RETORNA
        public List<Exercicio> ObterExerciciosPorSubTreinoId(int subTreinoId)
        {
            List<Exercicio> exercicios = new List<Exercicio>();

            // Consultar os exercícios pelo ID do subtreino
            string query = "SELECT * FROM Exercicios WHERE SubTreinoId = @SubTreinoId";
            using (MySqlConnection conexao = Conexao.ObterConexao())
            {
                MySqlCommand cmd = new MySqlCommand(query, conexao);
                cmd.Parameters.AddWithValue("@SubTreinoId", subTreinoId);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Exercicio exercicio = new Exercicio
                        {
                            ExercicioId = reader.GetInt32("ExercicioId"),
                            NomeExercicio = reader.GetString("Nome"),
                            Serie = reader.GetString("Serie"),
                            Repeticoes = reader.GetString("Repeticoes"),
                            SubTreinoId = reader.GetInt32("SubTreinoId")
                        };

                        exercicios.Add(exercicio);
                    }
                }
            }

            return exercicios;
        }
    }
}
