using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Esercitazione_Dinamico_Battaglia_Navale
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            this.Text = "Battaglia Navale";
            generaCampi();
        }

        private void generaCampi()
        {
            int posX = 10, posY = 10;
            Button btn;

            for (int i = 0; i < 10; i++)
            {
                for(int j = 0; j < 10; j++)
                {
                    btn = new Button();
                    btn.Text = $"{i}_{j}";
                    btn.Name = $"btn_{i}_{j}";
                    btn.Location = new Point(posX, posY);
                    posX++;
                    this.Controls.Add(btn);
                }
                posY += posX;
                posX = 10;
            }

        }
    }
}
