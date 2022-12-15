using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SelectionEquipe_Dev
{
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
        }

        private void btnGCoachJoueur_Click(object sender, EventArgs e)
        {
            GestionCoachsJoueurs gcj = new GestionCoachsJoueurs();
            gcj.ShowDialog();
        }

        private void btnGEquipe_Click(object sender, EventArgs e)
        {
            GestionEquipes ge = new GestionEquipes();
            ge.ShowDialog();
        }

        private void btnGSport_Click(object sender, EventArgs e)
        {
            GestionSports gs = new GestionSports();
            gs.ShowDialog();
        }
    }
}
