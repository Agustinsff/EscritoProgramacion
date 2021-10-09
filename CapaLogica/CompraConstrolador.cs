using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaLogica
{
    public class CompraConstrolador
    {
        public static string Compra(int id_producto, string cantidad)
        {
            try
            {
                int cant = int.Parse(cantidad);
            }
            catch
            {
                return "La cantidad es invalida";
            }

            CompraModelo p = new CompraModelo() { id_producto = id_producto , cantidad = int.Parse(cantidad) };
            if (int.Parse(cantidad) > 0)
            {
                return p.Compra();
            }

            else
            {
                return "La cantidad debe ser mayor a 0";
            }
        }
    }
}
