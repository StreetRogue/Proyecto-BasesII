using Oracle.ManagedDataAccess.Client;
using ProyectoBasesII.AccesoDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBasesII.Logica
{
    internal class assetServicio
    {
        Datos dt = new Datos();

        public int agregarServicio(int idServicio, int idTecnico, DateTime fechaInicio, int idVenta)
        {
            int filasInsertadas = 0;

            // Crear los parámetros para el procedimiento almacenado
            OracleParameter[] parametros = new OracleParameter[]
            {
                new OracleParameter("p_idServicio", OracleDbType.Int32) { Value = idServicio },
                new OracleParameter("p_idTecnico", OracleDbType.Int32) { Value = idTecnico },
                new OracleParameter("p_idVenta", OracleDbType.Int32) { Value = idVenta},
                new OracleParameter("p_fechaInicio", OracleDbType.Date) { Value = fechaInicio},
                new OracleParameter("p_fechaFin", OracleDbType.Date) { Value = null },
                new OracleParameter("p_filasInsertadas", OracleDbType.Int32, ParameterDirection.Output)
            };

            // Ejecutar el procedimiento almacenado
            dt.ejecutarSP("registrar_servicio", parametros);

            // Obtener el valor del parámetro de salida
            filasInsertadas = int.Parse(parametros[5].Value.ToString());

            return filasInsertadas;
        }

        public int consultarTecnico(string nombreTecnico)
        {
            DataSet ds = new DataSet();
            int auxIdTecnico = 0;
            string consulta = "SELECT idTecnico FROM tblTecnico WHERE nombreTecnico LIKE '" + nombreTecnico + "'";
            ds = dt.ejecutarSelect(consulta);

            if (ds.Tables[0].Rows.Count > 0)
            {
                auxIdTecnico = Convert.ToInt32(ds.Tables[0].Rows[0]["idTecnico"]);
                return auxIdTecnico;
            }
            else
            {
                return 0;
            }
        }

        public int consultarServicio(string nombreServicio)
        {
            DataSet ds = new DataSet();
            int auxIdServicio = 0;
            string consulta = "SELECT idServicio FROM tblServiciosPostVenta WHERE tipoServicio LIKE '" + nombreServicio + "'";
            ds = dt.ejecutarSelect(consulta);

            if (ds.Tables[0].Rows.Count > 0)
            {
                auxIdServicio = Convert.ToInt32(ds.Tables[0].Rows[0]["idServicio"]);
                return auxIdServicio;
            }
            else
            {
                return 0;
            }
        }

        public List<string> ObtenerNombresServicios()
        {
            List<string> nombresServicios = new List<string>();
            string consulta = "SELECT tipoServicio FROM tblServiciosPostVenta";

            // Usar el método ejecutarSelect para obtener el DataSet
            DataSet ds = dt.ejecutarSelect(consulta);

            // Verificar si el DataSet tiene datos
            if (ds != null && ds.Tables["resultadoDatos"].Rows.Count > 0)
            {
                foreach (DataRow row in ds.Tables["resultadoDatos"].Rows)
                {
                    nombresServicios.Add(row["tipoServicio"].ToString());
                }
            }

            return nombresServicios;
        }


        public DataSet buscarServicio(int idVenta)
        {
            DataSet ds = new DataSet();

            // Crear los parámetros para el procedimiento almacenado
            OracleParameter[] parametros = new OracleParameter[]
            {
                new OracleParameter("p_idVenta", OracleDbType.Int32) { Value = idVenta },
                new OracleParameter("p_servicios", OracleDbType.RefCursor) { Direction = ParameterDirection.Output }
            };

            // Ejecutar el procedimiento almacenado y obtener los datos
            return dt.ejecutarSPConCursores("Consultar_informacion_servicios_porId", parametros);
        }

        public DataSet buscarServiciosGeneral()
        {
            DataSet ds = new DataSet();
            string consulta;

            consulta = "SELECT * FROM vista_servicios";

            ds = dt.ejecutarSelect(consulta);

            return ds;
        }

        public int modificarServicios(int idEjemplar, string modeloVehiculo, string nombreProveedor)
        {
            int filasAfectadas = 0;

            // Construir la consulta SQL para actualizar
            string consulta = "UPDATE vista_inventario_ejemplares " + "SET \"Modelo Vehículo\" = '" + modeloVehiculo + "', \"Nombre Proveedor\" = '" + nombreProveedor + "' " + "WHERE \"ID Ejemplar\" = " + idEjemplar;

            // Ejecutar la consulta y realizar commit
            try
            {
                filasAfectadas = dt.ejecutarDML(consulta);
                Debug.WriteLine(filasAfectadas);

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
    }
}
