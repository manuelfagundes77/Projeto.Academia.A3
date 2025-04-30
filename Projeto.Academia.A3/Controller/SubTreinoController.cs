using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.Academia.A3.Models;
using Projeto.Academia.A3.Services;
using System.Windows.Forms;

namespace Projeto.Academia.A3.Controller
{
    public class SubTreinoController
    {
        private SubTreinoService _service;

        public SubTreinoController()
        {
            _service = new SubTreinoService();
        }

        public int AdicionarSubTreino(SubTreino subTreino)
        {
            return _service.AdicionarSubTreino(subTreino); // Retorna o ID do subtreino
        }

        public bool AdicionarListaSubTreinos(List<SubTreino> listaSubTreinos, int treinoId)
        {
            return _service.AdicionarListaSubTreinos(listaSubTreinos, treinoId); // Retorna se todos os subtreinos foram adicionados com sucesso
        }
    }

}
