using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Bulls_and_Cows
{
    class Program
    {
        Parcer prcr = new Parcer();

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (args.Contains("-nogui"))
            {
                // In the process...
                string message = "Режим «nogui» находится разработке.";  
                string title = "Bulls & Cows";  
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBoxIcon sound = MessageBoxIcon.Warning;
                MessageBox.Show(message, title, buttons, sound);
            }
            else
            {
                
                Application.Run(new MainForm());
            }
        }
    }
}
