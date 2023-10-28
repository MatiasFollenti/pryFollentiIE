using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace pryFollentiIE
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
            KeyPreview = true;
            this.KeyDown += CerrarFrm_KeyDown;
        }

        AccesoDatos objBaseDatos;

        public static void CerrarFrm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Application.Exit(); // Cierra la aplicación completa
            }
        }
        private void btnMinimizarApp_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized; 
        }

        private void btnCerrarApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pctBuscar_Click(object sender, EventArgs e)
        {
            frmBuscador frmBuscador = new frmBuscador();
            this.Hide();
            frmBuscador.Show();
        }

        private void pctAgregar_Click(object sender, EventArgs e)
        {
            frmAgregar frmAgregar = new frmAgregar();   
            this.Hide();
            frmAgregar.Show();
        }

        private void pctEditar_Click(object sender, EventArgs e)
        {
            frmABM frmEditar = new frmABM();
            this.Hide();
            frmEditar.Show();
        }

        private void pctEliminar_Click(object sender, EventArgs e)
        {
            frmEliminar frmEliminar = new frmEliminar();
            this.Hide();
            frmEliminar.Show();
        }

        private void timerHora_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            objBaseDatos = new AccesoDatos();
            objBaseDatos.ConectarBD();

            lblStatus.Text = objBaseDatos.estadoDeConexion;

            lblStatus.BackColor = Color.Green;
            lblStatus.ForeColor = Color.White;
        }

       
    }

   

    
}
