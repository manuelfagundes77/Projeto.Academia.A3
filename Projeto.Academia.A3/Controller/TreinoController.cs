using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projeto.Academia.A3.Models;
using Projeto.Academia.A3.Services;

namespace Projeto.Academia.A3.Controller
{
    public class TreinoController
    {
        private TreinoService treinoService;

        public TreinoController()
        {
            treinoService = new TreinoService();
        }

        public int AdicionarTreino(Treino treino)
        {
            try
            {
                // Chama o serviço para adicionar o treino e retorna o ID gerado
                int treinoId = treinoService.AdicionarTreino(treino);
              
               

                // mostra a mensagem de sucesso
                MessageBox.Show("Treino adicionado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return treinoId; // Retorna o ID do treino
            }
            catch (Exception ex)
            {
                // mostra a mensagem de erro
                MessageBox.Show($"Erro ao adicionar o treino: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1; // Retorna -1 em caso de erro
            }
        }

        public List<Treino> ObterTreinos(int alunoId)
        {
            // Aqui você chama o serviço para obter os treinos
            return treinoService.ObterTreinos(alunoId);
        }

        //metodo para obter todos os treino do funcionario
        public List<TreinoComAlunoDTO> ObterTreinosPorFuncionario(int funcionarioId)
        {
            return treinoService.ObterTreinosPorFuncionario(funcionarioId);
        }



        public bool ExcluirTreinoPorId(int treinoId)
        {
            try
            {
                bool sucesso = treinoService.ExcluirTreinoPorId(treinoId);

                if (sucesso)
                {
                    MessageBox.Show("Treino excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Não foi possível excluir o treino. Verifique se o ID está correto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                return sucesso;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao excluir o treino: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

    }
}
