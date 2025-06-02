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
    public class MembroController
    {
        private MembroService _membroService;

        public MembroController()
        {
            _membroService = new MembroService(); // Instancia a classe de serviços
        }

        // Método para adicionar um membro
        public void AdicionarMembro(Membro membro)
        {
            bool sucesso = _membroService.AdicionarMembro(membro);

            if (sucesso)
            {
                MessageBox.Show("Membro adicionado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Erro ao adicionar membro.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        // Método para listar todos os membros
        public List<Membro> ListarMembros()
        {
            List<Membro> membros = _membroService.ListarMembros();

            if (membros != null && membros.Count > 0)
            {
                return membros;
            }
            else
            {
                MessageBox.Show("Nenhum membro encontrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return new List<Membro>(); // Retorna uma lista vazia se nao houver membros
            }
        }

        //Metodo para buscar por CPF
        public Membro BuscarMembroPorCPF(string cpf)
        {
            Membro membro = _membroService.BuscarMembroPorCPF(cpf);

            if (membro != null)
            {
                return membro;
            }
            else
            {
                MessageBox.Show("Membro não encontrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null; // Retorna null se não encontrar o membro
            }
        }

        public void EditarMembro(Membro membro)
        {
            

            bool sucesso = _membroService.EditarMembro(membro);

            if (sucesso)
            {
                MessageBox.Show("Membro editado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Erro ao editar membro.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ExcluirMembro(int alunoId)
        {
            // Chama o serviço para excluir o membro passando apenas o ID
            bool sucesso = _membroService.ExcluirMembro(alunoId);

            if (sucesso)
            {
                //MessageBox.Show("Membro excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Erro ao excluir membro.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
