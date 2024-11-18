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
            dt.ejecutarSP("INSERTAREJEMPLARES", parametros);

            // Obtener el valor del parámetro de salida
            filasInsertadas = int.Parse(parametros[4].Value.ToString());

            return filasInsertadas;
        }

        public DataSet inventarioEjemplares(int idEjemplar)
        {
            DataSet ds = new DataSet();
            string consulta;
            if (idEjemplar == -1)
            {
                consulta = "SELECT * from tblEjemplar inner join tblVehiculo on tblEjemplar.idVehiculo = tblVehiculo.idVehiculo inner join tblProveedor on tblVehiculo.idProveedor = tblProveedor.idProveedor";
            }
            else
            {
                consulta = "SELECT * from tblEjemplar inner join tblVehiculo on tblEjemplar.idVehiculo = tblVehiculo.idVehiculo inner join tblProveedor on tblVehiculo.idProveedor = tblProveedor.idProveedor WHERE idEjemplar =" + idEjemplar + "";
            }
            ds = dt.ejecutarSelect(consulta);
            return ds;
        }

    }
}
