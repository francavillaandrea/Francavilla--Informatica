using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _Prova
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
            lblRisultato.Text = "Ciao, " + txtNome.Text + "!!!";
        }
    }
}
