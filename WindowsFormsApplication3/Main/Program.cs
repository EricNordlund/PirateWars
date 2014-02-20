using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PirateWars
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            DataAccessLayer dal = new DataAccessLayer();
            Game game = new Game();
            game.InitializePorts();
            Controller controller = new Controller(ref dal, ref game);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(ref controller));

        }
    }
}
