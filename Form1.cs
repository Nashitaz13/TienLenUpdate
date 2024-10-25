using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TienLenDoAn
{
    public partial class TienLenForm : Form
    {
        public TienLenForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void customButton1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void customButton1_Click_1(object sender, EventArgs e)
        {
            SinglePlayer singlePlayerForm = new SinglePlayer(this);
            singlePlayerForm.Show();
        }

        private void customButton4_Click(object sender, EventArgs e)
        {
            this.Close();  
        }

        private void customButton3_Click(object sender, EventArgs e)
        {
            Option optionForm = new Option(this);
            optionForm.Show();
        }

        private void MultiplayButton_Click(object sender, EventArgs e)
        {
            Multiplayer multiplayerForm = new Multiplayer();
            multiplayerForm.Show();
        }
    }
}
