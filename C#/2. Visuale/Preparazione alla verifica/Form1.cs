using System;
using System.Data.SqlClient;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace EsericiziProva
{
    public partial class Form1 : Form
    {
        int[,] m;
        int[] v;
        int[] aus;
        int[] a1 = new int[3];
        int[] a2 = new int[3];
        int[] ris = new int[4];
        int n; // Numero + 1 dei valori da generare casualmente 
        int l; // Lunghezza del vettore
        static Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            n = Convert.ToInt32(Interaction.InputBox("Inserisci il valore massimo dei valori che vuoi generare"));
            l = Convert.ToInt32(Interaction.InputBox("Inserisci la lunghezza del vettore"));
            v = new int[l];
            aus = new int[l];
            settaDGV(dgvVettore, l);
            settaDGV(dgvVettoreAusiliario, l);
            settaDGV(DgvRis, 3);
            settaDGV(Dgv1, 3);
            a1 = new int[3];
            ClsVettori.caricaVettore(a1, 1, 9);
            ClsVettori.visualizzaVettore(a1, Dgv1);
            settaDGV(Dgv2, 3);
            a2 = new int[3];
            ClsVettori.caricaVettore(a2, 1, 9);
            ClsVettori.visualizzaVettore(a2, Dgv2);
            settaDGV(DgvRis, 4);
            ClsVettori.caricaVettore(ris, 0, 0);
            ClsVettori.visualizzaVettore(ris, DgvRis);
        }

        private void btnCaricaVettore_Click(object sender, EventArgs e)
        {
           
            ClsVettori.caricaVettore(v, 1, n);
            ClsVettori.visualizzaVettore(v, dgvVettore);
            ClsVettori.caricaVettore(aus, 1, n);
            ClsVettori.visualizzaVettore(aus, dgvVettoreAusiliario);

        }

        private void btnCaricaSolo1Vettore_Click(object sender, EventArgs e)
        {
            settaDGV(dgvVettore, l);
            settaDGV(dgvVettoreAusiliario, l);
            string domanda = Interaction.InputBox("Scegli quale vettore vuoi caricare tra: \n 1. Vettore_1 \n 2. Vettore_Aus");
            if (domanda == "Vettore_1")
            {
                ClsVettori.caricaVettore(v, 1, n);
                ClsVettori.visualizzaVettore(v, dgvVettore);
            }
            else if(domanda == "Vettore_Aus")
            {
                ClsVettori.caricaVettore(aus, 1, n);
                ClsVettori.visualizzaVettore(aus, dgvVettoreAusiliario);
            }
            else
            {
                MessageBox.Show("Opzione non disponibile");
            }


        }

        private void btnMedia_Click(object sender, EventArgs e)
        {
            ClsVettori.calcolaMediaVettore(v );
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

        private void btnMax_Click(object sender, EventArgs e)
        {
            ClsVettori.cercaMaxVettore(v);
        }

        private void btnSpeculare_Click(object sender, EventArgs e)
        {
            ClsVettori.verificaVettoreSpeculare(v);
        }

        private void btnSomma_Click(object sender, EventArgs e)
        {
            ClsVettori.sommaVettore(v);
        }

        private void btnMediaDi2Vettori_Click(object sender, EventArgs e)s
        {
            ClsVettori.Media2Vettori(v, aus);
        }

        private void btnCopiaVettore_Click(object sender, EventArgs e)
        {
            ClsVettori.copiaVettore(v, aus);
            ClsVettori.visualizzaVettore(aus, dgvVettoreAusiliario);
        }

        private void btnOrdina_Click(object sender, EventArgs e)
        {
            ClsVettori.OrdinaVettore(v);
            ClsVettori.visualizzaVettore(v, dgvVettore);
        }

        private void btnRicerca_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(Interaction.InputBox("Inserisci il valore da cercare"));
            ClsVettori.cercaElementoVettore(v, x);
        }

        private void btnSommaDi2Vettori_Click(object sender, EventArgs e)
        {

            ClsVettori.sommaVettori(a1, a2, DgvRis);
        }

        private void btnPrimi3_Click(object sender, EventArgs e)
        {
            ClsVettori.cercaPrimi3(v);
        }

        private void btnCaricaMatrice_Click(object sender, EventArgs e)
        {
            ClsMatrice.caricaMatrice(m)
        }
    }
}
