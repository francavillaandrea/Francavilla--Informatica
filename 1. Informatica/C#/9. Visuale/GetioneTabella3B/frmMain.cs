using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace GetioneTabella3B
{
    public partial class frmMain : Form
    {
        static Random rnd = new Random();
        public struct studente
        {
            public int matricola;
            public string cognome;
            public string nome;
            public string classe;
        }
        string[] datiStudenti = new string[]
        {
            "Rossi Marco 1A", "Bianchi Luca 2B",
            "Ferrari Anna 3C", "Giordano Francesco 1D",
            "Colombo Silvia 2A", "Romano Paolo 3B",
            "Ricci Maria 1C", "Moretti Giuseppe 2C",
            "Lombardi Alessandra 3A", "Costa Stefano 1B",
            "Russo Claudia 2D", "Esposito Michele 1A",
            "Martino Elena 3D", "DeLuca Carlo 2B",
            "Mancini Giulia 3C", "Santoro Paolo 1D",
            "Galli Francesco 2A", "Ferrari Laura 1C",
            "Caruso Pietro 3B", "Vitale Caterina 2C",
            "Marchi Luca 1B", "Marino Federica 2D",
            "Fabbri Edoardo 3A", "Perri Anna 1A",
            "Neri Davide 2B", "Taddei Giorgia 3C",
            "Barone Roberto 1D", "Serra Valentina 2A",
            "Bianchini Luca 1C", "Cattaneo Alessandra 3B",
            "Greco Alessandro 1A", "Romani Chiara 2B",
            "De Angelis Matteo 3C", "Fontana Luca 1D",
            "Palumbo Sofia 2A", "Riva Marco 3B",
            "Sartori Elena 1C", "Mazza Fabio 2C",
            "Gatti Laura 3A", "Orlandi Paolo 1B",
            "Negri Alessandra 2D", "Longo Davide 3D"
        };

        studente[] studenti;
        int ns; //numero studenti
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnCaricaTabellaStudenti_Click(object sender, EventArgs e)
        {
            if (!(int.TryParse(Interaction.InputBox("Inserisci il numero di studenti:"), out ns) && ns > 0))
                MessageBox.Show("Devi inserire un valore positivo");
            studenti = new studente[ns];
            settaDgv(dgvStudenti, ns, 4);
            caricaTabellaStudenti(studenti, datiStudenti);
        }

        private void caricaTabellaStudenti(studente[] studenti, string[] dati)
        {
            string[] dato = new string[3];
            int x = rnd.Next(1, 1000);
            for (int i = 0; i < studenti.Length; i++)
            {
                studenti[i].matricola = x + rnd.Next(1, 10);
                dato = dati[i].Split(' ');
                studenti[i].cognome = dato[0];
                studenti[i].nome = dato[1];
                studenti[i].classe = dato[2];
                scriviSuDgv(dgvStudenti, studenti[i], i);
            }
        }

        private void scriviSuDgv(DataGridView dgv, studente studente, int i)
        {
            dgv.Rows[i].Cells[0].Value = studente.matricola.ToString();
            dgv.Rows[i].Cells[1].Value = studente.cognome;
            dgv.Rows[i].Cells[2].Value = studente.nome;
            dgv.Rows[i].Cells[3].Value = studente.classe;
            dgv.AutoResizeColumns();
            dgv.AutoResizeRows();
        }

        private void settaDgv(DataGridView dgv, int r, int c)
        {
            dgv.RowCount = r;
            dgv.ColumnCount = c;
            dgv.ClearSelection();
            dgv.RowHeadersVisible = false;
            intestaTabella(dgvStudenti, c, "MATRICOLA,COGNOME,NOME,CLASSE");



        }

        private void intestaTabella(DataGridView dgv, int c, string msg)
        {
            string[] v = new string[c];
            v = msg.Split(',');
            for (int j = 0; j < c; j++)
                dgv.Columns[j].HeaderText = v[j];
        }

        private void btn_ordina_Click(object sender, EventArgs e)
        {
            ordinaStudentiNominativo(studenti);
            visualTabella(studenti, dgvStudenti);
        }

        private void visualTabella(studente[] studenti, DataGridView dgvStudenti)
        {
            for (int i = 0; i < studenti.Length; i++)
            {
                dgvStudenti.Rows[i].Cells[0].Value = studenti[i].matricola.ToString();
                dgvStudenti.Rows[i].Cells[1].Value = studenti[i].cognome.ToString();
                dgvStudenti.Rows[i].Cells[2].Value = studenti[i].nome.ToString();
                dgvStudenti.Rows[i].Cells[3].Value = studenti[i].classe.ToString();
            }
        }

        private void ordinaStudentiNominativo(studente[] studenti)
        {
            int minIndex = 0;
            string nominativo1 = null;
            string nominativo2 = null;
            for (int i = 0; i <= studenti.Length - 2; i++)
            {
                minIndex = i;
                for (int j = (i + 1); j <= studenti.Length - 1; j++)
                {
                    nominativo1 = studenti[minIndex].cognome + studenti[minIndex].nome;
                    nominativo2 = studenti[j].cognome + studenti[j].nome;
                    if (nominativo1.CompareTo(nominativo2) > 0)
                    {
                        minIndex = j;

                    }
                }
                if (i != minIndex)
                {
                    scambioRecord(ref studenti[i], ref studenti[minIndex]);
                }
            }
        }

        private void scambioRecord(ref studente studente1, ref studente studente2)
        {
            studente aus;
            aus = studente1;
            studente1 = studente2;
            studente2 = aus;
        }

        private void btn_RicercaClasse_Click(object sender, EventArgs e)
        {
            ordinaStudentiClasse(studenti);
            visualTabella(studenti, dgvStudenti);
            string classe = Interaction.InputBox("Inserisci la classe:");
            MessageBox.Show($"Gli studenti della classe {classe} sono in totale {contaStudentiClasse(classe, studenti)}");
        }

        private object contaStudentiClasse(string classe, studente[] studenti)
        { 
            int i = 0;
            int cont = 0; 
            bool trovato = false;
            bool superato = false;
            while (!superato && i <= studenti.Length - 1)
            {
                if (studenti[i].classe == classe)
                {
                    trovato = true;
                    i++;
                    cont++;
                }
                else
                {
                    if (studenti[i].classe.CompareTo(classe) > 0)
                    {
                        superato = true;

                    }
                    else
                    { 
                        i++;
                    }
                }
                if (!trovato)
                    Console.WriteLine("Classe non trovata");
            }
            return cont;
        }

        private void ordinaStudentiClasse(studente[] studenti)
        {
            int minIndex = 0;
            for (int i = 0; i <= studenti.Length - 2; i++)
            {
                minIndex = i;
                for (int j = (i + 1); j <= studenti.Length - 1; j++)
                {
                    if (studenti[minIndex].classe.CompareTo(studenti[j].classe) > 0)
                    {
                        minIndex = j;

                    }
                }
                if (i != minIndex)
                {
                    scambioRecord(ref studenti[i], ref studenti[minIndex]);
                }
            }
        }
    }
}
