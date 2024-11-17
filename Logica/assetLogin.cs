using ProyectoBasesII.AccesoDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBasesII.Logica
{
    internal class assetLogin
    {
        Datos dt = new Datos();

        public string ValidarCredenciales(string nombreUsuario, string password)
        {
            string consulta = "SELECT r.nombreRol FROM tblUsuario u " +
                              "JOIN tblRol r ON u.idRol = r.idRol " +
                              "WHERE u.nombreUsuario = '" + nombreUsuario + "' " +
                              "AND u.passwordUsuario = '" + password + "'";

            DataSet ds = dt.ejecutarSelect(consulta);

            // Verifica si se encontró un resultado
            if (ds.Tables[0].Rows.Count > 0)
            {
                // Devuelve el rol del usuario
                return ds.Tables[0].Rows[0]["nombreRol"].ToString();
            }
            else
            {
                // Devuelve cadena vacía si las credenciales no son válidas
                return string.Empty;
            }
        }
    }
}
