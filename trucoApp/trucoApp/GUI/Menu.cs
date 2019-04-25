using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trucoApp.GUI
{
    public partial class Menu : Form
    {
        public Menu(int difficulty)
        {
            InitializeComponent();
            dif = difficulty;
            loadMenu();
        }
        static int dif;
        public int Difficulty
        {
            get
            {
                return dif;
            }
        }
        public void loadMenu()
        {

            switch (dif)
            {
                case 0:
                    btnDifficulty.Text = "Difficulty : Easy";
                    break;
                case 1:
                    btnDifficulty.Text = "Difficulty: Medium";
                    break;
                case 2:
                    btnDifficulty.Text = "Difficulty: Hard";
                    break;
            }
        }


        private void btnDifficulty_Click(object sender, EventArgs e)
        {
            if (dif == 2)
            {
                dif = 0;
            }
            else
            {
                dif++;
            }
            loadMenu();             
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
