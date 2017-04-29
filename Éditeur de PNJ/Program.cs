using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Éditeur_de_PNJ
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            config config = new config();
            Form my;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            if (!config.load("config.conf"))
                my = new win_config(config);
            else
                my = new tool(config);
            Application.Run(my);
        }
    }
}
