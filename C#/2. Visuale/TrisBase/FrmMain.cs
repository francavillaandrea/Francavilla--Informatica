using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrisBase
{
    public partial class FrmMain : Form
    {
        string giocatore; // "X" o "O"
        string vincitore;
        string[,] t = new string[3, 3];
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
            

            t[0, 0] = giocatore;
            vincitore = vittoria(t, giocatore);
            if (vincitore != " ")
                MessageBox.Show("Ha vinto il giocatore " + vincitore, "TRIS");
            else
            {
                btnGioca_Click(sender, e);
            }


            giocatore = (giocatore == "X") ? "O" : "X"; // Operatore ternario
           
            btn1.Enabled = false;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            btn2.Text = giocatore;
            t[0, 1] = giocatore;
            vincitore = vittoria(t, giocatore);
            if (vincitore != " ")
                MessageBox.Show("Ha vinto il giocatore " + vincitore, "TRIS");
           
            giocatore = (giocatore == "X") ? "O" : "X"; // Operatore ternario

            btn2.Enabled = false;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            btn3.Text = giocatore;
            t[0, 2] = giocatore;
            vincitore = vittoria(t, giocatore);
            if (vincitore != " ")
                MessageBox.Show("Ha vinto il giocatore " + vincitore, "TRIS");
            
            giocatore = (giocatore == "X") ? "O" : "X"; // Operatore ternario

            btn3.Enabled = false;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            btn4.Text = giocatore;
            t[1, 0] = giocatore;
            vincitore = vittoria(t, giocatore);
            if (vincitore != " ")
                MessageBox.Show("Ha vinto il giocatore " + vincitore, "TRIS");
            
            giocatore = (giocatore == "X") ? "O" : "X"; // Operatore ternario

            btn4.Enabled = false;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            btn5.Text = giocatore;
            t[1, 1] = giocatore;
            vincitore = vittoria(t, giocatore);
            if (vincitore != " ")
                MessageBox.Show("Ha vinto il giocatore " + vincitore, "TRIS");
            
            giocatore = (giocatore == "X") ? "O" : "X"; // Operatore ternario

            btn5.Enabled = false;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            btn6.Text = giocatore;
            t[1, 2] = giocatore;
            vincitore = vittoria(t, giocatore);
            if (vincitore != " ")
                MessageBox.Show("Ha vinto il giocatore "+ vincitore,"TRIS");
            
            giocatore = (giocatore == "X") ? "O" : "X"; // Operatore ternario

            btn6.Enabled = false;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            btn7.Text = giocatore;
            t[2, 0] = giocatore;
            vincitore = vittoria(t, giocatore);
            if (vincitore != " ")
                MessageBox.Show("Ha vinto il giocatore " + vincitore, "TRIS");
            
            giocatore = (giocatore == "X") ? "O" : "X"; // Operatore ternario

            btn7.Enabled = false;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            btn8.Text = giocatore;
            t[2, 1] = giocatore;
            vincitore = vittoria(t, giocatore);
            if (vincitore != " ")
                MessageBox.Show("Ha vinto il giocatore " + vincitore, "TRIS");
            
            giocatore = (giocatore == "X") ? "O" : "X"; // Operatore ternario

            btn8.Enabled = false;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            btn9.Text = giocatore;
            t[2, 2] = giocatore;
            vincitore = vittoria(t, giocatore);
            if (vincitore != " ")
                MessageBox.Show("Ha vinto il giocatore " + vincitore, "TRIS");
            
            giocatore = (giocatore == "X") ? "O" : "X"; // Operatore ternario

            btn9.Enabled = false;
        }
        private static string vittoria(string[,] t, string ch)
        {
            if ((t[0, 0] == ch && t[0, 1] == ch && t[0, 2] == ch) ||
                    (t[1, 0] == ch && t[1, 1] == ch && t[1, 2] == ch) ||
                    (t[2, 0] == ch && t[2, 1] == ch && t[2, 2] == ch) ||
                    (t[0, 0] == ch && t[1, 0] == ch && t[2, 0] == ch) ||
                    (t[0, 1] == ch && t[1, 1] == ch && t[2, 1] == ch) ||
                    (t[0, 2] == ch && t[1, 2] == ch && t[2, 2] == ch) ||
                    (t[0, 0] == ch && t[1, 1] == ch && t[2, 2] == ch) ||
                    (t[0, 2] == ch && t[1, 1] == ch && t[2, 0] == ch))
                return ch;
            else
                return " ";
        }
    }
}
