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

        public void AdicionarTreino(Treino treino)
        {
            try
            {
                // Chama o serviço para adicionar o treino
                treinoService.AdicionarTreino(treino);

                // mostra a mensagem de sucesso
                MessageBox.Show("Treino adicionado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // mostra a mensagem de erro
                MessageBox.Show($"Erro ao adicionar o treino: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public List<Treino> ObterTreinos(int alunoId)
        {
            // Aqui você chama o serviço para obter os treinos
            return treinoService.ObterTreinos(alunoId);
        }
    }
}
