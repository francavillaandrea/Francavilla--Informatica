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
            clsMedia.caricaMedia(dgvMedia);
            btnSalvaSocio.Visible = false;
            btnAnnullaSocio.Visible = false;
            btnSalvaMedia.Visible = false;
            btnAnnullaMedia.Visible = false;
            popolaCmbTipo(cmbTipo);
            popolaCmbGenere(cmbGenere);
            clsSoci.caricaSoci(dgvSoci);
            clsMedia.caricaMedia(dgvMedia);
        }

        private void popolaCmbGenere(ComboBox cmb)
        {
            clsMedia.ordinaMediaGenere();
            caricaCmbGenere(cmb);
        }

        private void caricaCmbGenere(ComboBox cmb)
        {
            cmb.Items.Clear();
            for (int i = 0; i < clsMedia.nMedia - 1; i++)
                if (clsMedia.medias[i].genere != clsMedia.medias[i + 1].genere)
                    cmb.Items.Add(clsMedia.medias[i].genere);
            cmb.Items.Add(clsMedia.medias[clsMedia.nMedia - 1].genere);
        }

        private void popolaCmbTipo(ComboBox cmb)
        {
            clsMedia.ordinaMediaTipo();
            caricaCmbTipo(cmb);   
        }

        private void caricaCmbTipo(ComboBox cmb)
        {
            cmb.Items.Clear();
            for (int i = 0; i < clsMedia.nMedia - 1; i++)
                if (clsMedia.medias[i].tipo != clsMedia.medias[i + 1].tipo)
                    cmb.Items.Add(clsMedia.medias[i].tipo);
            cmb.Items.Add(clsMedia.medias[clsMedia.nMedia-1].tipo);
        }

        public static void settaDgv(DataGridView dgv, string intesta)
        {
            string[] dati = intesta.Split(',');
            dgv.ColumnCount = dati.Length;
            dgv.RowHeadersVisible = false;
            dgv.ScrollBars = ScrollBars.Vertical;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            for (int i = 0; i < dati.Length; i++)
                dgv.Columns[i].HeaderText = dati[i];

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
            btnSalvaSocio.Visible=false;
            btnAnnullaSocio.Visible=false;
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

        private void btnModificaSocio_Click(object sender, EventArgs e)
        {
            int indice = dgvSoci.CurrentCell.RowIndex;
            txtCognome.Text = clsSoci.soci[indice].cognome;
            txtNome.Text = clsSoci.soci[indice].nome;
            txtEmail.Text = clsSoci.soci[indice].email;
            txtTelefono.Text = clsSoci.soci[indice].telefono;
            btnSalvaSocio.Visible=true;
            btnAnnullaSocio.Visible=true;
        }

        private void btnSalvaSocio_Click(object sender, EventArgs e)
        {
            if (txtCognome.Text != "" &&
               txtNome.Text != "" &&
               txtEmail.Text != "" &&
               txtTelefono.Text != "")
            {
                clsSoci.modificaSocio(txtCognome.Text,
                    txtNome.Text, 
                    txtEmail.Text,
                    txtTelefono.Text, 
                    dgvSoci.CurrentCell.RowIndex,
                    dgvSoci);
                resetCampiSocio();
            }
            else
                MessageBox.Show("Compilare tutti i campi",
                    "ATTENZIONE", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
        }

        private void btnAnnullaSocio_Click(object sender, EventArgs e)
        {
            resetCampiSocio();
        }

        private void btnInserisciMedia_Click(object sender, EventArgs e)
        {
            if (txtTitolo.Text != "" &&
                txtAutore.Text != "" &&
                cmbTipo.Text != "" &&
                cmbGenere.Text != "")
            {
                clsMedia.inserisciMedia(txtTitolo.Text,
                    txtAutore.Text, cmbTipo.Text,
                    cmbGenere.Text, dgvMedia);
                resetCampiMedia();
            }
            else
                MessageBox.Show("Compilare tutti i campi",
                    "ATTENZIONE", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
        }

        private void resetCampiMedia()
        {
            txtTitolo.Text = "";
            txtAutore.Text = "";
            cmbTipo.Text = "";
            cmbGenere.Text = "";
            btnSalvaMedia.Visible = false;
            btnAnnullaMedia.Visible = false;
        }
    }
}
