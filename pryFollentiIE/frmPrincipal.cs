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

        
        
       
       

        AccesoDatos objBaseDatos;
        string nombre;
        clsLog ObjLog;
        string categoria;

        public frmPrincipal( string varNombre, string varCat)
        {
            InitializeComponent();

            KeyPreview = true;
            this.KeyDown += CerrarFrm_KeyDown;
            nombre = varNombre;
            categoria = varCat;
            ObjLog = new clsLog();

            if (categoria != "Administrador")
            {
                pctUsuarios.Visible = false;
                lblABMUs.Visible = false;

            }

        }

        public void CerrarFrm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Application.Exit(); // Cierra la aplicación completa
                DateTime varFecha = DateTime.Now;
                string varAccion = "Cierra programa con ESC";

                ObjLog.CargarLog(nombre, varFecha, varAccion);
            }
        }
    
        private void btnMinimizarApp_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized; 

        }

        private void btnCerrarApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
            DateTime varFecha = DateTime.Now;
            string varAccion = "Cierra programa";

            ObjLog.CargarLog(nombre, varFecha, varAccion);
        }

        private void pctBuscar_Click(object sender, EventArgs e)
        {
            frmBuscador frmBuscador = new frmBuscador(nombre,categoria);
            this.Hide();
            frmBuscador.Show();
            DateTime varFecha = DateTime.Now;
            string varAccion = "Ingreso frmBuscador";

            ObjLog.CargarLog(nombre, varFecha, varAccion);
        }

        private void pctAgregar_Click(object sender, EventArgs e)
        {
            frmAgregar frmAgregar = new frmAgregar(nombre, categoria);   
            this.Hide();
            frmAgregar.Show();
            DateTime varFecha = DateTime.Now;
            string varAccion = "Ingreso frmAgregar";
            ObjLog.CargarLog(nombre, varFecha, varAccion);
        }

        private void pctEditar_Click(object sender, EventArgs e)
        {
            frmABM frmEditar = new frmABM(nombre, categoria);
            this.Hide();
            frmEditar.Show();
            DateTime varFecha = DateTime.Now;
            string varAccion = "Ingreso frmABM";
            ObjLog.CargarLog(nombre, varFecha, varAccion);
        }

        private void pctEliminar_Click(object sender, EventArgs e)
        {
            frmEliminar frmEliminar = new frmEliminar(nombre, categoria);
            this.Hide();
            frmEliminar.Show();
            DateTime varFecha = DateTime.Now;
            string varAccion = "Ingreso frmEliminar";
            ObjLog.CargarLog(nombre, varFecha, varAccion);
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

        private void pctSocios_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmABMSocios abmSocios = new frmABMSocios(nombre, categoria);
            abmSocios.Show();
            DateTime varFecha = DateTime.Now;
            string varAccion = "Ingreso frmABMSocios";
            ObjLog.CargarLog(nombre, varFecha, varAccion);
        }

        private void pctUsuarios_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmUsuarios frmUsuarios = new frmUsuarios(nombre, categoria);
            frmUsuarios.Show();
            DateTime varFecha = DateTime.Now;
            string varAccion = "Ingreso frmUsuarios";
            ObjLog.CargarLog(nombre, varFecha, varAccion);
        }
    }

   

    
}
