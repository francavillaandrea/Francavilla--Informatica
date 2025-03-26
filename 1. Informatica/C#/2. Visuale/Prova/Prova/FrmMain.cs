using System;
using System.Windows.Forms;

namespace Prova
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            lblRisultato.Text = "???";
        }

        private void btnSaluta_Click(object sender, EventArgs e)
        {
            lblRisultato.Text = "Ciao, " + txtNome.Text +" !";
        }
    }
}
