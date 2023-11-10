using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace pryFollentiIE
{
    public partial class frmEliminar : Form
    {
        string varNombre;
        string varCategoria;
        public frmEliminar(string noTenes7L, string jfKennedy)
        {
            InitializeComponent();
            varNombre = noTenes7L;
            varCategoria = jfKennedy;
            KeyPreview = true;
            this.KeyDown += CerrarFrm_KeyDown;
        }


        OpenFileDialog ofD = new OpenFileDialog();
        string rutaArchivo = string.Empty;
        // Obtiene el directorio actual de la aplicación
        string directorioActual = Application.StartupPath;

        public static void CerrarFrm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Application.Exit(); // Cierra la aplicación completa
            }
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frmPrincipal frmPrincipal = new frmPrincipal(varNombre, varCategoria);
            this.Hide();
            frmPrincipal.Show();
        }

        private void btnMinimizarApp_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnCerrarApp_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        private void btnSeleccionarRuta_Click(object sender, EventArgs e)
        {
            //Retrocede dos carpetas 
            for (int i = 0; i < 2; i++)
            {
                directorioActual = System.IO.Directory.GetParent(directorioActual).FullName;
            }
            //al directorio actual le suma/combina la carpeta "resources" + proveedores
            directorioActual = System.IO.Path.Combine(directorioActual, "Resources");

            //marca donde se inicializa el OpenFileDialog
            ofD.InitialDirectory = directorioActual;
            ofD.Filter = "Carpetas|*.folder";


            if (ofD.ShowDialog() == DialogResult.OK)
            {
                rutaArchivo = ofD.FileName;
            }

            lblRuta.Text = rutaArchivo;
            

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            
            var result = MessageBox.Show("¿ Está seguro que desea borrar el archivo:  " + rutaArchivo + " ?", "Eliminar archivo", MessageBoxButtons.OKCancel);


            if (result == DialogResult.OK)
            {
                if (File.Exists(rutaArchivo))
                {
                    File.Delete(rutaArchivo);
                }


            }

        }
    }
}
