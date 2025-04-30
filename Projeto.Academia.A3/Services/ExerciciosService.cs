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
                string query = "INSERT INTO exercicios (TreinoId, Nome, Serie, Repeticoes) " +
                               "VALUES (@TreinoId, @Nome, @Serie, @Repeticoes)";

                MySqlCommand cmd = new MySqlCommand(query, conexao);

                cmd.Parameters.AddWithValue("@TreinoId", exercicio.TreinoId);
                cmd.Parameters.AddWithValue("@Nome", exercicio.NomeExercicio);
                cmd.Parameters.AddWithValue("@Serie", exercicio.Serie);
                cmd.Parameters.AddWithValue("@Repeticoes", exercicio.Repeticoes);

                int resultado = cmd.ExecuteNonQuery();
                return resultado > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao adicionar exercício: {ex.Message}");
                return false;
            }
            finally
            {
                Conexao.FecharConexao(conexao);
            }
        }

        public bool AdicionarListaExercicios(List<Exercicio> listaExercicios, int treinoId)
        {
            bool sucesso = true;

            foreach (var exercicio in listaExercicios)
            {
                exercicio.TreinoId = treinoId;
                if (!AdicionarExercicio(exercicio))
                {
                    sucesso = false;
                }
            }

            return sucesso;
        }
    }
}
