using pryFollentiIE.Properties;
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
    public partial class frmBuscador : Form
    {
        string varNombre;
        string varCategoria;
        public frmBuscador(string noTenes7L, string jfKennedy)
        {
            InitializeComponent();
            varNombre = noTenes7L;
            varCategoria = jfKennedy;
            LlenarTreeView();
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

        DirectoryInfo info;
        proveedor prov = new proveedor();
        private void LlenarTreeView() //este procedimiento me rellena el treeview
        {
            TreeNode nodoMadre;

            info = new DirectoryInfo(@"../../Resources/Proovedores");
            if (info.Exists == true) //POR DEFECTO el IF pregunta true
            {
                nodoMadre = new TreeNode(info.Name);
                nodoMadre.Tag = info;
                ObtenerCarpetas(info.GetDirectories(), nodoMadre);
                treeView1.Nodes.Add(nodoMadre);
            }
        }

        //desde info.GetDirectories() nos da todos los nombrs
        //de carpetas
        private void ObtenerCarpetas(DirectoryInfo[] subDirs,  //este procedimiento me obtiene las carpetas del nodo madre en este caso las carpetas que estan dentro de proovedores
    TreeNode nodeToAddTo)
        {
            TreeNode aNode;
            DirectoryInfo[] subSubDirs;


            foreach (DirectoryInfo subDir in subDirs)
            {
                aNode = new TreeNode(subDir.Name, 0, 0);
                aNode.Tag = subDir;
                aNode.ImageKey = "folder";

                // Obtener archivos en lugar de solo carpetas
                FileInfo[] files = subDir.GetFiles();
                foreach (FileInfo file in files)
                {
                    TreeNode fileNode = new TreeNode(file.Name, 1, 1); // Usar una imagen para archivos
                    fileNode.Tag = file;
                    aNode.Nodes.Add(fileNode);
                }

                //recursiva - se llama a si mismo para
                //buscar màs carpetas
                subSubDirs = subDir.GetDirectories();
                if (subSubDirs.Length != 0)
                {
                    ObtenerCarpetas(subSubDirs, aNode);
                }

                nodeToAddTo.Nodes.Add(aNode);
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

        string leerLinea;
        string[] separarDatos;

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

            

           dgvListado.Rows.Clear();
            dgvListado.Columns.Clear();

            string Archivo = Convert.ToString(treeView1.SelectedNode.FullPath);

            info = new DirectoryInfo(@"../../Resources");
            string ruta = info.FullName;

            string NombreArchivo = treeView1.SelectedNode.Text;

            try
            {
                StreamReader sr = new StreamReader(ruta + "\\" + Archivo);

                leerLinea = sr.ReadLine();
                if (leerLinea != null)
                {
                    separarDatos = leerLinea.Split(';');
                }
                else
                {
                    MessageBox.Show("el archivo no tiene registros");
                }

                if (separarDatos != null)
                {
                    for (int indice = 0; indice < separarDatos.Length; indice++)
                    {
                        dgvListado.Columns.Add(separarDatos[indice], separarDatos[indice]);
                    }

                    while (sr.EndOfStream == false)
                    {
                        leerLinea = sr.ReadLine();
                        separarDatos = leerLinea.Split(';');
                        dgvListado.Rows.Add(separarDatos);
                    }
                }
                

                sr.Close();
            }
            catch (Exception)
            {
                
            } 
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frmPrincipal frmPrincipal = new frmPrincipal(varNombre, varCategoria);
            this.Hide();
            frmPrincipal.Show();
        }



        //preguntar profe
        //como tomo la ruta?
        // como reinicio la grilla




    }
    
}
