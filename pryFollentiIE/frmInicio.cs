﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryFollentiIE
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
            KeyPreview = true;
            this.KeyDown += CerrarFrm_KeyDown;
        }

        public static void CerrarFrm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Application.Exit(); // Cierra la aplicación completa
            }
        }
        private void progressBarLogo_Click(object sender, EventArgs e)
        {

        }
       
        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBarLogo.Increment(5);

            if (progressBarLogo.Value <100)
            {
                progressBarLogo.Value++;
            }

            if (progressBarLogo.Value==100)
            {
                timer1.Enabled = false;
                frmPrincipal frmPrincipal = new frmPrincipal();
                this.Hide();
                frmPrincipal.Show();
            }
        }
    }
}
