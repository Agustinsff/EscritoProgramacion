using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaLogica
{
    public class SouvenirsControlador
    {
        public static DataTable Listar()
        {
            SouvenirsModelo p = new SouvenirsModelo();
            return p.Listar();
        }

        public static string Alta(string nombre, string descripcion, string stock, string precio)
        {
            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(descripcion) || string.IsNullOrEmpty(stock) || string.IsNullOrEmpty(precio))
            {
                return "Debe rellenar todos los campos";
            }
            else
            {
                try
                {
                    int parsestock = int.Parse(stock);
                    int parseprecio = int.Parse(precio);
                }
                catch
                {
                    return "Stock o precio invalidos";
                }

                SouvenirsModelo p = new SouvenirsModelo() { nombre = nombre, descripcion = descripcion, stock = int.Parse(stock), precio = int.Parse(precio) };
                p.Alta();
                return "";
            }
        }

        public static void Eliminar(int id)
        {
            SouvenirsModelo p = new SouvenirsModelo() { id = id };
            p.Eliminar();
        }

        public static string Modificar(int id, string nombre, string descripcion, string stock, string precio)
        {
            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(descripcion) || string.IsNullOrEmpty(stock) || string.IsNullOrEmpty(precio))
            {
                return "Debe rellenar todos los campos";
            }
            else
            {
                try
                {
                    int parsestock = int.Parse(stock);
                    int parseprecio = int.Parse(precio);
                }
                catch
                {
                    return "Stock o precio invalidos";
                }

                SouvenirsModelo p = new SouvenirsModelo() { id = id, nombre = nombre, descripcion = descripcion, stock = int.Parse(stock), precio = int.Parse(precio) };
                p.Modificar();
                return "";
            }
        }
    }
}
