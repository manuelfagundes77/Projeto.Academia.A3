using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Projeto.Academia.A3.Data;
using System.Windows.Forms;
using Projeto.Academia.A3.Models;

namespace Projeto.Academia.A3.Services
{
    public class PagamentoService
    {
        // Gera 12 pagamentos com status "Pendente" para o membro Cadastrado
        public bool GerarPagamentosPendentes(int membroId)
        {
            MySqlConnection conexao = Conexao.ObterConexao();

            if (conexao == null)
                return false;

            try
            {
                DateTime dataAtual = DateTime.Now;

                for (int i = 0; i < 12; i++)
                {
                    string mesAno = dataAtual.AddMonths(i).ToString("MM/yyyy");

                    string query = "INSERT INTO Pagamentos (AlunoId, Mes, Situacao) " +
                                   "VALUES (@AlunoId, @Mes, 'Pendente')";

                    MySqlCommand comando = new MySqlCommand(query, conexao);
                    comando.Parameters.AddWithValue("@AlunoId", membroId);
                    comando.Parameters.AddWithValue("@Mes", mesAno);
                    comando.ExecuteNonQuery();
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao gerar pagamentos: " + ex.Message);
                return false;
            }
            finally
            {
                Conexao.FecharConexao(conexao);
            }
        }

        public bool AlterarSituacaoPagamentoPorId(int pagamentoId)
        {
            // Criar a conexão com o banco de dados
            MySqlConnection conexao = Conexao.ObterConexao();

            if (conexao == null)
            {
                return false; // Se a conexão falhar, retorna false
            }

            try
            {
                // Comando SQL para atualizar a situação de um pagamento para 'Pago'
                string query = "UPDATE Pagamentos " +
                               "SET Situacao = 'Pago', DataPagamento = @DataPagamento " +
                               "WHERE PagamentoId = @PagamentoId AND Situacao = 'Pendente'";

                MySqlCommand comando = new MySqlCommand(query, conexao);
                comando.Parameters.AddWithValue("@PagamentoId", pagamentoId);
                comando.Parameters.AddWithValue("@DataPagamento", DateTime.Now); // Define a data de pagamento como a data atual

                int resultado = comando.ExecuteNonQuery();

                if (resultado > 0)
                {
                    return true; // Se o comando foi bem-sucedido, retorna true
                }
                else
                {
                    return false; // Se não houve alteração, retorna false
                }
            }
            catch (Exception ex)
            {
                // Em caso de erro, exibe a mensagem de erro
                MessageBox.Show("Erro ao alterar a situação do pagamento: " + ex.Message);
                return false;
            }
            finally
            {
                // Fecha a conexão após a operação
                Conexao.FecharConexao(conexao);
            }
        }

        public List<Pagamento> ListarPagamentosPorAluno(int alunoId)
        {
            MySqlConnection conexao = Conexao.ObterConexao();

            if (conexao == null)
            {
                return null; // Se a conexão falhar, retorna null
            }

            try
            {
                // Lista para armazenar os pagamentos
                List<Pagamento> pagamentos = new List<Pagamento>();

                // Comando SQL para buscar os pagamentos de um aluno específico 
                string query = "SELECT PagamentoId, AlunoId, Mes, Situacao, DataPagamento " +
                               "FROM Pagamentos " +
                               "WHERE AlunoId = @AlunoId" + 
                                " ORDER BY STR_TO_DATE(CONCAT('01/', Mes), '%d/%m/%Y')"  //ordenar o banco de acordo com o mes 
                                ;

                MySqlCommand comando = new MySqlCommand(query, conexao);
                comando.Parameters.AddWithValue("@AlunoId", alunoId);

                MySqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    // Cria um objeto Pagamento e preenche com os dados do banco
                    Pagamento pagamento = new Pagamento()
                    {
                        PagamentoId = reader.GetInt32("PagamentoId"),
                        AlunoId = reader.GetInt32("AlunoId"),
                        Mes = reader.GetString("Mes"),
                        Situacao = reader.GetString("Situacao"),
                        DataPagamento = reader.IsDBNull(reader.GetOrdinal("DataPagamento")) ? (DateTime?)null : reader.GetDateTime("DataPagamento") //Evitar erro ao tentar ler a coluna DataPagamento se ela estiver vazia (nula no banco de dados).
                    };

                    // Adiciona o pagamento à lista
                    pagamentos.Add(pagamento);
                }

                return pagamentos;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao listar pagamentos: " + ex.Message);
                return null;
            }
            finally
            {
                // Fecha a conexão após a operação
                Conexao.FecharConexao(conexao);
            }
        }


    }
}
