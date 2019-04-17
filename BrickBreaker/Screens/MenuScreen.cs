using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrickBreaker
{
    public partial class MenuScreen : UserControl
    {
        private static int index = 0;
        private List<Button> buttons = new List<Button>();
        public MenuScreen()
        {
            InitializeComponent();
            foreach(var button in Controls.OfType<Button>())
            {
                buttons.Add(button);
            }
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
            GameScreen gs = new GameScreen();
            Form form = this.FindForm();

            form.Controls.Add(gs);
            form.Controls.Remove(this);

            gs.Location = new Point((form.Width - gs.Width) / 2, (form.Height - gs.Height) / 2);
        }

        /// <summary>
        /// The event code for when the Menu Screen finishes initializing loads
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuScreen_Load(object sender, EventArgs e)
        {
            playButton.Location = new Point((Width / 2) - (playButton.Width / 2), (Height/3));
            exitButton.Location = new Point((Width / 2) - (playButton.Width / 2), (Height / 3 * 2));
        }

        /// <summary>
        /// The event code for when the Main Menu detects a key press
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuScreen_KeyDown(object sender, KeyEventArgs e)
        {
            switch(e.KeyCode)
            {
                case Keys.Up:
                    newButton(-1).Focus();
                    break;
                case Keys.Down:
                    newButton(1).Focus();
                    break;
            }
        }

        /// <summary>
        /// Gets the newly selected button based on where the last one was
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        private Button newButton(int where)
        { 
            index += where;
            //If the button is out of range set the button within range
            if (index < 0)
                index = 0;
            else if (index >= buttons.Count)
                index = buttons.Count - 1;
            return buttons[index];
        }
    }
}
