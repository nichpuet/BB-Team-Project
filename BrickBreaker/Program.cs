using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace BrickBreaker
{
    static class Program
    {
        //Declares a file system path
        public static string filePath = $@"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}\Brick Breaker";//Thayen with all Directory code
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //If the game's file system does not exist, create it
            if (!Directory.Exists(filePath))
                Directory.CreateDirectory(filePath);

            if(!Directory.Exists($@"{filePath}\Resources"))
                Directory.CreateDirectory($@"{filePath}\Resources");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
