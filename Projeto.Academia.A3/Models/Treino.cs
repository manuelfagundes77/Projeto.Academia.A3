using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Academia.A3.Models
{
    public class Treino
    {
        public int TreinoId { get; set; }
        public int AlunoId { get; set; } // FK (chave estrangeira)
        public string Tipo { get; set; }
        public string Descricao { get; set; }
        public int Duracao { get; set; } // em minutos, por exemplo
        public DateTime DataInicio { get; set; }
    }
}
