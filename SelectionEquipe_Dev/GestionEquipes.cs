﻿using System;
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
    public partial class GestionEquipes : Form
    {
        public GestionEquipes()
        {
            InitializeComponent();
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            GestionEquipes.ActiveForm.Close();
        }
    }
}
