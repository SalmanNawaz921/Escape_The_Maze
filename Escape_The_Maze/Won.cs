using System;
using System.Windows.Forms;

namespace Escape_The_Maze
{
    public partial class Won : Form
    {
        public Won()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
