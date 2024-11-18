using ProyectoBasesII.AccesoDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBasesII.Logica
{
    internal class assetCliente
    {
        Datos dt = new Datos();


        public int registrarCliente(int cedulaCliente,string nombreCliente, string apellidoCliente, string telefonoCliente, string emailCliente, string direccionCliente)
        {
            int resultado = 0;

            string consulta;

            consulta = "INSERT INTO tblCliente (cedulaCliente, nombreCliente, apellidoCliente, telefonoCliente, emailCliente, direccionCliente) values (" + cedulaCliente + ",'" + nombreCliente + "','" + apellidoCliente + "','" + telefonoCliente + "','" + emailCliente + "','" + direccionCliente + "')";

            resultado = dt.ejecutarDML(consulta);

            return resultado;

        }
    }
}
