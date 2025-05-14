using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Projeto.Academia.A3.inteface
{
    public interface IConexao
    {
        MySqlConnection ObterConexao();
    }
}
