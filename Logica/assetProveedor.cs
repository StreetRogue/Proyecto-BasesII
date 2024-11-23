using Oracle.ManagedDataAccess.Client;
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

        Datos dt = new Datos();

        public int registrarProveedor(int idProveedor, string nombreProveedor, string telefonoProveedor, string direccionProveedor)
        {
            int filasInsertadas = 0;

            // Crear los parámetros para el procedimiento almacenado
            OracleParameter[] parametros = new OracleParameter[]
            {
                new OracleParameter("p_idProveedor", OracleDbType.Int32) { Value = idProveedor },
                new OracleParameter("p_nombreProveedor", OracleDbType.Varchar2) { Value = nombreProveedor},
                new OracleParameter("p_telefonoProveedor", OracleDbType.Varchar2) { Value = telefonoProveedor },
                new OracleParameter("p_direccionProveedor", OracleDbType.Varchar2) { Value = direccionProveedor },
                new OracleParameter("p_filasInsertadas", OracleDbType.Int32, ParameterDirection.Output)
            };

            // Ejecutar el procedimiento almacenado
            dt.ejecutarSP("pkg_proveedores.RegistrarProveedor", parametros);

            // Obtener el valor del parámetro de salida
            filasInsertadas = int.Parse(parametros[4].Value.ToString());

            return filasInsertadas;
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

        public DataSet buscarProveedor(int idProveedor)
        {
            DataSet ds = new DataSet();
            
            // Crear los parámetros para el procedimiento almacenado
            OracleParameter[] parametros = new OracleParameter[]
            {
                new OracleParameter("p_idProveedor", OracleDbType.Int32) { Value = idProveedor },
                new OracleParameter("p_proveedor", OracleDbType.RefCursor) { Direction = ParameterDirection.Output },
            };

            // Ejecutar el procedimiento almacenado y obtener los datos
            return dt.ejecutarSPConCursores("pkg_proveedores.Consultar_informacion_proveedor_cursor", parametros);
        }


        public DataSet buscarProveedorGeneral()
        {
            DataSet ds = new DataSet();
            string consulta;

            consulta = "SELECT * FROM vista_proveedores";

            ds = dt.ejecutarSelect(consulta);

            return ds;
        }

    }
}
