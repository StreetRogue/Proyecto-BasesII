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
    internal class assetEjemplar
    {
        Datos dt = new Datos();

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

        public int agregarEjemplar(int idVehiculo, int idProveedor, int cantidad)
        {
            int filasInsertadas = 0;

            // Crear los parámetros para el procedimiento almacenado
            OracleParameter[] parametros = new OracleParameter[]
            {
                new OracleParameter("p_idVehiculo", OracleDbType.Int32) { Value = idVehiculo },
                new OracleParameter("p_idProveedor", OracleDbType.Int32) { Value = idProveedor },
                new OracleParameter("p_estado", OracleDbType.Varchar2) { Value = "disponible" },
                new OracleParameter("p_cantidad", OracleDbType.Int32) { Value = cantidad },
                new OracleParameter("p_filasInsertadas", OracleDbType.Int32, ParameterDirection.Output)
            };

            // Ejecutar el procedimiento almacenado
            dt.ejecutarSP("pkg_ejemplares.InsertarEjemplares", parametros);

            // Obtener el valor del parámetro de salida
            filasInsertadas = int.Parse(parametros[4].Value.ToString());

            return filasInsertadas;
        }


        public DataSet buscarEjemplar(int idEjemplar)
        {
            DataSet ds = new DataSet();

            // Crear los parámetros para el procedimiento almacenado
            OracleParameter[] parametros = new OracleParameter[]
            {
                new OracleParameter("p_idEjemplar", OracleDbType.Int32) { Value = idEjemplar },
                new OracleParameter("p_ejemplar", OracleDbType.RefCursor) { Direction = ParameterDirection.Output }
            };

            // Ejecutar el procedimiento almacenado y obtener los datos
            return dt.ejecutarSPConCursores("pkg_ejemplares.Consultar_informacion_ejemplar", parametros);
        }


        public DataSet buscarEjemplarGeneral()
        {
            DataSet ds = new DataSet();
            string consulta;

            consulta = "SELECT * FROM vista_inventario_ejemplares";

            ds = dt.ejecutarSelect(consulta);

            return ds;
        }

    }
}
