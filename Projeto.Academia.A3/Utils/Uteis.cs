using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto.Academia.A3.Utils
{
    public static class Uteis
    {
        //Classe para formatar a Data para BR
        public static string FormatarData(DateTime data)
        {
            return data.ToString("dd/MM/yyyy");
        }

        public static bool ValidarSomenteNumeros(string texto, string nomeCampo)
        {
            if (!texto.All(char.IsDigit))
            {
                MessageBox.Show($"{nomeCampo} deve conter apenas números!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

    }
}
