using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace BrickBreaker
{
    public partial class MenuScreen : UserControl
    {
        private static int index = 0;
        private List<Label> labels = new List<Label>();
        public MenuScreen()
        {
            InitializeComponent();
            //
            //Adding Labels to Label list for easy management
            //
            labels.Add(titleLabel);
            labels.Add(playLabel);
            labels.Add(highscoreLabel);
            labels.Add(exitLabel);
        }

        /// <summary>
        /// Only for buttons made by Thayen
        /// </summary>
        private void gainFocus(object sender, EventArgs e)
        {
            var label = sender as Label;
            label.ForeColor = Color.Red;
        }

        /// <summary>
        /// Only for buttons made by Thayen
        /// </summary>
        private void lostFocus(object sender, EventArgs e)
        {
            var button = sender as Button;
            button.ForeColor = Color.Black;
        }

        /// <summary>
        /// The event code for when the exist button is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// The event code for when the play button is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void playButton_Click(object sender, EventArgs e)
        {
            // Goes to the game screen
            var form = FindForm() as Form1;
            form.ChangeScreen(this, new GameScreen());
        }        
       
        /// <summary>
        /// The event code for when the Menu Screen finishes initializing loads
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuScreen_Load(object sender, EventArgs e)
        {
            var ratio = 6;
            for (int i = 0; i < labels.Count; i++)
            {
                labels[i].Size = new Size(Width / ratio + 125, Height / ratio);
                var space = (Height /4) - labels[i].Height + (100 * i);
                labels[i].Location = new Point((Width / 2) - (labels[i].Width / 2), space);
            }
        }

        /// <summary>
        /// The event code for when the Main Menu detects a key press
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuScreen_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    _newButton(-1).Focus();
                    break;
                case Keys.Down:
                    _newButton(1).Focus();
                    break;
            }
        }

        /// <summary>
        /// Gets the newly selected button based on where the last one was. Pass a negative to go back in the list of buttons
        /// </summary>
        /// <param name="changeInIndex"></param>
        /// <returns></returns>
        private Label _newButton(int changeInIndex)
        {
            //Thayen
            index += changeInIndex;
            //If the button is out of range set the button within range
            if (index < 0)
                index = 0;
            else if (index >= labels.Count)
                index = labels.Count - 1;
            return labels[index];

        }
    }
}
