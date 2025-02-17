using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RISO_17022025
{
    public partial class FrmRiso : Form
    {
        static Random rnd = new Random();
        int tent = 0;
        int[] combinazione = new int[4];
        int[] combUtente = new int[4];
        public FrmRiso()
        {
            InitializeComponent();
            InitializeDGV();
        }

        private void InitializeDGV()
        {
            dgv.RowCount = 5;
            dgv.ColumnCount = 4;

            for (int i = 0; i < 4; i++)
            {
                dgv.Columns[i].Width = 79;
            }

            dgv.Height = 79 * 5 + 3; 
        }

        private void btnGioca_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < 4; i++) 
            {
                combinazione[i] = rnd.Next(1, 5);
            }

            MessageBox.Show($"{combinazione[0]}\n{combinazione[1]}\n{combinazione[2]}\n{combinazione[3]}");

            btnMain1.Enabled = true;
            btnMain2.Enabled = true;
            btnMain3.Enabled = true;
            btnMain4.Enabled = true;
            btnTest.Enabled = true;
            btnGioca.Enabled = false;
        }

        private void btnMain1_Click(object sender, EventArgs e)
        {
            if(btnMain1.Text == "5") 
            {
                btnMain1.Text = "1";
                return;
            }

            int v = Convert.ToInt32(btnMain1.Text);

            btnMain1.Text = (v + 1).ToString();
        }

        private void btnMain2_Click(object sender, EventArgs e)
        {
            if (btnMain2.Text == "5")
            {
                btnMain2.Text = "1";
                return;
            }

            int v = Convert.ToInt32(btnMain2.Text);

            btnMain2.Text = (v + 1).ToString();
        }

        private void btnMain3_Click(object sender, EventArgs e)
        {
            if (btnMain3.Text == "5")
            {
                btnMain3.Text = "1";
                return;
            }

            int v = Convert.ToInt32(btnMain3.Text);

            btnMain3.Text = (v + 1).ToString();
        }

        private void btnMain4_Click(object sender, EventArgs e)
        {
            if (btnMain4.Text == "5")
            {
                btnMain4.Text = "1";
                return;
            }

            int v = Convert.ToInt32(btnMain4.Text);

            btnMain4.Text = (v + 1).ToString();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            combUtente[0] = Convert.ToInt32(btnMain1.Text);
            combUtente[1] = Convert.ToInt32(btnMain2.Text);
            combUtente[2] = Convert.ToInt32(btnMain3.Text);
            combUtente[3] = Convert.ToInt32(btnMain4.Text);

            int r = 0;

            for (int i = 0; i < 4; i++) 
            {
                dgv.Rows[tent].Cells[i].Value = combUtente[i];

                if (combUtente[i] == combinazione[i]) 
                {
                    dgv.Rows[tent].Cells[i].Style.BackColor = Color.Green;
                    r++;
                }
                else if (combinazione.Contains(combUtente[i])) 
                {
                    dgv.Rows[tent].Cells[i].Style.BackColor = Color.Yellow;
                }
                else 
                {
                    dgv.Rows[tent].Cells[i].Style.BackColor = Color.Red;
                }
            }

            if(r == 4) 
            {
                MessageBox.Show("Hai vinto!");
                ResetGame();
                return;
            }

            tent++;

            if(tent == 5) 
            {
                MessageBox.Show($"Tentativi esauriti, la combinazione era: {combinazione[0]} {combinazione[1]} {combinazione[2]} {combinazione[3]}");
                ResetGame();
                return;
            }
        }

        private void ResetGame()
        {
            tent = 0;
            btnGioca.Enabled = true;
            dgv.Rows.Clear();
            InitializeDGV();
            btnMain1.Text = "1";
            btnMain2.Text = "1";
            btnMain3.Text = "1";
            btnMain4.Text = "1";
            btnMain1.Enabled = false;
            btnMain2.Enabled = false;
            btnMain3.Enabled = false;
            btnMain4.Enabled = false;
            btnTest.Enabled = false;
            dgv.ClearSelection();
        }

        private void FrmRiso_Load(object sender, EventArgs e)
        {
            dgv.ClearSelection();
        }
    }
}
