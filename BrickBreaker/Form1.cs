using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Media;

// Max Senez UI branch

namespace BrickBreaker
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// The Game's Soundplayer.
        /// Note that remember that playSoundFrom and preloadSound will save lines of code when used
        /// </summary>
        public static SoundPlayer SoundPlayer = new SoundPlayer();
        public static GameScreen currentGame;
        public Form1()
        {
            InitializeComponent();
            Directory.SetCurrentDirectory(Program.FilePath);//Set the program to put files in the created directory
            Size = new Size(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);
            Location = new Point(0, 0);
        }

        [Obsolete("TODO Game Screen scales incorrectly")]
        public void ConfigScreen(ref UserControl c)
        {
            c.Width = Width;
            c.Height = Height;
            c.Location = new Point(0, 0);
        }

        /// <summary>
        /// Gets a .wav file from the file path and plays it
        /// </summary>
        /// <param name="filePath"></param>
        public static void playSoundFrom(string filePath)
        {
            if (File.Exists(filePath))
            {
                SoundPlayer.SoundLocation = filePath;
                SoundPlayer.PlaySync();
            }
            else
                throw new Exception("Could not find the required file");
        }

        /// <summary>
        /// Gets the .wav file from specified location and loads it into the soundplayer
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public static bool preloadSound(string filePath)
        {
            if(File.Exists(filePath))
            {
                SoundPlayer.SoundLocation = filePath;
                SoundPlayer.Load();
                return true;
            }
            return false;
        }

        public void ChangeScreen(UserControl remove, UserControl add)
        {
            ConfigScreen(ref add);
            Controls.Add(add);
            Controls.Remove(remove);
            remove.Dispose();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            StartScreen ss = new StartScreen();
            this.Controls.Add(ss);

            ss.Location = new Point((this.Width - ss.Width) / 2, (this.Height - ss.Height) / 2);

        }

  
        
    }
}
