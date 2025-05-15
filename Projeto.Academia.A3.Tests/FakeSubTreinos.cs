using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.Academia.A3.Models;

namespace Projeto.Academia.A3.Tests
{
    // Interface que simula a leitura de dados de SubTreino (exemplo simplificado)
    public interface IDataReaderSimuladoSubTreino
    {
        bool Read();                 // Avança para o próximo registro
        int GetInt32(string name);   // Retorna valor int pela coluna
        string GetString(string name);// Retorna valor string pela coluna
    }

    // Fake que simula um leitor de dados de subtreinos usando lista de dicionários
    public class FakeSubTreinoDataReader : IDataReaderSimuladoSubTreino
    {
        private readonly List<Dictionary<string, object>> _dados;
        private int _index = -1;

        public FakeSubTreinoDataReader(List<Dictionary<string, object>> dados)
        {
            _dados = dados;
        }

        public bool Read()
        {
            _index++;
            return _index < _dados.Count;
        }

        public int GetInt32(string name)
        {
            return (int)_dados[_index][name];
        }

        public string GetString(string name)
        {
            return (string)_dados[_index][name];
        }
    }

    // Fake do serviço SubTreino para testes (em memória)
    public class FakeSubTreinoService
    {
        private readonly List<SubTreino> _subTreinos;
        private int _nextSubTreinoId = 1;

        public FakeSubTreinoService()
        {
            _subTreinos = new List<SubTreino>
            {
                new SubTreino { SubTreinoId = _nextSubTreinoId++, TreinoId = 1, Nome = "SubTreino 1" },
                new SubTreino { SubTreinoId = _nextSubTreinoId++, TreinoId = 1, Nome = "SubTreino 2" }
            };
        }

        // Simula inserção de SubTreino retornando id
        public int AdicionarSubTreino(SubTreino subTreino)
        {
            if (subTreino == null || string.IsNullOrWhiteSpace(subTreino.Nome))
                return -1;

            subTreino.SubTreinoId = _nextSubTreinoId++;
            _subTreinos.Add(subTreino);
            return subTreino.SubTreinoId;
        }

        // Simula inserção em lote
        public bool AdicionarListaSubTreinos(List<SubTreino> listaSubTreinos, int treinoId)
        {
            bool sucesso = true;
            foreach (var subTreino in listaSubTreinos)
            {
                subTreino.TreinoId = treinoId;
                int id = AdicionarSubTreino(subTreino);
                if (id <= 0)
                {
                    sucesso = false;
                    Console.WriteLine($"Falha ao adicionar subtreino: {subTreino.Nome}");
                }
            }
            return sucesso;
        }

        // Simula consulta por treinoId
        public List<SubTreino> ObterSubTreinosComExercicios(int treinoId)
        {
            // Apenas retorna subtreinos do treinoId pedido
            return _subTreinos.FindAll(st => st.TreinoId == treinoId);
        }
    }
}
