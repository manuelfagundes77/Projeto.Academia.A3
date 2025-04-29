using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Academia.A3.Models
{
    public class Pagamento
    {
        public int PagamentoId { get; set; }
        public int AlunoId { get; set; }
        public string Mes { get; set; } // Ex: "04/2025"
        public string Situacao { get; set; } = "Pendente";
        public DateTime? DataPagamento { get; set; }
    }
}
