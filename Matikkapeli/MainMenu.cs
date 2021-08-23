using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matikkapeli
{
    public partial class MainMenu : Form
    {
        private string startWelcome;
        private string username = "Loading...";

        private Nopeustesti nopeustesti;

        public MainMenu()
        {
            InitializeComponent();
            startWelcome = welcome.Text;
        }

        public void SetUsername(string username)
        {
            this.username = username;
            welcome.Text = string.Format(startWelcome, this.username);
        }

        private void MainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void start_Click(object sender, EventArgs e)
        {
            GameMode gameMode = new GameMode(this);
            gameMode.Show();
        }

        private void achievements_Click(object sender, EventArgs e)
        {

        }

        private void logout_Click(object sender, EventArgs e)
        {
            welcome.Text = startWelcome;

            Properties.Settings.Default.username = "";
            Properties.Settings.Default.password = "";
            Properties.Settings.Default.Save();

            Program.LogOut();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            welcome.Text = startWelcome;

            Application.Exit();
        }

        public void StartGameMode(int gameMode)
        {
            bool gameModeStarted = false;

            switch (gameMode)
            {
                case 0:
                    nopeustesti = new Nopeustesti();
                    nopeustesti.Show();
                    nopeustesti.FormClosing += Nopeustesti_FormClosing;
                    gameModeStarted = true;
                    break;
                case 1:

                    break;
            }

            if (gameModeStarted)
                Enabled = false;
        }

        private void Nopeustesti_FormClosing(object sender, FormClosingEventArgs e)
        {
            Enabled = true;
        }
    }
}
