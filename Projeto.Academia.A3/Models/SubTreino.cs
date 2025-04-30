using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Academia.A3.Models
{
    public class SubTreino
    {
        public int SubTreinoId { get; set; } // Chave primária
        public int TreinoId { get; set; }    // Chave estrangeira, ligação com Treino
        public string Nome { get; set; }     // Exemplo: "A - Peito", "B - Pernas"
    }
}
