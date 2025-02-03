using System;
using System.Windows.Forms;
using Microsoft.VisualBasic; //NotaBene

namespace VettoriMatriciVisuale
{
    public partial class frmMain : Form
    {
        int[] a;
        int[] addendo1;
        int[] addendo2;
        int[] somma;
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            
            int n = Convert.ToInt32(Interaction.InputBox("Inserisci la lunghezza del vettore"));
            settaDGV(dgvA, n);
            a = new int[n];
            clsVettori.caricaVettore(a, 1, 100);
            clsVettori.visualizzaVettore(a, dgvA);
            settaDGV(dgv3, 3);
            settaDGV(dgv1Addendo, 3);
            addendo1 = new int[3];
            clsVettori.caricaVettore(addendo1, 1, 9);
            clsVettori.visualizzaVettore(addendo1, dgv1Addendo);
            settaDGV(dgv2Addendo, 3);
            addendo2 = new int[3];
            clsVettori.caricaVettore(addendo2,1,9);
            clsVettori.visualizzaVettore(addendo2, dgv2Addendo);
            settaDGV(dgvSomma, 3);
            somma = new int[3];
            clsVettori.caricaVettore(somma, 0, 0);
            clsVettori.visualizzaVettore(somma, dgvSomma);
        }

        private void settaDGV(DataGridView dgv, int n)
        {
            //vettore riga
            dgv.RowCount = 1;
            dgv.ColumnCount = n;
            dgv.RowHeadersVisible = false;
            dgv.ColumnHeadersVisible = false;
            dgv.AutoResizeColumns();
            dgv.AutoResizeRows();
           
        }

        private void btnMaxVettore_Click(object sender, EventArgs e)
        {
            clsVettori.cercaMaxVettore(a);
        }

        private void btnCalcolaMediaVettore_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La media del vettore è "
                + clsVettori.calcolaMediaVettore(a).ToString("F2"));
        }

        private void btnCercaElementoVettore_Click(object sender, EventArgs e)
        {
            int x=Convert.ToInt32(txtNumero.Text);

            clsVettori.cercaElementoVettore(a ,x);
            txtNumero.Text = null;
        }

        private void btnSpeulare_Click(object sender, EventArgs e)
        {
            clsVettori.verificaVettoreSpeculare(a);
        }

        private void btnPrimi3_Click(object sender, EventArgs e)
        {
            clsVettori.cercaPrimi3(a, dgv3);
        }
    }
}
