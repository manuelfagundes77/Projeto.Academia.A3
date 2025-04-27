using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.Academia.A3.Models;
using Projeto.Academia.A3.Services;

namespace Projeto.Academia.A3.Controller
{
    public class FuncionarioController
    {
        private FuncionarioService _funcionarioService;

        public FuncionarioController()
        {
            _funcionarioService = new FuncionarioService();
        }

        // Método para validar login
        public bool ValidarLogin(string login, string senha)
        {
            try
            {
                return _funcionarioService.ValidarLogin(login, senha);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao validar login: " + ex.Message);
            }
        }

        // Método para adicionar um funcionário
        public bool AdicionarFuncionario(string nome, string cargo, string login, string senha)
        {
            Funcionario funcionario = new Funcionario
            {
                Nome = nome,
                Cargo = cargo,
                Login = login,
                Senha = senha
            };

            try
            {
                return _funcionarioService.AdicionarFuncionario(funcionario);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao adicionar funcionário: " + ex.Message);
            }
        }

        // Método para buscar o funcionário pelo login e senha
        public Funcionario BuscarFuncionarioPorLogin(string login, string senha)
        {
            try
            {
                return _funcionarioService.BuscarFuncionarioPorLogin(login, senha);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao buscar funcionário: " + ex.Message);
            }
        }
    }
}
