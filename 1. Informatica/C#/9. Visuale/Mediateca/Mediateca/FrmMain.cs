using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mediateca
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            clsSoci.caricaSoci(dgvSoci);
        }

        private void btnInserisciSocio_Click(object sender, EventArgs e)
        {
            if(txtCognome.Text!="" &&
                txtNome.Text!="" &&
                txtEmail.Text!="" &&
                txtTelefono.Text!="")
            {
                clsSoci.inserisciSocio(txtCognome.Text,
                    txtNome.Text, txtEmail.Text,
                    txtTelefono.Text, dgvSoci);
                resetCampiSocio();
            }
            else
                MessageBox.Show("Compilare tutti i campi",
                    "ATTENZIONE",MessageBoxButtons.OK, 
                    MessageBoxIcon.Exclamation);
        }

        private void resetCampiSocio()
        {
            txtCognome.Text = "";
            txtNome.Text = "";
            txtEmail.Text = "";
            txtTelefono.Text = "";

        }

        private void btnCancellaSocio_Click(object sender, EventArgs e)
        {
            //seleziono sulla DGV il socio da cancellare
            if (MessageBox.Show("Confermi la cancellazione?",
                "ATTENZIONE",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) ==
                DialogResult.Yes)
            {
                int indice = dgvSoci.CurrentCell.RowIndex;
                clsSoci.cancellaSocio(indice,dgvSoci);
            }
        }
    }
}
