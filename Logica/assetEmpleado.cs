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
    internal class assetEmpleado
    {
        Datos dt = new Datos();


        public int registrarEmpleado(string nombreEmpleado, string apellidoEmpleado, string cargoEmpleado)
        {
            int filasInsertadas = 0;

            // Crear los parámetros para el procedimiento almacenado
            OracleParameter[] parametros = new OracleParameter[]
            {
                new OracleParameter("p_nombre", OracleDbType.Varchar2) { Value = nombreEmpleado },
                new OracleParameter("p_apellido", OracleDbType.Varchar2) { Value = apellidoEmpleado },
                new OracleParameter("p_tipo_empleado", OracleDbType.Varchar2) { Value = cargoEmpleado.ToUpper() }, // Convertimos a mayúsculas
                new OracleParameter("p_fecha_contratacion", OracleDbType.Date) { Value = DateTime.Now },
                new OracleParameter("p_estado", OracleDbType.Varchar2) { Value = "activo" }, // Siempre 'activo' por defecto
                new OracleParameter("p_filasInsertadas", OracleDbType.Int32, ParameterDirection.Output) // Parámetro de salida
            };

            // Ejecutar el procedimiento almacenado
            dt.ejecutarSP("registrar_empleado", parametros);

            // Obtener el valor del parámetro de salida
            filasInsertadas = int.Parse(parametros[5].Value.ToString());

            return filasInsertadas;
        }

        public List<string> ObtenerNombresVendedores()
        {
            List<string> nombresVendedores = new List<string>();
            string consulta = "SELECT nombreVendedor FROM tblVendedor";

            // Usar el método ejecutarSelect para obtener el DataSet
            DataSet ds = dt.ejecutarSelect(consulta);

            // Verificar si el DataSet tiene datos
            if (ds != null && ds.Tables["resultadoDatos"].Rows.Count > 0)
            {
                foreach (DataRow row in ds.Tables["resultadoDatos"].Rows)
                {
                    nombresVendedores.Add(row["nombreVendedor"].ToString());
                }
            }

            return nombresVendedores;
        }

        public List<string> ObtenerNombresTecnicos()
        {
            List<string> nombresTecnicos = new List<string>();
            string consulta = "SELECT nombreTecnico FROM tblTecnico";

            // Usar el método ejecutarSelect para obtener el DataSet
            DataSet ds = dt.ejecutarSelect(consulta);

            // Verificar si el DataSet tiene datos
            if (ds != null && ds.Tables["resultadoDatos"].Rows.Count > 0)
            {
                foreach (DataRow row in ds.Tables["resultadoDatos"].Rows)
                {
                    nombresTecnicos.Add(row["nombreTecnico"].ToString());
                }
            }

            return nombresTecnicos;
        }

    }
}
