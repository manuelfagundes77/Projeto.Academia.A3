using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto.Academia.A3
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
           Application.Run(new View.TelaLogin());
            // Application.Run(new View.TelaAdicionarFuncionario());   
       //    Application.Run(new View.MenuLayout());
          //  Application.Run(new View.TelaFuncionarioTreinos());
        }
    }
}
