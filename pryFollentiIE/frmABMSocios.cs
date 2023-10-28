using System;
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
    public partial class frmABMSocios : Form
    {
        public frmABMSocios()
        {
            InitializeComponent();
            KeyPreview = true;
            this.KeyDown += CerrarFrm_KeyDown;
        }

        AccesoDatos objBD;
        int varID;


        public static void CerrarFrm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Application.Exit(); // Cierra la aplicación completa
            }
        }
        private void abmSocios_Load(object sender, EventArgs e)
        {
            objBD = new AccesoDatos();
            objBD.ConectarBD();
            objBD.traerDatos(dgvMostrar);
        }
        private void btnBuscarId_Click(object sender, EventArgs e)
        {
            
            objBD.BuscarPorId(txtID.Text, dgvMostrar);
        }

        private void btnCerrarApp_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void btnMinimizarApp_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmPrincipal frmPrincipal = new frmPrincipal();
            this.Hide();
            frmPrincipal.Show();
        }
    }

}
