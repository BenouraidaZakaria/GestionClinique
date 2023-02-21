using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionClinique
{
    static class Program
    {
        static public int  iduser;
        static public string  nameuser;
        static public string  prenomuser;
        static public string  typeuser;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Application.Run(new AccueilSecretaire());
            //Application.Run(new AcceuilDoctors());
            Application.Run(new login());
        }
    }
}
