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
    internal class assetVehiculo
    {
        Datos dt = new Datos();

        public int consultarProveedor(string nombreProveedor)
        {
            DataSet ds = new DataSet();
            int auxIdProveedor = 0;
            string consulta = "SELECT idProveedor FROM tblProveedor WHERE nombreProveedor LIKE '" + nombreProveedor + "'";
            ds = dt.ejecutarSelect(consulta);

            if (ds.Tables[0].Rows.Count > 0)
            {
                auxIdProveedor = Convert.ToInt32(ds.Tables[0].Rows[0]["idProveedor"]);
                return auxIdProveedor;
            }
            else
            {
                return 0;
            }
        }

        public int registrarVehiculo(string modeloVehiculo, string marcaVehiculo, int anioVehiculo, float precioVehiculo, int idProveedor)
        {
            int filasInsertadas = 0;

            // Crear los parámetros para el procedimiento almacenado
            OracleParameter[] parametros = new OracleParameter[]
            {
                new OracleParameter("p_modeloVehiculo", OracleDbType.Varchar2) { Value = modeloVehiculo },
                new OracleParameter("p_marcaVehiculo", OracleDbType.Varchar2) { Value = marcaVehiculo },
                new OracleParameter("p_añoVehiculo", OracleDbType.Int32) { Value = anioVehiculo },
                new OracleParameter("p_precioVehiculo", OracleDbType.Int32) { Value = precioVehiculo },
                new OracleParameter("p_idProveedor", OracleDbType.Int32) { Value = idProveedor },
                new OracleParameter("p_filasInsertadas", OracleDbType.Int32, ParameterDirection.Output)
            };

            // Ejecutar el procedimiento almacenado
            dt.ejecutarSP("registrar_vehiculo", parametros);

            // Obtener el valor del parámetro de salida
            filasInsertadas = int.Parse(parametros[5].Value.ToString());

            return filasInsertadas;
        }


        public List<string> ObtenerModelosVehiculos()
        {
            List<string> modelosVehiculos = new List<string>();
            string consulta = "SELECT modeloVehiculo FROM tblVehiculo";

            // Usar el método ejecutarSelect para obtener el DataSet
            DataSet ds = dt.ejecutarSelect(consulta);

            // Verificar si el DataSet tiene datos
            if (ds != null && ds.Tables["resultadoDatos"].Rows.Count > 0)
            {
                foreach (DataRow row in ds.Tables["resultadoDatos"].Rows)
                {
                    modelosVehiculos.Add(row["modeloVehiculo"].ToString());
                }
            }

            return modelosVehiculos;
        }

        public List<string> ObtenerVehiculosPorProveedor(int idProveedor)
        {
            List<string> nombresVehiculos = new List<string>();

            // Consulta SQL para obtener los vehículos por proveedor
            string consulta = $"SELECT modeloVehiculo FROM tblVehiculo WHERE idProveedor = {idProveedor}";

            try
            {
                DataSet ds = dt.ejecutarSelect(consulta); // Usar el método existente para ejecutar consultas

                if (ds.Tables["resultadoDatos"].Rows.Count > 0)
                {
                    foreach (DataRow row in ds.Tables["resultadoDatos"].Rows)
                    {
                        nombresVehiculos.Add(row["modeloVehiculo"].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener los vehículos del proveedor: " + ex.Message);
            }

            return nombresVehiculos;
        }

    }
}
