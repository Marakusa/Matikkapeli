using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Matikkapeli
{
    public partial class GameMode : Form
    {
        private MainMenu mainMenu;

        public GameMode(MainMenu mainMenu)
        {
            InitializeComponent();

            this.mainMenu = mainMenu;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mainMenu.StartGameMode(listBox1.SelectedIndex);
            this.Close();
        }
    }
}
