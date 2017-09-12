using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bs_Pro14.Classes;

namespace Bs_Pro14
{
    static class Program
    {
        public static Person person;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Person.personLogin("034750984", "p123456", ref person); //Temporery - replace the login form
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form2()); //The first form need to be form2. To avoid login it use form 1 temporery.
        }
    }
}
