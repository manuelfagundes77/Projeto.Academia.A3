using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Projeto.Academia.A3.Data;

namespace Projeto.Academia.A3.inteface
{
    public class ConexaoReal : IConexao
    {
        public MySqlConnection ObterConexao()
        {
            return Conexao.ObterConexao(); // sua classe atual
        }
    }


}
