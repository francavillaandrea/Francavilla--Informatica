using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Francavilla17022025
{
    public partial class FrmFrancavilla : Form
    {
        int r = 5;
        int c = 4;
        bool gioca = false;
        int[] combinazione = { 1, 3, 2, 2 };
        int[] combUtente = new int[4];
        static Random rnd = new Random();
        int cont1 = 0;
        int cont2 = 0;
        int cont3 = 0;
        int cont4 = 0;
        int k = 0;
        int l = 0;
        int tent = 0;

        public FrmFrancavilla()
        {
            InitializeComponent();
            settadgv1();
            btn1.Visible = false;
            btn2.Visible = false;
            btn3.Visible = false;
            btn4.Visible = false;
            btnVerifica.Visible = false;

        }

        private void settadgv1()
        {
            dgv1.RowCount = r;
            dgv1.ColumnCount = c;
            dgv1.RowHeadersVisible = false;
            dgv1.ColumnHeadersVisible = false;
            dgv1.AutoResizeColumns();
            dgv1.AutoResizeRows();
            dgv1.ReadOnly = true;
            dgv1.Enabled = false;
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    dgv1.Rows[i].Height = 50;
                    dgv1.Columns[j].Width = 50;

                }
            }

        }

        private void btnGioca_Click(object sender, EventArgs e)
        {
            gioca = true;
            dgv1.Enabled = true;
            btn1.Visible = true;
            btn2.Visible = true;
            btn3.Visible = true;
            btn4.Visible = true;
            btnVerifica.Visible = true;
            MessageBox.Show("Gioco iniziato, inserisci una combinazione");
            inserisciCombinazione();


        }

        private void inserisciCombinazione()
        {
            for (int i = 0; i < 4; i++)
            {
                combinazione[i] = rnd.Next(1, 6);
            }
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            if (!gioca)
            {
                MessageBox.Show("Inizia il gioco prima");
                cont1 = 0;
                btn1.Text = cont1.ToString();
            }
            else if (cont1 >= 5)
            {
                MessageBox.Show("Impossibile aumentare il numero");
                cont1 = 1;
                btn1.Text = cont1.ToString();

            }
            else
            {
                cont1++;
                btn1.Text = cont1.ToString();
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (!gioca)
            {
                MessageBox.Show("Inizia il gioco prima");
                cont2 = 0;
                btn2.Text = cont2.ToString();
            }
            else if (cont2 >= 5)
            {
                MessageBox.Show("Impossibile aumentare il numero");
                cont2 = 1;
                btn2.Text = cont2.ToString();

            }
            else
            {
                cont2++;
                btn2.Text = cont2.ToString();
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (!gioca)
            {
                MessageBox.Show("Inizia il gioco prima");
                cont3 = 0;
                btn3.Text = cont3.ToString();
            }
            else if (cont3 >= 5)
            {
                MessageBox.Show("Impossibile aumentare il numero");
                cont3 = 1;
                btn3.Text = cont3.ToString();

            }
            else
            {
                cont3++;
                btn3.Text = cont3.ToString();
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (!gioca)
            {

                MessageBox.Show("Inizia il gioco prima");
                cont4 = 0;
                btn4.Text = cont4.ToString();
            }
            else if (cont4 >= 5)
            {
                MessageBox.Show("Impossibile aumentare il numero");
                cont4 = 1;
                btn4.Text = cont4.ToString();

            }
            else
            {
                cont4++;
                btn4.Text = cont4.ToString();
            }
        }
        private void btnVerifica_Click(object sender, EventArgs e)
        {
            if (btn1.Text == "0" || btn2.Text == "0" || btn3.Text == "0" || btn4.Text == "0")
            {
                MessageBox.Show("Inserisci la combinazione");
            }
            else
            {
                combUtente[0] = Convert.ToInt32(btn1.Text);
                combUtente[1] = Convert.ToInt32(btn2.Text);
                combUtente[2] = Convert.ToInt32(btn3.Text);
                combUtente[3] = Convert.ToInt32(btn4.Text);

                int r = 0;

                for (int i = 0; i < 4; i++)
                {
                    dgv1.Rows[tent].Cells[i].Value = combUtente[i];

                    if (combUtente[i] == combinazione[i])
                    {
                        dgv1.Rows[tent].Cells[i].Style.BackColor = Color.Green;
                        r++;
                    }
                    else
                    {
                        dgv1.Rows[tent].Cells[i].Style.BackColor = Color.Red;
                    }
                }

                if (r == 4)
                {
                    MessageBox.Show("Hai vinto!");
                    rigioca();
                    return;
                }

                tent++;

                if (tent == 5)
                {
                    for(int i = 0;i< 4; i++)
                    {
                        MessageBox.Show("Tentativi esauriti, la combinazione era:" + combinazione[i]);
                    }
                    rigioca();
                    return;
                }

            }

        }
        private void rigioca()
        {
            tent = 0;
            btnGioca.Enabled = true;
            dgv1.Rows.Clear();
            settadgv1();
            btn1.Text = "0";
            btn2.Text = "0";
            btn3.Text = "0";
            btn4.Text = "0";
            btn1.Enabled = false;
            btn2.Enabled = false;
            btn3.Enabled = false;
            btn4.Enabled = false;
            btnVerifica.Enabled = false;
            dgv1.ClearSelection();
        }

        private void lblTitolo_Click(object sender, EventArgs e)
        {

        }
    }
    }
