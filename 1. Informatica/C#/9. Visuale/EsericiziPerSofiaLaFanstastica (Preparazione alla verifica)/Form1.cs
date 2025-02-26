using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace EsericiziProva
{
    public partial class Form1 : Form
    {
        int[] v;
        int n;
        static Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCaricaVettore_Click(object sender, EventArgs e)
        {
            ClsVettori.CaricaVett(v, n);
            ClsVettori.StampaVett(v, n);
            
        }
    }
}
