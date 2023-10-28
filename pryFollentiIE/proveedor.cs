using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace pryFollentiIE
{
    
    public class proveedor
    {
        public string rutaArchivo;
        public void Grabar(string linea)
        {
            StreamWriter sw = new StreamWriter(rutaArchivo + ".csv",true);
            sw.WriteLine(linea);
            sw.Close();
            sw.Dispose();
        }

        
        
    }
}
