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
        public int SubTreinoId { get; set; }
        public string NomeExercicio { get; set; }
        public string Serie { get; set; }
        public string Repeticoes { get; set; }


        public override string ToString()
        {
            return $" {NomeExercicio} - Series: {Serie} - Repetições: {Repeticoes} ";
        }
    }
}
