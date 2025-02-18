using System;
using System.Configuration;
using System.Deployment.Internal;
using System.Diagnostics.Eventing.Reader;
using System.Windows.Forms;
using Microsoft.VisualBasic;


namespace Gestione_Tabella
{
    public partial class FrmMain : Form
    {
        static Random rnd = new Random();
        int ns = 0; //N studenti
        public struct studente
        {
            public int matricola;
            public string cognome;
            public string nome;
            public string classe;
        }
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnCarica_Click(object sender, EventArgs e)
        {
            if (!(int.TryParse(Interaction.InputBox("Inserisci il numero di studenti: "), out ns) && (ns > 0)))
            {
                MessageBox.Show("Devi inserire un valore positivo");
            }
            studente[] studenti = new studente[ns];
            int c = 4;
            settaDGV(dgv, ns, c);
            caricaTabella(studenti);

        }

        private void settaDGV(DataGridView dgv, int r, int c)
        {
            dgv.ColumnCount = c;
            dgv.RowCount = r;
            dgv.ClearSelection();
            dgv.ColumnHeadersVisible = false;
            intestaTabella(dgv, c, "MATRICOLA, COGNOME, NOME, CLASSE");
            

        }

        private void intestaTabella(DataGridView dgv, int c, string msg)
        {
            string[] v = new string[c];
            v = msg.Split(',');
            for (int i = 0; i < c; i++)
            {
                dgv.Columns[i].HeaderText = "xx" + (i + 1);
            }
        }

        private void caricaTabella(studente[] studenti)
        {
            int x = rnd.Next(1, 1001);
            for (int i = 0; i < studenti.Length; i++)
            {
                studenti[i].matricola = x + rnd.Next(1,10);
                studenti[i].cognome = Interaction.InputBox("Inserisci il cognome");
                studenti[i].nome= Interaction.InputBox("Inserisci il nome");
                studenti[i].classe= Interaction.InputBox("Inserisci la classe");
                scriviDGV(studenti[i], i);
            }
        }

        private void scriviDGV(studente studente, int i)
        {
            dgv.Rows[i].Cells[0] = studente.matricola.ToString();
        }
    }
}
