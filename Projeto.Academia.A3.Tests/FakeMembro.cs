using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.Academia.A3.inteface;
using Projeto.Academia.A3.Models;

namespace Projeto.Academia.A3.Tests
{
    public interface IConexaoFake
    {
        IFakeMySqlConnection ObterConexao();
        void FecharConexao(IFakeMySqlConnection conexao);
    }

    public interface IFakeMySqlConnection
    {
        bool Aberta { get; }
        void Abrir();
    }

    public interface IFakeMySqlCommand
    {
        void AddParameter(string nome, object valor);
        int ExecuteNonQuery();
        object ExecuteScalar();
    }

    public class FakeMySqlConnection : IFakeMySqlConnection
    {
        public bool Aberta { get; private set; } = false;

        public void Abrir()
        {
            Aberta = true;
        }
    }

    public class FakeMySqlCommand : IFakeMySqlCommand
    {
        private readonly Dictionary<string, object> _parameters = new();
        private readonly bool _insercaoBemSucedida;

        public FakeMySqlCommand(bool insercaoBemSucedida)
        {
            _insercaoBemSucedida = insercaoBemSucedida;
        }

        public void AddParameter(string nome, object valor)
        {
            _parameters[nome] = valor;
        }

        public int ExecuteNonQuery()
        {
            return _insercaoBemSucedida ? 1 : 0;
        }

        public object ExecuteScalar()
        {
            return 42; // ID simulado
        }
    }

    public class ConexaoFake : IConexaoFake
    {
        public IFakeMySqlConnection ObterConexao()
        {
            return new FakeMySqlConnection();
        }

        public void FecharConexao(IFakeMySqlConnection conexao)
        {
            // Nada para fechar no fake
        }
    }

    public class MembroServiceFakeComAdicao
    {
        private readonly IConexaoFake _conexaoFake;
        private readonly IFakeMySqlCommand _comandoFake;
        private readonly IFakeMySqlCommand _idComandoFake;

        public MembroServiceFakeComAdicao(IConexaoFake conexao, IFakeMySqlCommand comando, IFakeMySqlCommand idComando)
        {
            _conexaoFake = conexao;
            _comandoFake = comando;
            _idComandoFake = idComando;
        }

        public bool AdicionarMembro(Membro membro)
        {
            var conexao = _conexaoFake.ObterConexao();
            if (conexao == null)
                return false;

            try
            {
                _comandoFake.AddParameter("@Nome", membro.Nome);
                _comandoFake.AddParameter("@CPF", membro.CPF);
                _comandoFake.AddParameter("@Telefone", membro.Telefone);
                _comandoFake.AddParameter("@Endereco", membro.Endereco);

                int resultado = _comandoFake.ExecuteNonQuery();

                if (resultado > 0)
                {
                    int alunoId = Convert.ToInt32(_idComandoFake.ExecuteScalar());
                    // pagamentoService.GerarPagamentosPendentes(alunoId); // ignorado no teste
                    return true;
                }

                return false;
            }
            catch
            {
                return false;
            }
            finally
            {
                _conexaoFake.FecharConexao(conexao);
            }
        }
    }

   

    public class MembroServiceFakeComAdicaoUnitarioTests
    {
        public void AdicionarMembro_DeveRetornarTrue_QuandoInsercaoForBemSucedida()
        {
            var conexaoFake = new ConexaoFake();
            var comandoInsercaoFake = new FakeMySqlCommand(true);
            var comandoIdFake = new FakeMySqlCommand(true);

            var service = new MembroServiceFakeComAdicao(conexaoFake, comandoInsercaoFake, comandoIdFake);

            var novoMembro = new Membro
            {
                Nome = "Carlos Silva",
                CPF = "12312312312",
                Telefone = "11999998888",
                Endereco = "Rua da Praia, 100"
            };

            bool resultado = service.AdicionarMembro(novoMembro);

            if (!resultado)
                throw new Exception("Teste falhou: esperado true, recebeu false");
        }
    }

   // Serviço Fake para edição de membro, seguindo seu padrão de fakes e reader simulado
    public class MembroServiceFakeComEdicao
    {
        private readonly IConexaoFake _conexaoFake;
        private readonly IDataReaderSimulado _readerSimulado; // seu fake data reader
        private readonly IFakeMySqlCommand _comandoUpdateFake;

        public MembroServiceFakeComEdicao(IConexaoFake conexao, IDataReaderSimulado readerSimulado, IFakeMySqlCommand comandoUpdate)
        {
            _conexaoFake = conexao;
            _readerSimulado = readerSimulado;
            _comandoUpdateFake = comandoUpdate;
        }

        public bool EditarMembro(Membro membro)
        {
            var conexao = _conexaoFake.ObterConexao();
            if (conexao == null)
                return false;

            try
            {
                if (!_readerSimulado.Read())
                    return false;

                bool houveAlteracao = false;

                if (_readerSimulado.GetString("Nome") != membro.Nome) houveAlteracao = true;
                if (_readerSimulado.GetString("CPF") != membro.CPF) houveAlteracao = true;
                if (_readerSimulado.GetString("Telefone") != membro.Telefone) houveAlteracao = true;
                if (_readerSimulado.GetString("Endereco") != membro.Endereco) houveAlteracao = true;

                if (!houveAlteracao)
                    return false;

                int resultado = _comandoUpdateFake.ExecuteNonQuery();

                return resultado > 0;
            }
            catch
            {
                return false;
            }
            finally
            {
                _conexaoFake.FecharConexao(conexao);
            }
        }
    }


    public class MembroServiceFakeComExclusao
    {
        private readonly IConexaoFake _conexaoFake;
        private readonly IFakeMySqlCommand _comandoDeleteFake;

        public MembroServiceFakeComExclusao(IConexaoFake conexao, IFakeMySqlCommand comandoDelete)
        {
            _conexaoFake = conexao;
            _comandoDeleteFake = comandoDelete;
        }

        public bool ExcluirMembro(int alunoId)
        {
            var conexao = _conexaoFake.ObterConexao();
            if (conexao == null)
                return false;

            try
            {
                _comandoDeleteFake.AddParameter("@AlunoId", alunoId);

                int resultado = _comandoDeleteFake.ExecuteNonQuery();

                return resultado > 0;
            }
            catch
            {
                return false;
            }
            finally
            {
                _conexaoFake.FecharConexao(conexao);
            }
        }
    }







}
