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

namespace BrickBreaker
{
    public partial class Form1 : Form
    {
        private static SoundPlayer player;
        public static GameScreen currentGame;
        public Form1()
        {
            InitializeComponent();

            Directory.SetCurrentDirectory(Program.FilePath);//Set the program to put files in the created directory
        }

        /// <summary>
        /// Gets a WAV file from the file path and plays it
        /// </summary>
        /// <param name="filePath"></param>
        public static void playSoundFrom(string filePath)
        {
            if (File.Exists(filePath))
            {
                player.SoundLocation = filePath;
                player.PlaySync();
            }
            else
                throw new Exception("Could not find the required file");
        }

        /// <summary>
        /// Gets the WAV file from specified location and loads it into the soundplayer
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public static bool preloadSound(string filePath)
        {
            if(File.Exists(filePath))
            {
                player.SoundLocation = filePath;
                player.Load();
                return true;
            }
            return false;
        }

        /// <summary>
        /// Plays the WAV file loaded with preloadSound
        /// </summary>
        public static void playSound()
        {
            player.Play();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Start the program centred on the Menu Screen
            MenuScreen ms = new MenuScreen();
            this.Controls.Add(ms);
            //Center the control
            ms.Location = new Point((this.Width - ms.Width) / 2, (this.Height - ms.Height) / 2);
            //ms.Size = new Size(this.Width, this.Height);
        }
    }
}
