using System;
using System.Collections.Generic;
using System.Linq;
using Projeto.Academia.A3.Models;

namespace Projeto.Academia.A3.Tests
{
    // Interface que simula a leitura de dados para Pagamentos, métodos básicos para avançar e obter valores por nome da coluna
    public interface IDataReaderSimuladoPagamento
    {
        bool Read();                // Avança para o próximo registro, retorna false se não houver mais
        int GetInt32(string name);  // Retorna valor inteiro da coluna especificada
        string GetString(string name); // Retorna valor string da coluna especificada
        DateTime? GetDateTimeNullable(string name); // Retorna valor DateTime? da coluna especificada (pode ser null)
    }

    // Implementação fake da interface que usa uma lista de dicionários para simular os dados retornados
    public class FakePagamentoDataReader : IDataReaderSimuladoPagamento
    {
        private readonly List<Dictionary<string, object>> _dados;
        private int _index = -1; // índice para controlar a posição atual da leitura

        public FakePagamentoDataReader(List<Dictionary<string, object>> dados)
        {
            _dados = dados; // recebe os dados simulados para leitura
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

        public DateTime? GetDateTimeNullable(string name)
        {
            if (_dados[_index][name] == null)
                return null;
            return (DateTime)_dados[_index][name];
        }
    }

    // Classe fake que simula o comportamento do service de pagamento para testes
    public class FakePagamentoService
    {
        private readonly List<Pagamento> _pagamentos;
        private int _proximoId = 1;

        public FakePagamentoService()
        {
            _pagamentos = new List<Pagamento>();
        }

        // Gera 12 pagamentos pendentes para o aluno informado, um para cada mês
        public bool GerarPagamentosPendentes(int alunoId)
        {
            DateTime dataAtual = DateTime.Now;

            for (int i = 0; i < 12; i++)
            {
                string mesAno = dataAtual.AddMonths(i).ToString("MM/yyyy");

                _pagamentos.Add(new Pagamento
                {
                    PagamentoId = _proximoId++,
                    AlunoId = alunoId,
                    Mes = mesAno,
                    Situacao = "Pendente",
                    DataPagamento = null
                });
            }
            return true;
        }

        // Altera situação do pagamento para Pago se estiver pendente
        public bool AlterarSituacaoPagamentoPorId(int pagamentoId)
        {
            var pagamento = _pagamentos.FirstOrDefault(p => p.PagamentoId == pagamentoId && p.Situacao == "Pendente");

            if (pagamento != null)
            {
                pagamento.Situacao = "Pago";
                pagamento.DataPagamento = DateTime.Now;
                return true;
            }

            return false;
        }

        // Retorna a lista de pagamentos de um aluno, ordenados pela data do mês
        public List<Pagamento> ListarPagamentosPorAluno(int alunoId)
        {
            return _pagamentos
                .Where(p => p.AlunoId == alunoId)
                .OrderBy(p => DateTime.ParseExact("01/" + p.Mes, "dd/MM/yyyy", null))
                .ToList();
        }
    }
}
