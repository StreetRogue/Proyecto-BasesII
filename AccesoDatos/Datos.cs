using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBasesII.AccesoDatos
{
    internal class Datos
    {
        public Datos() { }
        /*paso 1 crear la cadena de conexion */
        string cadenaConexion = "Data Source=localhost;User ID=USER_PROYECTOBASES;Password=oracle;";

        // Paso 2 crear el metodo que ejecuta una operacion DML
        // insert, update, delete

        public int ejecutarDML(string consulta)
        {

            int filasAfectadas = 0;

            //Paso 1 creo una conexion

            OracleConnection miConexion = new OracleConnection(cadenaConexion);

            //Paso 2 Creo un objeto de tipo comando el cual recibe 
            //la instruccion sql que ejecutara la BD

            OracleCommand miComando = new OracleCommand(consulta, miConexion);

            //Paso 3 Abro la conexion

            miConexion.Open();

            //Paso 4 Ejecutar el comando, al ejecutar el comando el devuelve
            //un entero que simboliza el numero de filas que afectaron la 
            //operacion DML(insert,update,delete)

            filasAfectadas = miComando.ExecuteNonQuery();

            //paso 5 cerrar la conexion

            miConexion.Close();

            //Paso 6 retornar el numoer de filas afectadas por la operacion DML 

            return filasAfectadas;

        }
        public DataSet ejecutarSelect(string Consulta)
        {
            /*Paso 1 creo un DataSet vacio */
            DataSet miDS = new DataSet();

            //paso 2 creo un adaptador
            OracleDataAdapter miAdaptador = new OracleDataAdapter(Consulta, cadenaConexion);

            //paso 3 Llenar el DataSet
            miAdaptador.Fill(miDS, "resultadoDatos");

            return miDS;
        }

        public int ejecutarSP(string procedimientoAlmacenado, OracleParameter[] parametros)
        {
            int filasAfectadas = 0;

            // Crear conexión
            OracleConnection miConexion = new OracleConnection(cadenaConexion);

            // Crear comando para ejecutar el procedimiento almacenado
            OracleCommand miComando = new OracleCommand(procedimientoAlmacenado, miConexion);
            miComando.CommandType = CommandType.StoredProcedure;

            // Agregar parámetros al comando
            if (parametros != null)
            {
                foreach (var param in parametros)
                {
                    miComando.Parameters.Add(param);
                }
            }

            // Abrir conexión
            miConexion.Open();

            // Ejecutar el procedimiento almacenado
            filasAfectadas = miComando.ExecuteNonQuery();

            // Cerrar conexión
            miConexion.Close();

            return filasAfectadas;
        }
    }
}
