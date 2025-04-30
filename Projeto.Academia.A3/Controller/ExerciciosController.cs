using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.Academia.A3.Models;
using Projeto.Academia.A3.Services;

namespace Projeto.Academia.A3.Controller
{
    public class ExerciciosController
    {
        private ExerciciosService _service;

        public ExerciciosController()
        {
            _service = new ExerciciosService();
        }

        public bool AdicionarExercicio(Exercicio exercicio)
        {
            return _service.AdicionarExercicio(exercicio);
        }

        public bool AdicionarListaExercicios(List<Exercicio> listaExercicios, int treinoId)
        {
            return _service.AdicionarListaExercicios(listaExercicios, treinoId);
        }
    }
}
