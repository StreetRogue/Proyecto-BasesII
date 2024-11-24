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
    internal class assetVenta
    {
        Datos dt = new Datos();


        public int agregarVenta(int idVendedor, int cedulaCliente, int idEjemplar, DateTime fechaVenta)
        {
            int filasInsertadas = 0;

            // Crear los parámetros para el procedimiento almacenado
            OracleParameter[] parametros = new OracleParameter[]
            {
                new OracleParameter("p_fecha", OracleDbType.Date) { Value = fechaVenta },
                new OracleParameter("p_id_vendedor", OracleDbType.Int32) { Value = idVendedor },
                new OracleParameter("p_cedula_cliente", OracleDbType.Int32) { Value = cedulaCliente},
                new OracleParameter("p_id_ejemplar", OracleDbType.Int32) { Value = idEjemplar },
                new OracleParameter("p_filasInsertadas", OracleDbType.Int32, ParameterDirection.Output)
            };

            // Ejecutar el procedimiento almacenado
            dt.ejecutarSP("pkg_ventas.registrar_venta", parametros);

            // Obtener el valor del parámetro de salida
            filasInsertadas = int.Parse(parametros[4].Value.ToString());

            return filasInsertadas;
        } 


        public int consultarVendedor(string nombreVendedor)
        {
            DataSet ds = new DataSet();
            int auxIdVendedor = 0;
            string consulta = "SELECT idVendedor FROM tblVendedor WHERE nombreVendedor LIKE '" + nombreVendedor + "'";
            ds = dt.ejecutarSelect(consulta);

            if (ds.Tables[0].Rows.Count > 0)
            {
                auxIdVendedor = Convert.ToInt32(ds.Tables[0].Rows[0]["idVendedor"]);
                return auxIdVendedor;
            }
            else
            {
                return 0;
            }
        }

        public int consultarPrecioVehiculo(string modeloVehiculo)
        {
            DataSet ds = new DataSet();
            int auxIdVehiculo = 0;
            string consulta = "SELECT precioVehiculo FROM tblVehiculo WHERE modeloVehiculo LIKE '" + modeloVehiculo + "'";
            ds = dt.ejecutarSelect(consulta);

            if (ds.Tables[0].Rows.Count > 0)
            {
                auxIdVehiculo = Convert.ToInt32(ds.Tables[0].Rows[0]["precioVehiculo"]);
                return auxIdVehiculo;
            }
            else
            {
                return 0;
            }
        }

        public string consultarCliente(int cedulaCliente)
        {
            DataSet ds = new DataSet();
            string auxnombreCliente = "";
            string consulta = "SELECT nombreCliente FROM tblCliente WHERE cedulaCliente LIKE '" + cedulaCliente + "'";
            ds = dt.ejecutarSelect(consulta);

            if (ds.Tables[0].Rows.Count > 0)
            {
                auxnombreCliente = Convert.ToString(ds.Tables[0].Rows[0]["nombreCliente"]);

                return auxnombreCliente;
            }
            else
            {
                return "";
            }
        }

        public int consultarVehiculo(string modeloVehiculo)
        {
            DataSet ds = new DataSet();
            int auxIdVehiculo = 0;
            string consulta = "SELECT idVehiculo FROM tblVehiculo WHERE modeloVehiculo LIKE '" + modeloVehiculo + "'";
            ds = dt.ejecutarSelect(consulta);

            if (ds.Tables[0].Rows.Count > 0)
            {
                auxIdVehiculo = Convert.ToInt32(ds.Tables[0].Rows[0]["idVehiculo"]);
                return auxIdVehiculo;
            }
            else
            {
                return 0;
            }
        }

        public List<string> ObtenerEjemplaresPorVehiculo(string modeloVehiculo)
        {
            List<string> ejemplaresDisponibles = new List<string>();

            // Consulta SQL para obtener los ejemplares por vehiculo
            string consulta = $"SELECT idEjemplar FROM tblEjemplar INNER JOIN tblVehiculo ON tblEjemplar.idVehiculo = tblVehiculo.idVehiculo WHERE estadoEjemplar like 'disponible' AND modeloVehiculo like '"+ modeloVehiculo+"'";

            try
            {
                DataSet ds = dt.ejecutarSelect(consulta); // Usar el método existente para ejecutar consultas

                if (ds.Tables["resultadoDatos"].Rows.Count > 0)
                {
                    foreach (DataRow row in ds.Tables["resultadoDatos"].Rows)
                    {
                        ejemplaresDisponibles.Add(row["idEjemplar"].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener los ejemplares del vehiculo: " + ex.Message);
            }

            return ejemplaresDisponibles;
        }


        public DataSet buscarVenta(int idVenta)
        {
            DataSet ds = new DataSet();

            // Crear los parámetros para el procedimiento almacenado
            OracleParameter[] parametros = new OracleParameter[]
            {
                new OracleParameter("p_id_venta", OracleDbType.Int32) { Value = idVenta },
                new OracleParameter("p_cursor", OracleDbType.RefCursor) { Direction = ParameterDirection.Output }
            };

            // Ejecutar el procedimiento almacenado y obtener los datos
            return dt.ejecutarSPConCursores("generar_reporte_venta", parametros);
        }



        public DataSet buscarVentasGeneral()
        {
            DataSet ds = new DataSet();
            string consulta;

            consulta = "SELECT * FROM vista_ventas";

            ds = dt.ejecutarSelect(consulta);

            return ds;
        }
    }
}
