using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using Models;
using Models.Repository;

namespace Win
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

            BonusSkins.Register();
            Models.DataSource.ConnectionString =
                File.ReadAllText(Path.Combine(Application.StartupPath, "connectionString.txt"));
            Console.WriteLine(new UnitOfWork().UsersRepo.Fetch().Select(x => x.UserName).Any());
            Application.Run(new Main());
        }
    }
}
