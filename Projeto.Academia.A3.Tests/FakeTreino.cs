using System;
using System.Collections.Generic;
using System.Linq;
using Projeto.Academia.A3.Models;

namespace Projeto.Academia.A3.Tests
{
    // Interface simulando leitor de dados para Treino
    public interface IDataReaderSimuladoTreino
    {
        bool Read();
        int GetInt32(string name);
        string GetString(string name);
        DateTime GetDateTime(string name);
    }

    // Fake que simula leitura de dados para Treino, usando lista interna
    public class FakeTreinoDataReader : IDataReaderSimuladoTreino
    {
        private readonly List<Dictionary<string, object>> _dados;
        private int _index = -1;

        public FakeTreinoDataReader(List<Dictionary<string, object>> dados)
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

        public DateTime GetDateTime(string name)
        {
            return (DateTime)_dados[_index][name];
        }
    }

    // Fake service para Treino, contendo uma lista simulada e métodos para buscar
    public class FakeTreinoService
    {
        private readonly List<Treino> _treinos;

        // Simula base de dados interna de alunos para mapear nome pelo AlunoId
        private readonly Dictionary<int, string> _alunos;

        public FakeTreinoService()
        {
            _treinos = new List<Treino>
            {
                new Treino
                {
                    TreinoId = 1,
                    AlunoId = 10,
                    FuncionarioId = 100,
                    Tipo = "Força",
                    Descricao = "Treino para ganhar massa muscular",
                    Duracao = "60",
                    DataInicio = DateTime.Today.AddDays(-7)
                },
                new Treino
                {
                    TreinoId = 2,
                    AlunoId = 11,
                    FuncionarioId = 101,
                    Tipo = "Cardio",
                    Descricao = "Treino para melhorar resistência",
                    Duracao = "45",
                    DataInicio = DateTime.Today.AddDays(-3)
                }
                // Você pode adicionar mais treinos fake aqui
            };

            _alunos = new Dictionary<int, string>
            {
                {10, "João Silva"},
                {11, "Maria Souza"}
                // Mais alunos podem ser adicionados aqui
            };
        }

        // Método que simula busca por treinos do funcionário e retorna DTO com nome do aluno
        public List<TreinoComAlunoDTO> ObterTreinosPorFuncionario(int funcionarioId)
        {
            var filtrados = _treinos.Where(t => t.FuncionarioId == funcionarioId);

            return filtrados.Select(t => new TreinoComAlunoDTO
            {
                TreinoId = t.TreinoId,
                Tipo = t.Tipo,
                Descricao = t.Descricao,
                Duracao = t.Duracao,
                DataInicio = t.DataInicio,
                NomeAluno = _alunos.ContainsKey(t.AlunoId) ? _alunos[t.AlunoId] : "Aluno desconhecido"
            }).ToList();
        }

        // Outros métodos fake podem ser criados, por exemplo:
        public Treino ObterTreinoPorId(int treinoId)
        {
            return _treinos.FirstOrDefault(t => t.TreinoId == treinoId);
        }

        public void AdicionarTreino(Treino treino)
        {
            // Pode adicionar alguma lógica fake para adicionar treino
            _treinos.Add(treino);
        }

        public bool RemoverTreino(int treinoId)
        {
            var treino = _treinos.FirstOrDefault(t => t.TreinoId == treinoId);
            if (treino != null)
            {
                _treinos.Remove(treino);
                return true;
            }
            return false;
        }
    }
}
