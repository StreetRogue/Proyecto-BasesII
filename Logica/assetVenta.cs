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
    }
}
