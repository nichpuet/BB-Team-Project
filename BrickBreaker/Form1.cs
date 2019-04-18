using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

//Rie Koay Branch

namespace BrickBreaker
{
    
    public partial class Form1 : Form
    {
        //TESTING List
        //items in the "highScore" are "scores" but in string form, 
        //the items from the "highScore" can be converted back for comparison
        //XML file will only save the high scores
        List<HighScore> highScores = new List<HighScore>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Start the program centred on the Menu Screen
            MenuScreen ms = new MenuScreen();
            this.Controls.Add(ms);

            ms.Location = new Point((this.Width - ms.Width) / 2, (this.Height - ms.Height) / 2);

            //Below is XML platform to work with 
            //TESTING PURPOSES
        }
        public void loadScores()
        {
            
            //creating Xml reader file 
            XmlReader reader = XmlReader.Create("Resources/gameLevels.xml");
            //declaring what needs to be saved
            string highScore1String, highScore2String, highScore3String, highScore4String, highScore5String;
            //basically highScore1String is going to be highScore #1...and on...etc
            //plan: "highScores" should only contain 5 high "scores"

            while (reader.Read())
            {
                if (reader.NodeType == XmlNodeType.Text)
                {
                    highScore1String = reader.ReadString();

                    reader.ReadToNextSibling("highScore1String");
                    highScore2String = reader.ReadString();

                    reader.ReadToNextSibling("highScore2String");
                    highScore3String = reader.ReadString();

                    reader.ReadToNextSibling("highScore3String");
                    highScore4String = reader.ReadString();

                    reader.ReadToNextSibling("highScore4String");
                    highScore5String = reader.ReadString();

                    HighScore scores = new HighScore(highScore1String, highScore2String, highScore3String, highScore4String, highScore5String);
                    highScores.Add(scores);
                }
            }

            reader.Close();
        }

        public void saveScores()
        {
            XmlWriter writer = XmlWriter.Create("Resources/gameLevels.xml", null);

            writer.WriteStartElement("High Scores");

            foreach (HighScore s in highScores)
            {
                    writer.WriteStartElement("High Scores");

                    writer.WriteElementString("Score #1", s.score1);
                    writer.WriteElementString("Score #2", s.score2);
                    writer.WriteElementString("Score #3", s.score3);
                    writer.WriteElementString("Score #4", s.score4);
                    writer.WriteElementString("Score #5", s.score5);

                    writer.WriteEndElement();
            }

                writer.WriteEndElement();

                writer.Close();
        }
    }
}
