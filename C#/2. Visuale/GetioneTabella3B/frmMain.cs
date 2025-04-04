﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;
using static GetioneTabella3B.frmMain;

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
            public string data;
            public int matricola; //chiave esterna
        }
        valutazione[] valutazioni;
        string[] datiValutazioni = new string[]
        {
            "ITA 12/10/25","STO 12/10/25",
            "INF 13/10/25","ITA 13/10/25",
            "ING 13/10/25","STO 14/10/25",
            "INF 14/10/25","INF 14/10/25",
            "ITA 15/10/25","STO 15/10/25",
            "INF 16/10/25","STO 17/10/25",
            "ING 17/10/25","STO 17/10/25",
            "INF 17/10/25","INF 17/10/25",
            "ITA 18/10/25","STO 18/10/25",
            "INF 18/10/25","STO 18/10/25",
            "ING 20/10/25","STO 20/10/25",
            "INF 21/10/25","INF 21/10/25",
            "ITA 21/10/25","STO 21/10/25",
            "INF 22/10/25","ITA 24/10/25",
            "ING 24/10/25","STO 25/10/25",
            "INF 26/10/25","INF 27/10/25",
        };
        int nv; //numero valutazioni
        int rigaStudente=-1;
        public frmMain()
        {
            InitializeComponent();
        }
        private void btnCaricaTabellaStudenti_Click(object sender, EventArgs e)
        {
            if (!(int.TryParse(Interaction.InputBox("Inserisci il numero di studenti:","INPUT","30"), out ns) && ns > 0))
                MessageBox.Show("Devi inserire un valore positivo");
            studenti = new studente[ns];
            settaDgv(dgvStudenti, ns, 4, "MATRICOLA,COGNOME,NOME,CLASSE");
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
                scriviSuDgvStudenti(dgvStudenti, studenti[i], i);
            }
        }

        private void scriviSuDgvStudenti(DataGridView dgv, studente studente, int i)
        {
            dgv.Rows[i].Cells[0].Value = studente.matricola.ToString();
            dgv.Rows[i].Cells[1].Value = studente.cognome;
            dgv.Rows[i].Cells[2].Value = studente.nome;
            dgv.Rows[i].Cells[3].Value = studente.classe;
            dgv.AutoResizeColumns();
            dgv.AutoResizeRows();
        }
        private void settaDgv(DataGridView dgv, int r, int c, string intesta)
        {
            dgv.RowCount = r;
            dgv.ColumnCount = c;
            dgv.ClearSelection();
            dgv.RowHeadersVisible=false;
            intestaTabella(dgv, c, intesta);
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
            if (!(int.TryParse(Interaction.InputBox("Inserisci il numero di valutazioni:","INPUT","32"), out nv) && nv > 0))
                MessageBox.Show("Devi inserire un valore positivo");
            valutazioni = new valutazione[nv];
            settaDgv(dgvValutazioni, nv, 4, "MATERIA,VOTO,DATA,MATRICOLA");
            caricaTabellaValutazioni(valutazioni, datiValutazioni);
            popolaCmbMaterieDinamica(valutazioni, cmbMaterieDinamica);
            popolaCmbMatricoleDinamica(valutazioni, cmbMatricole);
        }

        private void popolaCmbMatricoleDinamica(valutazione[] valutazioni, ComboBox cmbMatricole)
        {
            ordinaValutazioniMatricola(valutazioni);
            popolaCmbMatricole(valutazioni, cmbMatricole);
        }

        private void popolaCmbMatricole(valutazione[] valutazioni, ComboBox cmb)
        {
            //popolo dinamicamente la combobox!!!
            cmb.Items.Clear();
            for (int i = 0; i < valutazioni.Length - 1; i++)
                if (valutazioni[i].matricola != valutazioni[i + 1].matricola)
                    cmb.Items.Add(valutazioni[i].matricola);
            cmb.Items.Add(valutazioni[valutazioni.Length - 1].matricola);
        }

        private void popolaCmbMaterieDinamica(valutazione[] valutazioni, ComboBox cmbMaterieDinamica)
        {
            ordinaValutazioniMaterie(valutazioni);
            //visualTabellaValutazioni(valutazioni, dgvValutazioni);
            popolaCmbMaterie(valutazioni, cmbMaterieDinamica);
        }

        private void popolaCmbMaterie(valutazione[] valutazioni, ComboBox cmb)
        {
            //popolo dinamicamente la combobox!!!
            cmb.Items.Clear();
            for (int i = 0; i < valutazioni.Length-1; i++)
                if (valutazioni[i].materia != valutazioni[i+1].materia)
                    cmb.Items.Add(valutazioni[i].materia);
            cmb.Items.Add(valutazioni[valutazioni.Length-1].materia);
        }

        private void visualTabellaValutazioni(valutazione[] valutazioni, DataGridView dgv)
        {
            for (int i = 0; i < valutazioni.Length; i++)
            {
                dgv.Rows[i].Cells[0].Value = valutazioni[i].materia;
                dgv.Rows[i].Cells[1].Value = valutazioni[i].voto.ToString();
                dgv.Rows[i].Cells[2].Value = valutazioni[i].data;
                dgv.Rows[i].Cells[3].Value = valutazioni[i].matricola;
            }
        }

        private void ordinaValutazioniMaterie(valutazione[] valutazioni)
        {
            //ordinamento per selezione
            int posmin;
            int n = valutazioni.Length;

            for (int i = 0; i <= n - 2; i++)
            {
                posmin = i;
                for (int j = i + 1; j <= n - 1; j++)
                {
                    if (valutazioni[posmin].materia.CompareTo(valutazioni[j].materia) > 0)
                        posmin = j;
                }
                if (i != posmin)
                    scambioRecordValutazioni(ref valutazioni[i], ref valutazioni[posmin]);
            }
        }

        private void scambioRecordValutazioni(ref valutazione valutazione1, ref valutazione valutazione2)
        {
            valutazione aus;

            aus = valutazione1;
            valutazione1 = valutazione2;
            valutazione2 = aus;
        }

        private void caricaTabellaValutazioni(valutazione[] valutazioni, string[] dati)
        {
            Random rnd = new Random();
            string[] dato = new string[2];
            for (int i = 0; i < valutazioni.Length; i++)
            {
                dato = dati[i].Split(' ');
                valutazioni[i].materia = dato[0];
                valutazioni[i].voto = rnd.Next(2, 6);
                valutazioni[i].data = dato[1];
                //garantisco integrità referenziale!!!
                valutazioni[i].matricola = cercaChiaveEsterna(studenti);
                scriviSuDgvValutazioni(dgvValutazioni, valutazioni[i], i);
            }
        }

        private void scriviSuDgvValutazioni(DataGridView dgv, valutazione valutazione, int i)
        {
            dgv.Rows[i].Cells[0].Value = valutazione.materia;
            dgv.Rows[i].Cells[1].Value = valutazione.voto.ToString();
            dgv.Rows[i].Cells[2].Value = valutazione.data;
            dgv.Rows[i].Cells[3].Value = valutazione.matricola.ToString();
            dgv.AutoResizeColumns();
            dgv.AutoResizeRows();
        }

        private int cercaChiaveEsterna(studente[] studenti)
        {
            

            return studenti[rnd.Next(0, studenti.Length)].matricola;
        }

        private void btnCalcolaMediaValutazioniMateria_Click(object sender, EventArgs e)
        {
            string materia=cmbMaterieStatica.Text;
            MessageBox.Show($"la media dei voti di {materia} è: " +
                $"{calcolaMediaValutazioniMateria(valutazioni, materia).ToString("F2")}");
        }

        private double calcolaMediaValutazioniMateria(valutazione[] valutazioni, string materia)
        {
            //ric.seq. NON ottimizzata
            double somma = 0;
            int cont = 0;

            for (int i = 0; i < valutazioni.Length; i++)
                if (valutazioni[i].materia == materia)
                {
                    somma += valutazioni[i].voto;
                    cont++;
                }      
            return somma / cont;
        }

        private void btnMediaValutazioniMateria_Click(object sender, EventArgs e)
        {
            //rottura di chiave
            string materia=cmbMaterieDinamica.Text;
            MessageBox.Show($"La media dei voti di {materia} è: " +
               $"{calcolaMediaValutazioniMateriaOttimizzata(valutazioni, materia).ToString("F2")}");
        }

        private double calcolaMediaValutazioniMateriaOttimizzata(valutazione[] valutazioni, string materia)
        {
            int i = 0;
            bool superato = false;
            int cont = 0;
            double somma = 0;
            while (!superato && i<= valutazioni.Length-1)
            {
                if (valutazioni[i].materia==materia)
                {
                    somma += valutazioni[i].voto;
                    cont++;
                    i++;
                }
                else
                {
                    if (valutazioni[i].materia.CompareTo(materia) > 0)
                        superato = true;
                    else
                        i++;
                }
            }
            if (cont == 0)
                return 0;
            else
                return somma/ cont;
        }

        private void btnCercaMateriaPiùVoti_Click(object sender, EventArgs e)
        {
            ordinaValutazioniMaterie(valutazioni);
            //visualTabellaValutazioni(valutazioni,dgvValutazioni);
            cercaMateriaPiùVoti(valutazioni);
        }

        private void cercaMateriaPiùVoti(valutazione[] valutazioni)
        {
            int cont = 1;
            int max = int.MinValue;
            string maxMateria = "";

            for (int i = 0; i < valutazioni.Length-1; i++)
            {
                if (valutazioni[i].materia == valutazioni[i + 1].materia)
                    cont++;
                else //rotta la chiave
                {
                    if(cont>max)
                    {
                        max = cont;
                        maxMateria = valutazioni[i].materia;
                    }
                    else
                    {
                        if (cont == max)
                            maxMateria += " " + valutazioni[i].materia;
                    }
                    cont = 1;
                }
            }
            if (cont > max)
            {
                max = cont;
                maxMateria = valutazioni[valutazioni.Length-1].materia;
            }
            else
            {
                if (cont == max)
                    maxMateria += " " + valutazioni[valutazioni.Length - 1].materia;
            }
            MessageBox.Show($"La materia {maxMateria} ha {max} valutazioni");
        }

        private void btnCalcolaMediaStudente_Click(object sender, EventArgs e)
        {
            string cognome = Interaction.InputBox("Inserisci il cognome dello studente", "INPUT");
            string nome = Interaction.InputBox("Inserisci il nome dello studente", "INPUT");
            int matricola = cercaMatricola(studenti, cognome, nome);
            if (matricola == 0)
                MessageBox.Show("Studente non trovato", "ERRORE");
            else
                calcolaMediaVoti(valutazioni, matricola);
        }

        private void calcolaMediaVoti(valutazione[] valutazioni, int matricola)
        {
            ordinaValutazioniMatricola(valutazioni);
            //visualTabellaValutazioni(valutazioni, dgvValutazioni);
            double media=calcolaMedia(valutazioni, matricola);
            if (media == 0)
                MessageBox.Show("Lo studente non ha valutazioni");
            else
                MessageBox.Show("La media dei voti è: "+ media.ToString("F2"));
        }

        private double calcolaMedia(valutazione[] valutazioni, int matricola)
        {
            int i = 0;
            bool superato = false;
            int cont = 0;
            double somma = 0;
            while (!superato && i <= valutazioni.Length - 1)
            {
                if (valutazioni[i].matricola == matricola)
                {
                    somma += valutazioni[i].voto;
                    cont++;
                    i++;
                }
                else
                {
                    if (valutazioni[i].matricola > matricola)
                        superato = true;
                    else
                        i++;
                }
            }
            if (cont == 0)
                return 0;
            else
                return somma / cont;
        }

        private void ordinaValutazioniMatricola(valutazione[] valutazioni)
        {
            //ordinamento per selezione
            int posmin;
            int n = valutazioni.Length;

            for (int i = 0; i <= n - 2; i++)
            {
                posmin = i;
                for (int j = i + 1; j <= n - 1; j++)
                {
                    if (valutazioni[posmin].matricola > valutazioni[j].matricola)
                        posmin = j;
                }
                if (i != posmin)
                    scambioRecordValutazioni(ref valutazioni[i], ref valutazioni[posmin]);
            }
        }

        private int cercaMatricola(studente[] studenti, string cognome, string nome)
        {
            //suppongo no omonimie
            int i=0;

            while (studenti[i].cognome != cognome ||
                studenti[i].nome != nome &&
                i != studenti.Length - 1)
                i++;
            if (studenti[i].cognome == cognome &&
                studenti[i].nome == nome)
                return studenti[i].matricola;
            else
                return 0;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            btnCaricaTabellaStudenti_Click(sender, e);
            popolaCmbClassi(cmbClassi);
            btnCaricaValutazioni_Click(sender, e);
            popolaCmbClassiDinamica(studenti, cmbClassiQuery);
        }

        private void popolaCmbClassi(ComboBox cmb)
        {
            //carico dinamicamente
            ordinaStudentiClasse(studenti);
            popolaCmbClassiDinamica(studenti, cmb);
        }

        private void popolaCmbClassiDinamica(studente[] studenti, ComboBox cmb)
        {
            cmb.Items.Clear();
            for (int i = 0; i < studenti.Length - 1; i++)
                if (studenti[i].classe != studenti[i + 1].classe)
                    cmb.Items.Add(studenti[i].classe);
            cmb.Items.Add(studenti[studenti.Length - 1].classe);
        }

        private void btnCalcolaMediaStudenteCombo_Click(object sender, EventArgs e)
        {
            int matricola = Convert.ToInt32(cmbMatricole.Text);
            calcolaMediaVoti(valutazioni, matricola);
        }

        private void dgvStudenti_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rigaStudente=e.RowIndex;
        }

        private void btnCalcolaMediaStudenteClic_Click(object sender, EventArgs e)
        {
            if (rigaStudente == -1)
                MessageBox.Show("Devi selezionare uno studente", "ERRORE");
            else
                calcolaMediaVoti(valutazioni, studenti[rigaStudente].matricola);
        }

        private void btnInserisciStudente_Click(object sender, EventArgs e)
        {
            if (txtCognomeStudente.Text == "")
                MessageBox.Show("Devi inserire il cognome!");
            else
                if (txtNomeStudente.Text == "")
                MessageBox.Show("Devi inserire il nome!");
            else
                    if (cmbClassi.Text == "")
                MessageBox.Show("Devi inserire la classe!");
            else
            {
                caricaNuovoStudente(ref studenti);
                btnCaricaValutazioni_Click(sender, e);
            }
        }

        private void caricaNuovoStudente(ref studente[] studenti)
        {
            Array.Resize(ref studenti, studenti.Length + 1);
            Array.Resize(ref datiStudenti, datiStudenti.Length + 1);
            string studente = txtCognomeStudente.Text + " " + txtNomeStudente.Text + " " + cmbClassi.Text;
            ns++;
            datiStudenti[ns - 1] = studente;
            settaDgv(dgvStudenti, ns, 4, "MATRICOLA,COGNOME,NOME,CLASSE");
            caricaTabellaStudenti(studenti, datiStudenti);
            visualTabellaStudenti(studenti, dgvStudenti);
        }

     

        private void btnCalcolaMediaClasse_Click_1(object sender, EventArgs e)
        {
            
            string classe=cmbClassiQuery.Text;
            double media = calcolaMediaClasse(studenti, valutazioni, classe);
            MessageBox.Show(media.ToString("F2"));
        }

        private double calcolaMediaClasse(studente[] studenti, valutazione[] valutazioni, string classe)
        {
            ordinaStudentiClasse(studenti);
            ordinaValutazioniMatricola(valutazioni);
            int n = studenti.Length;
            int i = 0;
            bool superato = false;
            double sommaVoti = 0;
            int contVoti = 0;
            while (!superato && i <= n - 1)
            {
                if (studenti[i].classe == classe)
                {
                    sommaVoti += sommaVotiStudente(valutazioni, studenti[i].matricola, ref contVoti);
                    i++;
                }
                else
                {
                    if (studenti[i].classe.CompareTo(classe) > 0)
                        superato = true;
                    else
                        i++;
                }
            }
            return sommaVoti/contVoti;
        }

        private double sommaVotiStudente(valutazione[] valutazioni, int matricola, ref int contVoti)
        {
            double somma = 0;
            int n = valutazioni.Length;
            int i = 0;
            bool superato = false;
            while (!superato && i <= n - 1)
            {
                if (valutazioni[i].matricola == matricola)
                {
                    somma += valutazioni[i].voto;
                    contVoti++;
                    i++;
                }
                else
                {
                    if (valutazioni[i].matricola>matricola)
                        superato = true;
                    else
                        i++;
                }
            }
            return somma;
        }

        private void btnContaVotiTra2Date_Click(object sender, EventArgs e)
        {
            string d1=dtp1.Text;
            string d2 = dtp2.Text;
            //suppongo valutazioni già ordinate cronologicamente
            MessageBox.Show($"Le valutazioni tra {d1} e {d2} sono state {contaValutazioniTra2Date(valutazioni, d1, d2).ToString()}");
        }

        private int contaValutazioniTra2Date(valutazione[] valutazioni, string d1, string d2)
        {
            int cont = 0;
            int n = valutazioni.Length;
            int i = 0;
            bool superato = false;
            while (!superato && i <= n - 1)
            {
                if (valutazioni[i].data.CompareTo(d1) >=0 &&
                    valutazioni[i].data.CompareTo(d2) <= 0)
                {
                    cont++;
                    i++;
                }
                else
                {
                    if (valutazioni[i].data.CompareTo(d2) > 0)
                        superato = true;
                    else
                        i++;
                }
            }
            return cont;
        }

        private void btnCercaStudenteMediaMinore_Click(object sender, EventArgs e)
        {
            double media;
            double min = double.MaxValue;
            string minStudente = "";

            ordinaValutazioniMatricola(valutazioni);
            for (int i = 0; i < studenti.Length; i++)
            {
                media = calcolaMedia(valutazioni, studenti[i].matricola);
                if(media != 0)
                {
                    if (media < min)
                    {
                        min = media;
                        minStudente = studenti[i].cognome + " " +
                            studenti[i].nome + " " +
                            studenti[i].classe + "\n";
                    }
                    else
                    {
                        if(min==media)
                            minStudente += studenti[i].cognome + " " +
                           studenti[i].nome + " " +
                           studenti[i].classe+"\n";

                    }
                }  
            }
            MessageBox.Show(minStudente);
        }

        private void btnCercaStudenteMediaMinoreOtt_Click(object sender, EventArgs e)
        {
            ordinaValutazioniMatricola(valutazioni);
            double somma = 0;
            int cont = 1;
            double media=0;
            double min = double.MaxValue;
            string matrMinStudente = "";
            int contMin = 0;

            for (int i = 0; i < valutazioni.Length-1; i++)
            {
                if (valutazioni[i].matricola == valutazioni[i+1].matricola)
                {
                    somma += valutazioni[i].voto;
                    cont++;
                }
                else //rompo la chiave
                {
                    somma += valutazioni[i].voto;
                    if(somma!=0)
                    { 
                    media = somma / cont;
                    if (media != 0)
                    {
                        if (media < min)
                        {
                            min = media;
                            matrMinStudente = valutazioni[i].matricola.ToString();
                            contMin = 1;
                        }
                        else
                        {
                            if (min == media)
                            {
                                matrMinStudente += " " + valutazioni[i].matricola.ToString();
                                contMin++;
                            }
                               
                        }
                    }
                    }
                    cont = 1;
                    somma= 0;
                }
            }
            somma += valutazioni[valutazioni.Length - 1].voto;
            media = somma / cont;
            if (media != 0)
            {
                if (media < min)
                {
                    min = media;
                    matrMinStudente = valutazioni[valutazioni.Length - 1].matricola.ToString();
                    contMin = 1;
                }
                else
                {
                    if (min == media)
                    {
                        matrMinStudente += " " + valutazioni[valutazioni.Length - 1].matricola.ToString();
                        contMin++;
                    }
                        
                }
            }
            visualizzaDatiStudente(studenti, matrMinStudente, contMin);
        }

        private void visualizzaDatiStudente(studente[] studenti, string matr, int contMin)
        {
            string nominativo = "";
            string[] v;

            if (contMin == 1)
            {
                nominativo = cercaStudenteMatricola(studenti, matr);
                MessageBox.Show(nominativo);
            }
                
            else
            {
                v=matr.Split(' ');
                for (int i = 0; i < contMin; i++)
                {
                    nominativo= cercaStudenteMatricola(studenti, v[0]);
                    MessageBox.Show(nominativo);
                }
            }
            
        }

        private string cercaStudenteMatricola(studente[] studenti, string matr)
        {
            int m = Convert.ToInt32(matr);
            int i = 0;
            while (studenti[i].matricola != m)
                i++;
            return studenti[i].cognome + " " + studenti[i].nome;
        }

        private void btnCercaStudentiTaglioni_Click(object sender, EventArgs e)
        {
            string taglioni = "";

            ordinaValutazioniMatricola(valutazioni);
            for (int i = 0; i < studenti.Length; i++)
            {
                if (calcolaMedia(valutazioni, studenti[i].matricola) == 0)
                    taglioni += studenti[i].cognome + " - " +
                        studenti[i].nome + " - " +
                        studenti[i].classe + "\n";
               }
            MessageBox.Show(taglioni);
        }

        private void btnContaVotiStudenteInsufficienti_Click(object sender, EventArgs e)
        {
            string cognome = Interaction.InputBox("Inserisci il cognome");
            string nome = Interaction.InputBox("Inserisci il nome");
            int matricola=cercaMatricola(studenti,cognome,nome);
            if (matricola == 0)
                MessageBox.Show("Studente non trovato");
            else
            {
                ordinaValutazioniMatricola(valutazioni);
                MessageBox.Show(contaVotiStudenteInsufficienti(valutazioni, matricola).ToString());
            }    
        }

        private int contaVotiStudenteInsufficienti(valutazione[] valutazioni, int matricola)
        {
            int cont = 0;
            
            int n = valutazioni.Length;
            int i = 0;
            bool superato = false;
            while (!superato && i <= n - 1)
            {
                if (valutazioni[i].matricola==matricola)
                {
                    if (valutazioni[i].voto < 6)
                        cont++;
                    i++;
                }
                else
                {
                    if (valutazioni[i].matricola > matricola)
                        superato = true;
                    else
                        i++;
                }
            }
            return cont;

        }

        private void btnCercaClassePiùInsufficienze_Click(object sender, EventArgs e)
        {
            ordinaStudentiClasse(studenti);
            scorriClassi(studenti, ref valutazioni);
        }

        private void scorriClassi(studente[] studenti, ref valutazione[] valutazioni)
        {
            ordinaValutazioniMatricola(valutazioni);
            int cont=0;
            string minClasse = "";
            int minimo = int.MaxValue;
            Array.Resize(ref valutazioni, valutazioni.Length + 1);
            valutazioni[valutazioni.Length - 1].matricola = int.MaxValue; //TAPPO

            for (int i = 0; i < studenti.Length-1; i++)
            {
                if (studenti[i].classe == studenti[i+1].classe)
                {
                    cont += contaVotiStudenteInsufficienti(valutazioni, studenti[i].matricola);
                }
                else
                {
                    cont += contaVotiStudenteInsufficienti(valutazioni, studenti[i].matricola);
                    if (cont != 0)
                    {
                        if (cont < minimo)
                        {
                            minimo = cont;
                            minClasse = studenti[i].classe + "\n";
                        }
                        else
                        {
                            if (cont == minimo)
                                minClasse += studenti[i].classe + "\n";
                        }
                    }
                    cont = 0;
                }
            }
            MessageBox.Show(minClasse+ " " + minimo.ToString())
                ;
        }
    }
}
