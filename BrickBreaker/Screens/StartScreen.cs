using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace BrickBreaker
{
    public partial class StartScreen : UserControl
    {
        public StartScreen()
        {
            InitializeComponent();

        }
        private void StartScreen_KeyDown(object sender, KeyEventArgs e)
        {
            MenuScreen ms = new MenuScreen();
            Form1 form = FindForm() as Form1;

            form.ChangeScreen(this, ms);
        }

    }
}
