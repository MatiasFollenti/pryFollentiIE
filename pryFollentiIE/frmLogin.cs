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
    public partial class frmLogin : Form
    {
        
        string varUserIng;
        string varPasswordIng;
        AccesoDatos objAccesoDatos;
        clsLog objLog;
        DateTime varFecha;
        string varAccion;

        public frmLogin()
        {
            InitializeComponent();
            KeyPreview = true;
            this.KeyDown += CerrarFrm_KeyDown;
            objAccesoDatos = new AccesoDatos();
        }

        public static void CerrarFrm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Application.Exit(); // Cierra la aplicación completa
            }
        }

        private void btnCerrarApp_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void btnMinimizarApp_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
            txtContraseña.UseSystemPasswordChar = true;
        }
      
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            varUserIng = txtUsuario.Text;
            varPasswordIng = txtContraseña.Text;
            varFecha = DateTime.Now;
            varAccion = "Inicio Sesion";
            objAccesoDatos.ConectarBD();
            objAccesoDatos.ValidarUsuario(varUserIng,varPasswordIng,this);
            objLog = new clsLog();
            objLog.CargarLog(varUserIng,varFecha,varAccion);

        }

        private void txtContraseña_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter) && e.KeyChar == 13)
            {
                btnIngresar_Click(sender, e);
                e.Handled = true;
            }
        }

        private void txtUsuario_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter) && e.KeyChar == 13)
            {
                txtContraseña.Focus();
                e.Handled = true;
            }
        }
    }
}
