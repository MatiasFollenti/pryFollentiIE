using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryFollentiIE
{
    public partial class frmABM : Form
    {
        string varNombre;
        string varCategoria;

        public frmABM(string noTenes7L, string jfKennedy)
        {
            InitializeComponent();
            varNombre =  noTenes7L;
            varCategoria = jfKennedy;
            KeyPreview = true;
            this.KeyDown += CerrarFrm_KeyDown;
        }

        string rutaArchivo;
        string nombreArchivo;
        string directorioActual = Application.StartupPath;
        proveedor prov = new proveedor();

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

        private void frmEditar_Load(object sender, EventArgs e)
        {
            txtApertura.Enabled = false;
            txtDireccion.Enabled = false;
            txtEntidad.Enabled = false;
            txtJur.Enabled = false;
            txtJuzg.Enabled = false;
            txtLiqResp.Enabled = false;
            txtNumExp.Enabled = false;
        }

        private void pctEditarNum_Click(object sender, EventArgs e)
        {
            txtNum.Enabled = true;
        }

        private void pctEditarEnt_Click(object sender, EventArgs e)
        {
            txtEntidad.Enabled = true;
        }

        private void pctEditarAp_Click(object sender, EventArgs e)
        {
            txtApertura.Enabled=true;   

        }

        private void pctEditarExp_Click(object sender, EventArgs e)
        {
            txtNumExp.Enabled = true;   

        }

        private void pctEditarJuz_Click(object sender, EventArgs e)
        {
            txtJuzg.Enabled=true;
        }

        private void pctEditarDir_Click(object sender, EventArgs e)
        {
            txtDireccion.Enabled = true;
        }

        private void pctEditarLiq_Click(object sender, EventArgs e)
        {
            txtLiqResp.Enabled=true;    
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            txtJur.Enabled = true;
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofD = new OpenFileDialog();
            rutaArchivo = string.Empty;
            nombreArchivo = string.Empty;
            
            //Retrocede dos carpetas 
            for (int i = 0; i < 2; i++)
            {
                directorioActual = System.IO.Directory.GetParent(directorioActual).FullName;
            }
            //al directorio actual le suma/combina la carpeta "resources" + proveedores
            directorioActual = System.IO.Path.Combine(directorioActual, "Resources","Proveedores");

            //marca donde se inicializa el OpenFileDialog
            ofD.InitialDirectory = directorioActual;
            

            if (ofD.ShowDialog() == DialogResult.OK)
            {
                rutaArchivo = ofD.FileName;
                nombreArchivo = ofD.SafeFileName;
            }

            lblArchivoSelec.Text = nombreArchivo ;
        }
        string[] parametros = new string[8];
        private void btnEditar_Click(object sender, EventArgs e)
        {
            //usuario ingresa el num de registro a modificar
            string num = txtNum.Text;

            //Es una lista
            List<string> lineasArchivo = new List<string>();

            using (StreamReader sr = new StreamReader(rutaArchivo))
            {
                // Lee la primer linea
                string linea=sr.ReadLine();
                //mientras la linea sea distinto de un valor nulo
                while (linea != null)
                {
                    // Procesa la línea - separa cada campo de un registro
                    parametros = linea.Split(';');
                    //Copia todas las lineas que no coincide con el ID para sobreescribir el archivo sin la linea que quiero borrar
                    if (parametros[0] != num)
                    {
                        
                        //a la lista le agrega el resto de las lineas
                        lineasArchivo.Add(linea);
                    }
                    // sino si el numero coincide me agrega la linea con los campos editados
                    else
                    {
                        
                        string nuevaLinea = txtNum.Text + ";" + txtEntidad.Text + ";" + txtApertura.Text + ";" + txtNumExp.Text + ";" + txtJuzg.Text + ";" + txtJur.Text + ";" + txtDireccion.Text + ";" + txtLiqResp.Text + ";";
                        lineasArchivo.Add(nuevaLinea);
                        
                    }

                    linea = sr.ReadLine();
                }
            }
            //agrega al archivo la lista llamada lineasArchivo
            using (StreamWriter sw = new StreamWriter(rutaArchivo))
            {
                foreach (string lineaSingular in lineasArchivo)
                {
                    sw.WriteLine(lineaSingular); // Escribe cada elemento en una línea del archivo
                }
            }

            MessageBox.Show("El registro fue modificado correctamente.");
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            StreamWriter sw =  new StreamWriter(rutaArchivo,true);

            //como cotrolo que el numero no est{e ingresado??

            string linea = txtNum.Text + ";" + txtEntidad.Text + ";" + txtApertura.Text + ";" + txtNumExp.Text + ";" + txtJuzg.Text + ";" + txtJur.Text + ";" + txtDireccion.Text + ";" + txtLiqResp.Text;
            sw.WriteLine(linea);
            sw.Close();
            sw.Dispose();
            MessageBox.Show("nuevo registro agregado con exito!");

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //usuario ingresa el num de registro a modificar
            string num = txtNum.Text;

            //Es una lista
            List<string> lineasArchivo = new List<string>();

            using (StreamReader sr = new StreamReader(rutaArchivo))
            {
                // Lee la primer linea
                string linea = sr.ReadLine();
                //mientras la linea sea distinto de un valor nulo
                while (linea != null)
                {
                    // Procesa la línea - separa cada campo de un registro
                    parametros = linea.Split(';');
                    //Copia todas las lineas que no coincide con el ID para sobreescribir el archivo sin la linea que quiero borrar
                    if (parametros[0] != num)
                    {

                        //a la lista le agrega el resto de las lineas
                        lineasArchivo.Add(linea);
                    }
                    // sino si el numero coincide me agrega la linea con los campos editados
                    else
                    {


                        lineasArchivo.Remove(linea);  //quita la linea que coincide con el numero ingresado por teclado

                    }

                    linea = sr.ReadLine();
                
                
                }
            }
            //agrega al archivo la lista llamada lineasArchivo
            using (StreamWriter sw = new StreamWriter(rutaArchivo))
            {
                foreach (string lineaSingular in lineasArchivo)
                {
                    sw.WriteLine(lineaSingular); // Escribe cada elemento en una línea del archivo
                }
            }

            MessageBox.Show("El registro fue eliminado correctamente.");
        }
    

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string linea;
            
            if (!string.IsNullOrEmpty(txtNum.Text))//si lo contrario de nulo o vacio del txtnro
            {
                string nroBuscado = txtNum.Text.Trim(); // Valor a buscar en txtNro

                using (StreamReader sr = new StreamReader(rutaArchivo))
                {
                    

                    while ((linea = sr.ReadLine()) != null)
                    {
                        // Divide la línea en sus campos
                        string[] parametros = linea.Split(';');

                        // Compara el valor en el campo correspondiente (asumiendo que el número de registro está en el índice 0)
                        if (parametros.Length > 0 && parametros[0] == nroBuscado)
                        {
                            // Asigna los valores a las cajas de texto
                            txtEntidad.Text = parametros[1];
                            txtApertura.Text = parametros[2];
                            txtNumExp.Text = parametros[3];
                            txtJuzg.Text = parametros[4];
                            txtJur.Text = parametros[5];
                            txtDireccion.Text = parametros[6];
                            txtLiqResp.Text = parametros[7];

                            // Termina el bucle ya que se encontró el registro
                            break;
                        }
                        else 
                        {

                            txtApertura.Text = string.Empty;
                            txtNumExp.Text = string.Empty;
                            txtDireccion.Text = string.Empty;
                            txtEntidad.Text = string.Empty;
                            txtJur.Text = string.Empty;
                            txtJuzg.Text = string.Empty;
                            txtLiqResp.Text = string.Empty;
                

                        }
                      
                    }
                }
            }
        }
    }
}
