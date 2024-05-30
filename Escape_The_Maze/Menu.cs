using System;
using System.Windows.Forms;

namespace Escape_The_Maze
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_PLAY_Click(object sender, EventArgs e)
        {
            this.Hide();
            Game_Form game = new Game_Form();
            game.FormClosed += (s, args) => this.Close(); // Close the signup form when login form is closed
            game.Show();
        }
    }
}
