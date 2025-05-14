using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.Academia.A3.Models;

namespace Projeto.Academia.A3.inteface
{
    public class MembroServiceFake : IMembroService
    {
        public List<Membro> ListarMembros()
        {
            return new List<Membro>
        {
            new Membro
            {
                AlunoId = 1,
                Nome = "Manuel",
                CPF = "12345678900",
                Telefone = "11999999999",
                Endereco = "Rua dos Fakes",
                DataCadastro = DateTime.Now
            }
        };
        }
    }

}
