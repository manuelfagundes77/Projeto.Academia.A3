using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Academia.A3.Models
{
    public class Funcionario
    {
        public int FuncionarioId { get; set; }  // ID do funcionário
        public string Nome { get; set; }         // Nome do funcionário
        public string Cargo { get; set; }        // Cargo do funcionário
        public string Login { get; set; }        // Login do funcionário
        public string Senha { get; set; }        // Senha do funcionário
    }
}
