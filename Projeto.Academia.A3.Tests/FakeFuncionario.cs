using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.Academia.A3.Models;

namespace Projeto.Academia.A3.Tests
{
    // Interface que simula a leitura de dados, com metodos basicos para avancar e obter valores por nome da coluna
    public interface IDataReaderSimuladoFuncionario
    {
        bool Read(); // Avanca para o proximo registro, retorna false se nao houver mais
        int GetInt32(string name); // Retorna valor inteiro da coluna especificada
        string GetString(string name); // Retorna valor string da coluna especificada
    }

    // Implementacao fake da interface que usa uma lista de dicionarios para simular os dados retornados
    public class FakeFuncionarioDataReader : IDataReaderSimuladoFuncionario
    {
        private readonly List<Dictionary<string, object>> _dados;
        private int _index = -1; // indice para controlar a posicao atual da leitura

        public FakeFuncionarioDataReader(List<Dictionary<string, object>> dados)
        {
            _dados = dados; // recebe os dados simulados para leitura
        }

        // Avanca para o proximo registro da lista, retorna true se ainda houver registros
        public bool Read()
        {
            _index++;
            return _index < _dados.Count;
        }

        // Retorna o valor inteiro da coluna indicada no registro atual
        public int GetInt32(string name)
        {
            return (int)_dados[_index][name];
        }

        // Retorna o valor string da coluna indicada no registro atual
        public string GetString(string name)
        {
            return (string)_dados[_index][name];
        }
    }

    // Classe fake que simula o comportamento do service de funcionario para testes
    public class FakeFuncionarioService
    {
        private readonly List<Funcionario> _funcionarios;

        public FakeFuncionarioService()
        {
            // Cria uma lista inicial com alguns funcionarios para testes
            _funcionarios = new List<Funcionario>
        {
            new Funcionario { Nome = "Admin", Cargo = "Administrador", Login = "ad", Senha = "123" },
            new Funcionario { Nome = "Joao Silva", Cargo = "Gerente", Login = "joao", Senha = "senha123" }
        };
        }

        // Verifica se o login e senha informados correspondem a algum funcionario cadastrado
        public bool ValidarLogin(string login, string senha)
        {
            foreach (var f in _funcionarios)
            {
                if (f.Login == login && f.Senha == senha)
                    return true;
            }
            return false;
        }

        // Adiciona um novo funcionario na lista se o login nao estiver repetido
        public bool AdicionarFuncionario(Funcionario funcionario)
        {
            if (_funcionarios.Exists(f => f.Login == funcionario.Login))
                return false; // nao adiciona se ja existir login igual

            _funcionarios.Add(funcionario);
            return true;
        }

        // Busca e retorna o funcionario que tenha o login e senha informados, ou null se nao achar
        public Funcionario BuscarFuncionarioPorLogin(string login, string senha)
        {
            foreach (var f in _funcionarios)
            {
                if (f.Login == login && f.Senha == senha)
                    return f;
            }
            return null;
        }

        // Retorna uma copia da lista com todos os funcionarios cadastrados
        public List<Funcionario> ObterTodosFuncionarios()
        {
            return new List<Funcionario>(_funcionarios);
        }
    }

}
