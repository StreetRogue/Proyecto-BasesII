using ProyectoBasesII.AccesoDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoBasesII.Logica
{
    internal class assetProveedor
    {
        Datos dt  = new Datos();
        public int registrarProveedor(int idProveedor, string nombreProveedor, string telefonoProveedor, string direccionProveedor)
        {
            int resultado = 0;

            string consulta;

            consulta = "INSERT INTO tblProveedor (idProveedor, nombreProveedor, telefonoProveedor, direccionProveedor) values (" + idProveedor + ",'" + nombreProveedor + "','"+ telefonoProveedor+"','"+direccionProveedor+"')";

            resultado = dt.ejecutarDML(consulta);

            return resultado;

        }

        public List<string> ObtenerNombresProveedores()
        {
            List<string> nombresProveedores = new List<string>();
            string consulta = "SELECT nombreProveedor FROM tblProveedor";

            // Usar el método ejecutarSelect para obtener el DataSet
            DataSet ds = dt.ejecutarSelect(consulta);

            // Verificar si el DataSet tiene datos
            if (ds != null && ds.Tables["resultadoDatos"].Rows.Count > 0)
            {
                foreach (DataRow row in ds.Tables["resultadoDatos"].Rows)
                {
                    nombresProveedores.Add(row["nombreProveedor"].ToString());
                }
            }

            return nombresProveedores;
        }

        
    }
}
