using Oracle.ManagedDataAccess.Client;
using ProyectoBasesII.AccesoDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBasesII.Logica
{
    internal class assetCliente
    {
        Datos dt = new Datos();

        public int registrarCliente(int cedulaCliente, string nombreCliente, string apellidoCliente, string telefonoCliente, string emailCliente, string direccionCliente)
        {
            int filasInsertadas = 0;

            // Crear los parámetros para el procedimiento almacenado
            OracleParameter[] parametros = new OracleParameter[]
            {
                new OracleParameter("p_cedulaCliente", OracleDbType.Int32) { Value = cedulaCliente },
                new OracleParameter("p_nombreCliente", OracleDbType.Varchar2) { Value = nombreCliente},
                new OracleParameter("p_apellidoCliente", OracleDbType.Varchar2) { Value = apellidoCliente },
                new OracleParameter("p_telefonoCliente", OracleDbType.Varchar2) { Value = telefonoCliente },
                new OracleParameter("p_emailCliente", OracleDbType.Varchar2) { Value = emailCliente },
                new OracleParameter("p_direccionProveedor", OracleDbType.Varchar2) { Value = direccionCliente },
                new OracleParameter("p_filasInsertadas", OracleDbType.Int32, ParameterDirection.Output)
            };

            // Ejecutar el procedimiento almacenado
            dt.ejecutarSP("pkg_clientes.Registrar_Cliente_Nuevo", parametros);

            // Obtener el valor del parámetro de salida
            filasInsertadas = int.Parse(parametros[6].Value.ToString());

            return filasInsertadas;
        }

        public List<int> ObtenerCedulaCliente()
        {
            List<int> cedulaCliente = new List<int>();
            string consulta = "SELECT cedulaCliente FROM tblCliente";

            // Usar el método ejecutarSelect para obtener el DataSet
            DataSet ds = dt.ejecutarSelect(consulta);

            // Verificar si el DataSet tiene datos
            if (ds != null && ds.Tables["resultadoDatos"].Rows.Count > 0)
            {
                foreach (DataRow row in ds.Tables["resultadoDatos"].Rows)
                {
                    // Casteo a entero antes de agregar a la lista
                    cedulaCliente.Add(Convert.ToInt32(row["cedulaCliente"]));
                }
            }

            return cedulaCliente;
        }

    }
}
