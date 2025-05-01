using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Academia.A3.Models
{       
    //TREINO CRIADO PARA USAR JOIN DO SQL NELE  FAZER MENOS requiciçoes e metodos
    public class TreinoComAlunoDTO
    {
        public int TreinoId { get; set; }
        public string Tipo { get; set; }
        public string Descricao { get; set; }
        public string Duracao { get; set; }
        public DateTime DataInicio { get; set; }
        public string NomeAluno { get; set; }
    }
}
