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
            "Ferrari Anna 2B", "Giordano Francesco 1D", 
            "Colombo Silvia 2A", "Romano Paolo 2B", 
            "Bianchi Maria 1A", "Rossi Giuseppe 2C", 
            "Lombardi Alessandra 3A", "Costa Stefano 1B", 
            "Russo Claudia 2D", "Esposito Michele 1A", 
            "Martino Elena 2B", "DeLuca Carlo 2B", 
            "Costa Giulia 3C", "Santoro Paolo 1A", 
            "Galli Francesco 2A", "Ferrari Laura 1A", 
            "Caruso Pietro 3B", "Vitale Caterina 2C", 
            "Marchi Luca 2B", "Costa Federica 2B", 
            "Fabbri Edoardo 1A", "Perri Anna 1A", 
            "Neri Davide 2B", "Taddei Giorgia 3C", 
            "Barone Roberto 2B", "Serra Valentina 2A", 
            "Bianchini Luca 1A", "Cattaneo Alessandra 3B"
        };
        studente[] studenti;
        int ns; //numero studenti
        public struct valutazione
        {
            public string materia;
            public int voto;
            public DateTime data;
            public int matricola; //chiave esterna
        }
        valutazione[] valutazioni;
        string[] dativalutazioni = new string[]
        {
            "ITA 12/10/25","STO 12/10/25",
            "INF 13/10/25","ITA 13/10/25",
            "ING 13/10/25","STO 14/10/25",
            "INF 14/10/25","INF 14/10/25",
            "ITA 15/10/25","STO 15/10/25",
            "INF 16/10/25","ITA 17/10/25",
            "ING 17/10/25","STO 17/10/25",
            "INF 17/10/25","INF 17/10/25",
            "ITA 18/10/25","STO 18/10/25",
            "INF 18/10/25","ITA 18/10/25",
            "ING 20/10/25","STO 20/10/25",
            "INF 21/10/25","INF 21/10/25",
            "ITA 21/10/25","STO 21/10/25",
            "INF 22/10/25","ITA 24/10/25",
            "ING 24/10/25","STO 25/10/25",
            "INF 26/10/25","INF 27/10/25",
        };
        int nv; //numero valutazioni
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
                if (i == 0)
                    studenti[i].matricola = x;
                else
                    studenti[i].matricola=studenti[i-1].matricola+rnd.Next(1, 10);
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
            dgv.RowHeadersVisible=false;
            intestaTabella(dgvStudenti, c, "MATRICOLA,COGNOME,NOME,CLASSE");
        }

        private void intestaTabella(DataGridView dgv, int c, string msg)
        {
            string[] v=new string[c];
            v=msg.Split(',');
            for (int j = 0; j < c; j++)
                dgv.Columns[j].HeaderText = v[j];
        }

        private void btnOrdinaStudentiCognomeNome_Click(object sender, EventArgs e)
        {
            ordinaStudentiNominativo(studenti);
            visualTabellaStudenti(studenti, dgvStudenti);
        }

        private void visualTabellaStudenti(studente[] studenti, DataGridView dgv)
        {
            for (int i = 0; i < studenti.Length; i++)
            {
                dgv.Rows[i].Cells[0].Value = studenti[i].matricola.ToString();
                dgv.Rows[i].Cells[1].Value = studenti[i].cognome;
                dgv.Rows[i].Cells[2].Value = studenti[i].nome;
                dgv.Rows[i].Cells[3].Value = studenti[i].classe;
            }
        }

        private void ordinaStudentiNominativo(studente[] studenti)
        {
            //ordinamento per selezione
            int posmin;
            int n = studenti.Length;
            string nominativo1 = null;
            string nominativo2 = null;

            for (int i = 0; i <= n-2; i++)
            {
                posmin = i;
                for (int j = i+1; j <= n-1; j++)
                {
                    nominativo1 = studenti[posmin].cognome + studenti[posmin].nome;
                    nominativo2 = studenti[j].cognome + studenti[j].nome;
                    if (nominativo1.CompareTo(nominativo2) > 0)
                        posmin = j;
                }
                if(i!=posmin)
                    scambioRecord(ref studenti[i], ref studenti[posmin]);
            }
        }

        private void scambioRecord(ref studente studente1, ref studente studente2)
        {
            studente aus;

            aus = studente1;
            studente1 = studente2;
            studente2 = aus;
        }

        private void btnContaStudentiClasse_Click(object sender, EventArgs e)
        {
            //rottura di chiave
            ordinaStudentiClasse(studenti);
            visualTabellaStudenti(studenti,dgvStudenti);
            string classe = Interaction.InputBox("Inserisci la classe");
            MessageBox.Show("Gli studenti della classe " +
                classe + " sono in totale: " + contaStudentiClasse(studenti, classe));
        }

        private void ordinaStudentiClasse(studente[] studenti)
        {
            //ordinamento per selezione
            int posmin;
            int n = studenti.Length;

            for (int i = 0; i <= n - 2; i++)
            {
                posmin = i;
                for (int j = i + 1; j <= n - 1; j++)
                {
                    if (studenti[posmin].classe.CompareTo(studenti[j].classe) > 0)
                        posmin = j;
                }
                if (i != posmin)
                    scambioRecord(ref studenti[i], ref studenti[posmin]);
            }
        }

        private int contaStudentiClasse(studente[] studenti, string classe)
        {
            int n=studenti.Length;
            int i = 0;
            bool superato=false;
            int cont = 0;
            while (!superato && i <=n-1)
            {
                if (studenti[i].classe==classe)
                {
                    cont++;
                    i++;
                }
                else
                {
                    if (studenti[i].classe.CompareTo(classe) > 0)
                        superato=true;
                    else
                        i++;
                }
            }
            return cont;
        }

        private void btnCercaClassePiùStudenti_Click(object sender, EventArgs e)
        {
            //cercare la classe con più studenti
            ordinaStudentiClasse(studenti);
            visualTabellaStudenti(studenti, dgvStudenti);
            cercaClasseConPiùStudenti(studenti);
        }

        private void cercaClasseConPiùStudenti(studente[] studenti)
        {
            int cont = 1;
            int max = int.MinValue;
            string output = null;

            for (int i = 0; i < studenti.Length-1; i++)
            {
                if (studenti[i].classe == studenti[i + 1].classe)
                    cont++;
                else //rompo la chiave
                {
                    if(cont>max)
                    {
                        max= cont;
                        output = studenti[i].classe;
                    }
                    else
                    {
                        if (cont == max)
                            output = output + " " + studenti[i].classe;
                    }
                    cont=1;
                }
            }
            if (cont > max)
            {
                max = cont;
                output = studenti[studenti.Length - 1].classe;
            }
            else
            {
                if (cont == max)
                    output = output + " " + studenti[studenti.Length-1].classe;
            }
            MessageBox.Show($"La classe {output} ha {max.ToString()} studenti");
        }

        private void btnRicercaBinariaMatricola_Click(object sender, EventArgs e)
        {
            ordinaStudentiMatricola(studenti);
            visualTabellaStudenti(studenti,dgvStudenti);
            int matr = Convert.ToInt32(Interaction.InputBox("Inserisci la matricola"));
            ricercaBinariaMatricola(studenti, matr);
        }

        private void ricercaBinariaMatricola(studente[] studenti, int matr)
        {
            int sup = 0;
            int n=studenti.Length;
            int inf = n - 1;
            int metà;

            do
            {
                metà = inf + sup / 2;
                if (studenti[metà].matricola != matr)
                {
                    if (studenti[metà].matricola > matr)
                        inf = metà - 1;
                    else
                        sup = metà + 1;
                }
            }
            while (studenti[metà].matricola != matr && sup <= inf);
            if (studenti[metà].matricola == matr)
                MessageBox.Show(studenti[metà].cognome + "-" +
                    studenti[metà].nome);
            else
                MessageBox.Show("Studente non trovato");
        }

        private void ordinaStudentiMatricola(studente[] studenti)
        {
            //ordinamento per selezione
            int posmin;
            int n = studenti.Length;

            for (int i = 0; i <= n - 2; i++)
            {
                posmin = i;
                for (int j = i + 1; j <= n - 1; j++)
                {
                    if (studenti[posmin].matricola>studenti[j].matricola) 
                        posmin = j;
                }
                if (i != posmin)
                    scambioRecord(ref studenti[i], ref studenti[posmin]);
            }
        }

        private void btnCaricaValutazioni_Click(object sender, EventArgs e)
        {
            if (!(int.TryParse(Interaction.InputBox("Inserisci il numero di valutazioni:"), out nv) && nv > 0))
            {
                MessageBox.Show("Inserisci un valore positivo");
            }
            valutazioni = new valutazione[nv];
            settaDgv(dgvValutazioni, nv, 4);
            caricaTabellaValutazioni(valutazioni, dativalutazioni);
        }

        private void caricaTabellaValutazioni(valutazione[] valutazioni, string[] dati)
        {
            Random rnd = new Random();
            string[] dato = new string[2];
            for (int i = 0; i < studenti.Length; i++)
            {
                dato = dati[i].Split(' ');
                valutazioni[i].materia = dato[0];
                valutazioni[i].voto = rnd.Next(3,10);
                //Garantisco integrità referenziale
                valutazioni[i].matricola = cercaChiaveEsterna(studenti);
                scriviSuDgv(dgvStudenti, studenti[i], i);
            }
        }

        private int cercaChiaveEsterna(studente[] studenti)
        {
            Random rnd = new Random();
            return studenti[rnd.Next(0, studenti.Length)].matricola;
        }
    }
}
