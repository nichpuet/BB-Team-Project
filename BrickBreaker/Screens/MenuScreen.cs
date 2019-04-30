using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace BrickBreaker
{
    public partial class MenuScreen : UserControl
    {
        //Testing: Displaying Scores

        public MenuScreen()
        {
            InitializeComponent();
            //loadScoresRK();


            scoreOutput();
        }

        public void scoreOutput()
        {
            highScoreLabel.Text = "High Scores\n";
            //testing: displaying the scores
            foreach (HighScore s in Form1.highScores)
            {

                highScoreLabel.Text += s.score + " " + "\n";

                //highScoreLabel.Text = s.score[0] + " " + "\n" + s.score[1] + " " + "\n" + s.score[2]
                //    + " " + "\n" + s.score[3] + " " + "\n" + s.score[4] + " " + "\n";
            }
        }
        //testing
        public void loadScoresRK()
        {
            //creating Xml reader file 
            XmlReader reader = XmlReader.Create("Resources/HighScore.xml", null);
            string newScoreString;

            //basically highScore1String is going to be highScore #1...and on...etc
            //plan: "highScores" should only contain 5 high "scores"

            while (reader.Read())
            {
                if (reader.NodeType == XmlNodeType.Text)
                {
                    newScoreString = reader.ReadString();

                    HighScore newScore = new HighScore(newScoreString);
                    Form1.highScores.Add(newScore);

                }
            }

            reader.Close();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            // Goes to the game screen
            //GameScreen gs = new GameScreen();
            //Form form = this.FindForm();

            //form.Controls.Add(gs);
            //form.Controls.Remove(this);

            //gs.Location = new Point((form.Width - gs.Width) / 2, (form.Height - gs.Height) / 2);

            //testing: most likely will be deleted for the future
            //GameOverScreen gos = new GameOverScreen();
            //Form form = this.FindForm();

            //form.Controls.Add(gos);
            //form.Controls.Remove(this);

            //gos.Location = new Point((form.Width - gos.Width) / 2, (form.Height - gos.Height) / 2);

            //testing: most likely will be deleted for the future
            WinScreen ws = new WinScreen();
            Form form = this.FindForm();

            form.Controls.Add(ws);
            form.Controls.Remove(this);

            ws.Location = new Point((form.Width - ws.Width) / 2, (form.Height - ws.Height) / 2);
        }

    }
}
