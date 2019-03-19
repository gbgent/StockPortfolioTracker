using StockTrackerDataLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockTrackerApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Initialize Connection to the Databases
            StockTrackerDataLibrary.GlobalConfig.InitializeConnections(DatabaseType.Sql);
            
            // Application.Run(new StockPriceUpdateForm());
            Application.Run(new MainFrm());
        }
    }
}
