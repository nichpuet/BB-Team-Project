using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Max Senez UI branch

namespace BrickBreaker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StartScreen ss = new StartScreen();
            this.Controls.Add(ss);

            ss.Location = new Point((this.Width - ss.Width) / 2, (this.Height - ss.Height) / 2);
        }
    }
}
