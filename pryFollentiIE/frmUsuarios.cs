using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace pryFollentiIE
{
    public partial class frmUsuarios : Form
    {
        string varNombre;
        string varCategoria;
        AccesoDatos objBD;
        string varNombreUs, varContraseña;

        public frmUsuarios(string noTenes7L, string jfKennedy)
        {
            InitializeComponent();
            varNombre = noTenes7L;
            varCategoria = jfKennedy;
            KeyPreview = true;
            this.KeyDown += CerrarFrm_KeyDown;
            varNombre = noTenes7L;
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

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmPrincipal frmPrincipal = new frmPrincipal(varNombre, varCategoria);
            this.Hide();
            frmPrincipal.Show();
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'eL_CLUBDataSet.USERS' Puede moverla o quitarla según sea necesario.
            this.uSERSTableAdapter.Fill(this.eL_CLUBDataSet.USERS);
            objBD = new AccesoDatos();
            objBD.ConectarBD();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Obtener el objeto DataRowView seleccionado
            DataRowView selectedDataRowView = cmbPerfiles.SelectedItem as DataRowView;

            if (selectedDataRowView != null)
            {
                if (varNombreUs != "" && varContraseña != "")
                {
                    // Acceder al valor de la columna deseada (en este caso, "perfil
                    string valorSeleccionado = selectedDataRowView["perfil"].ToString();
                    varNombreUs = txtNomUs.Text;
                    varContraseña = txtContUs.Text;
                    objBD.AgregarUsuario(varNombreUs, varContraseña, valorSeleccionado);
                }
                else
                {
                    MessageBox.Show("Todos los campos deben ser completados");
                    txtNomUs.Focus();
                }

            }
    }
}
}
