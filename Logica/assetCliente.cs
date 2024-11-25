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

        public DataTable ObtenerClientes()
        {
            Datos datos = new Datos(); // Instancia de la clase Datos
            DataTable clientes = new DataTable();

            // Crear los parámetros para el procedimiento almacenado
            OracleParameter[] parametros = new OracleParameter[]
            {
                new OracleParameter("p_clientes", OracleDbType.RefCursor) { Direction = ParameterDirection.Output }
            };



            try
            {
                // Llamar al procedimiento y obtener un DataSet
                DataSet dsClientes = datos.ejecutarSPConCursores("pkg_clientes.obtener_clientes", parametros);

                // Obtener la primera tabla del DataSet
                clientes = dsClientes.Tables[0];
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener clientes: {ex.Message}");
            }

            return clientes;
        }

        public int modificarCliente(int cedulaCliente, string nombreCliente, string apellidoCliente, string telefonoCliente, string emailCliente, string direccionCliente)
        {
            int filasAfectadas = 0;

            // Construir la consulta SQL para actualizar
            string consulta = "UPDATE tblCliente " +
                  "SET nombreCliente = '" + nombreCliente + "', " +
                  "apellidoCliente = '" + apellidoCliente + "', " +
                  "telefonoCliente = '" + telefonoCliente + "', " +
                  "emailCliente = '" + emailCliente + "', " +
                  "direccionCliente = '" + direccionCliente + "' " +
                  "WHERE cedulaCliente = " + cedulaCliente;


            // Ejecutar la consulta y realizar commit
            try
            {
                filasAfectadas = dt.ejecutarDML(consulta);

                if (filasAfectadas > 0)
                {
                    // Confirmar los cambios
                    dt.ejecutarDML("COMMIT");
                }
            }
            catch (Exception ex)
            {
                // Si ocurre un error, puedes manejarlo aquí (opcionalmente podrías hacer un rollback)
                throw new Exception($"Error al modificar el ejemplar: {ex.Message}");
            }

            return filasAfectadas;
        }

        public DataSet buscarCliente(int cedulaCliente)
        {
            DataSet ds = new DataSet();

            // Crear los parámetros para el procedimiento almacenado
            OracleParameter[] parametros = new OracleParameter[]
            {
                new OracleParameter("p_cedulaCliente", OracleDbType.Int32) { Value = cedulaCliente },
                new OracleParameter("p_cliente", OracleDbType.RefCursor) { Direction = ParameterDirection.Output }
            };

            // Ejecutar el procedimiento almacenado y obtener los datos
            return dt.ejecutarSPConCursores("pkg_clientes.obtener_cliente_por_cedula", parametros);
        }


    }
}
