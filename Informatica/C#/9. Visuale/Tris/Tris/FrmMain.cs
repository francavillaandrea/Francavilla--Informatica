using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tris
{
    public partial class FrmMain : Form
    {
        string giocatore;

        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnGioca_Click(object sender, EventArgs e)
        {
            btnGioca.Enabled = false;
            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = true;
            btn9.Enabled = true;
            giocatore = "X";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            btn1.Text = giocatore;
            giocatore = (giocatore == "X") ? "O" : "X";
            btn1.Enabled = false;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            btn2.Text = giocatore;
            giocatore = (giocatore == "X") ? "O" : "X";
            btn2.Enabled = false;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            btn3.Text = giocatore;
            giocatore = (giocatore == "X") ? "O" : "X";
            btn3.Enabled = false;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            btn4.Text = giocatore;
            giocatore = (giocatore == "X") ? "O" : "X";
            btn4.Enabled = false;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            btn5.Text = giocatore;
            giocatore = (giocatore == "X") ? "O" : "X";
            btn5.Enabled = false;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            btn6.Text = giocatore;
            giocatore = (giocatore == "X") ? "O" : "X";
            btn6.Enabled = false;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            btn7.Text = giocatore;
            giocatore = (giocatore == "X") ? "O" : "X";
            btn7.Enabled = false;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            btn8.Text = giocatore;
            giocatore = (giocatore == "X") ? "O" : "X";
            btn8.Enabled = false;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            btn9.Text = giocatore;
            giocatore = (giocatore == "X") ? "O" : "X";
            btn9.Enabled = false;
        }
    }
}
