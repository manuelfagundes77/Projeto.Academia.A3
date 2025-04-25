using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.Academia.A3.Models;

namespace Projeto.Academia.A3.Controller
{
    public class MembroController
    {
        private List<Membro> membros;
        private int proximoId;

        public MembroController()
        {
            membros = new List<Membro>();
            proximoId = 1;  // Começa o contador do ID a partir de 1
        }

        // Método para adicionar um membro
        public void AdicionarMembro(Membro novoMembro)
        {
            novoMembro.AlunoId = proximoId;  // Atribui um AlunoId único
            membros.Add(novoMembro);
            proximoId++;  // Incrementa o ID para o próximo membro

            // Imprime no console que o membro foi adicionado
            Console.WriteLine($"Membro adicionado: ID = {novoMembro.AlunoId}, Nome = {novoMembro.Nome}, CPF = {novoMembro.CPF}, Data = {novoMembro.DataCadastro}");
        }

        // Método para obter todos os membros
        public List<Membro> ObterTodosMembros()
        {
            return membros;
        }

        // Método para obter um membro pelo AlunoId
        public Membro ObterMembroPorId(int id)
        {
            return membros.Find(m => m.AlunoId == id);
        }
    }
}
