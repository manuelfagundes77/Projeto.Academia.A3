using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Projeto.Academia.A3.Models;

namespace Projeto.Academia.A3.inteface
{
    public interface IDataReaderSimulado
    {
        bool Read();
        int GetInt32(string name);
        string GetString(string name);
        DateTime GetDateTime(string name);
    }

    public class FakeMySqlDataReader : IDataReaderSimulado
    {
        private readonly List<Dictionary<string, object>> _data;
        private int _currentIndex = -1;

        public FakeMySqlDataReader(List<Dictionary<string, object>> data)
        {
            _data = data;
        }

        public bool Read()
        {
            _currentIndex++;
            return _currentIndex < _data.Count;
        }

        public int GetInt32(string name)
        {
            return (int)_data[_currentIndex][name];
        }

        public string GetString(string name)
        {
            return (string)_data[_currentIndex][name];
        }

        public DateTime GetDateTime(string name)
        {
            return (DateTime)_data[_currentIndex][name];
        }

        public Membro BuscarMembroPorCPFComFake(string cpf, IDataReaderSimulado reader)
        {
            Membro membro = null;

            if (reader == null)
            {
                return null; // Simulando falha ao tentar ler do banco
            }

            try
            {
                if (reader.Read())
                {
                    membro = new Membro
                    {
                        AlunoId = reader.GetInt32("AlunoId"),
                        Nome = reader.GetString("Nome"),
                        CPF = reader.GetString("CPF"),
                        Telefone = reader.GetString("Telefone"),
                        Endereco = reader.GetString("Endereco"),
                        DataCadastro = reader.GetDateTime("DataCadastro")
                    };
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao buscar membro: " + ex.Message);
            }

            return membro;
        }


    }






}
