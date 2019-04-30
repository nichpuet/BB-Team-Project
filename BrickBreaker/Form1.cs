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
        
        public static List<HighScore> highScores = new List<HighScore>();

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


            //Plans for next step...determine if the score should be saved to the list (5 scores should be in high scores)
            //Set variables to each of the score like highScores[0]...highScores[4]...as these will be displayed 
            //if the list contains the same score, then do not add it again to the list
            //if (highScores.Contains(the same score))
            //{
            //  Do not display, just proceed
            //}
            //if the list does not contain the same score, check if the score is more or less than the scores in highScores
            //{
            //  if the score is more, then display
            //  if the score is less, then do not display
            //}
        }



    }
}
