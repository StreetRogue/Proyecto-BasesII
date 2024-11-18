﻿using Oracle.ManagedDataAccess.Client;
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



        public DataSet buscarProveedor(int idProveedor)
        {
            DataSet ds = new DataSet();
            
            // Crear los parámetros para el procedimiento almacenado
            OracleParameter[] parametros = new OracleParameter[]
            {
        new OracleParameter("p_idProveedor", OracleDbType.Int32) { Value = idProveedor },
        new OracleParameter("p_proveedor", OracleDbType.RefCursor) { Direction = ParameterDirection.Output },
        new OracleParameter("p_vehiculo", OracleDbType.RefCursor) { Direction = ParameterDirection.Output }
            };




            // Ejecutar el procedimiento almacenado y obtener los datos
            return dt.ejecutarSPConCursores("Consultar_informacion_proveedor", parametros);
        }

        public DataSet buscarProveedorGeneral()
        {
            DataSet ds = new DataSet();

            // Configurar los parámetros del procedimiento almacenado
            OracleParameter[] parametros = new OracleParameter[]
            {
            new OracleParameter("p_proveedor", OracleDbType.RefCursor, ParameterDirection.Output),
            new OracleParameter("p_vehiculo", OracleDbType.RefCursor, ParameterDirection.Output)
            };

            // Ejecutar el procedimiento almacenado para obtener los datos
            ds = dt.ejecutarSPConCursores("Consultar_todos_los_proveedores", parametros);


            // Ejecutar el procedimiento almacenado y obtener los datos
            return ds;
        }

    }
}
