using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace VettoriMatriciVisuale
{
    public partial class frmMain : Form
    {
        int[] a; 
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            
            int n = Convert.ToInt32(Interaction.InputBox("Inserisci la lunghezza del vettore"));
            settaDGV(dgvA, n);
            a = new int[n];
            clsVettori.caricaVettore(a);
            clsVettori.visualizzaVettore(a, dgvA);

        }

        private void settaDGV(DataGridView dgv, int n)
        {
            dgv.RowCount = 1;
            dgv.ColumnCount = n;
            dgv.RowHeadersVisible = false;
            dgv.ColumnHeadersVisible = false;
            dgv.AutoResizeColumns();
            dgv.Rows[0].Height = dgv.Columns[0].Width;
            dgv.AutoSizeColumnsMode=DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnMaxVettore_Click(object sender, EventArgs e)
        {
            clsVettori.cercaMaxVettore(a);
        }
    }
}
