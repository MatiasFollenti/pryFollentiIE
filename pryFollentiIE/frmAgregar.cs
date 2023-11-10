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
    public partial class frmAgregar : Form
    {
        string varNombre;
        string varCategoria;

        public frmAgregar(string noTenes7L, string jfKennedy)
        {
            InitializeComponent();
            varNombre = noTenes7L;
            varCategoria = jfKennedy;
            KeyPreview = true;
            this.KeyDown += CerrarFrm_KeyDown;
        }
         proveedor prov = new proveedor();
         string rutaCarpeta;

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

        private void frmAgregar_Load(object sender, EventArgs e)
        {
             
        }

         
        FolderBrowserDialog fbD = new FolderBrowserDialog();
        public void btnSeleccionar_Click(object sender, EventArgs e)
        {
            rutaCarpeta = string.Empty;


            // Muestra el diálogo y verifica si el usuario hizo clic en OK
            if (fbD.ShowDialog() == DialogResult.OK)
                {
                    rutaCarpeta = fbD.SelectedPath;
                    MessageBox.Show("Ruta seleccionada: " + rutaCarpeta);
                }
            lblArchSelec.Text = rutaCarpeta;
        }
            
    



        private void btnIngresar_Click(object sender, EventArgs e)
        {
            
            //crea/abre archivo 
            StreamWriter sw = new StreamWriter(rutaCarpeta + "/" + txtNomArchivo.Text + ".csv", true);
            string linea = txtNum.Text + ";" + txtEntidad.Text + ";" + txtApertura.Text + ";" + txtNumExp.Text + ";" + txtJuzg.Text + ";" + txtJur.Text + ";" + txtDireccion.Text + ";" + txtLiqResp.Text;
            sw.WriteLine(linea);
            sw.Close();
            sw.Dispose();
            MessageBox.Show("Se ha cargado la linea del archivo correctamente");

            /*prov.rutaArchivo = rutaCarpeta + "/" + txtNomArchivo.Text; 
           
            
            prov.Grabar(linea);
            MessageBox.Show("nuevo proveedor cargado con exito!");
             txtApertura.Clear();
            txtNum.Clear(); 
            txtEntidad.Clear();
            txtNumExp.Clear();
            txtJuzg.Clear();
            txtDireccion.Clear();
            txtLiqResp.Clear();
            txtDireccion.Clear();
            */
        }


    }
}
