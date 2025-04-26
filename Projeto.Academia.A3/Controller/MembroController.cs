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
    }
}
