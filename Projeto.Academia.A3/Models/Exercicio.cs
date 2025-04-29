using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Academia.A3.Models
{
    public class Exercicio
    {
        public int ExercicioId { get; set; }
        public int TreinoId { get; set; }  // Este campo será usado ao salvar
        public string NomeExercicio { get; set; }
        public string Serie { get; set; }
        public string Repeticoes { get; set; }
    }
}
