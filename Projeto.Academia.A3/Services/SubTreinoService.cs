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
    public class SubTreinoService
    {
        public int AdicionarSubTreino(SubTreino subTreino)
        {
            MySqlConnection conexao = Conexao.ObterConexao();
            if (conexao == null)
            {
                return -1;
            }

            try
            {
                string query = "INSERT INTO treinosub (TreinoId, Nome) " +
                               "VALUES (@TreinoId, @Nome); SELECT LAST_INSERT_ID();";

                MySqlCommand cmd = new MySqlCommand(query, conexao);

                cmd.Parameters.AddWithValue("@TreinoId", subTreino.TreinoId);
                cmd.Parameters.AddWithValue("@Nome", subTreino.Nome);

                // Executa o comando e pega o ID gerado
                int subTreinoId = Convert.ToInt32(cmd.ExecuteScalar());

                return subTreinoId; // Retorna o ID do subtreino criado
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao adicionar subtreino: {ex.Message}");
                return -1;
            }
            finally
            {
                Conexao.FecharConexao(conexao);
            }
        }

        public bool AdicionarListaSubTreinos(List<SubTreino> listaSubTreinos, int treinoId)
        {
            bool sucesso = true;

            // Percorre cada subtreino na lista e adiciona ao banco
            foreach (var subTreino in listaSubTreinos)
            {
                subTreino.TreinoId = treinoId; // Define o TreinoId para cada SubTreino
                int subTreinoId = AdicionarSubTreino(subTreino); // Chama o método para adicionar o subtreino

                if (subTreinoId <= 0) // Se falhar em adicionar, marca como falha
                {
                    sucesso = false;
                    Console.WriteLine($"Falha ao adicionar subtreino: {subTreino.Nome}"); // Loga o nome do subtreino que falhou
                }
            }

            return sucesso; // Retorna se todos os subtreinos foram adicionados com sucesso
        }

        public List<SubTreino> ObterSubTreinosComExercicios(int treinoId)
        {
            List<SubTreino> subTreinos = new List<SubTreino>();

            string query = "SELECT * FROM SubTreinos WHERE TreinoId = @TreinoId";
            using (MySqlConnection conexao = Conexao.ObterConexao())
            {
                MySqlCommand cmd = new MySqlCommand(query, conexao);
                cmd.Parameters.AddWithValue("@TreinoId", treinoId);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        SubTreino subTreino = new SubTreino
                        {
                            SubTreinoId = reader.GetInt32("SubTreinoId"), // Nome correto da coluna
                            Nome = reader.GetString("Nome"),
                            TreinoId = reader.GetInt32("TreinoId")
                        };

                        // Buscar os exercícios para esse subtreino
                        subTreino.Exercicios = ObterExerciciosPorSubTreinoId(subTreino.SubTreinoId);

                        subTreinos.Add(subTreino);
                    }
                }
            }

            return subTreinos;
        }



        // Chama o método que está no serviço de Exercício
        public List<Exercicio> ObterExerciciosPorSubTreinoId(int subTreinoId)
        {
            ExerciciosService exercicioService = new ExerciciosService();
            return exercicioService.ObterExerciciosPorSubTreinoId(subTreinoId);
        }

    }
}
