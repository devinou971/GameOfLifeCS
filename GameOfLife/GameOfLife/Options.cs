using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameOfLife
{
    public partial class Options : Form
    {
        public Options()
        {
            InitializeComponent();
        }

        private void Options_Load(object sender, EventArgs e)
        {
        }

        private void pCouleurFond_Click(object sender, EventArgs e)
        {
            if (couleurFond.ShowDialog() == DialogResult.OK)
                pCouleurFond.BackColor = couleurFond.Color;
        }

        private void pCouleurGrille_Click(object sender, EventArgs e)
        {
            if (couleurGrille.ShowDialog() == DialogResult.OK)
            {
                pCouleurGrille.BackColor = couleurGrille.Color;
            }
                
                //pCouleurGrille.BackColor = Color.;
        }

        private void pCouleurCellules_Click(object sender, EventArgs e)
        {
            if (couleurCellules.ShowDialog() == DialogResult.OK)
                pCouleurCellules.BackColor = couleurCellules.Color;
        }
    }
}
