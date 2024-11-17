using Oracle.ManagedDataAccess.Client;
using ProyectoBasesII.AccesoDatos;
using System;
using System.Collections.Generic;
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
            int resultado = 0;

            string consulta;

            if (cargoEmpleado == "Técnico")
            {
                consulta = "INSERT INTO tblTecnico (nombreTecnico, apellidoTecnico, estadoTecnico, salarioVendedor, fechaContratacionTecnico) values ('" + nombreEmpleado + "','" + apellidoEmpleado + "','activo',3000.00,CURRENT_TIMESTAMP)";
            }
            else if (cargoEmpleado == "Vendedor")
            {
                consulta = "INSERT INTO tblVendedor (nombreVendedor, apellidoVendedor, estadoVendedor, salarioVendedor, fechaContratacionVendedor) values ('" + nombreEmpleado + "','" + apellidoEmpleado + "','activo',3000.00,CURRENT_TIMESTAMP)";
            }
            else
            {
                throw new ArgumentException("El cargo del empleado no es válido. Debe ser 'Técnico' o 'Vendedor'.");
            }

            resultado = dt.ejecutarDML(consulta);

            return resultado;

            
        }


    }
}
