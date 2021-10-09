using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CompraModelo : Modelo
    {
        int id;
        public int id_producto;
        public int cantidad;
        DateTime fecha;

        public string Compra()
        {
            comando.CommandText = "SELECT id, stock FROM souvenirs WHERE id = @id AND stock > 0";

            comando.Parameters.AddWithValue("@id", id_producto);

            comando.Prepare();
            reader = comando.ExecuteReader();

            if (!reader.HasRows)
            {
                return "Producto sin stock";
            }
            else
            {
                while (reader.Read())
                {
                    if (cantidad > int.Parse(reader["stock"].ToString()))
                    {
                        return "No hay suficiente stock para la compra";
                    }
                }

                reader.Close();

                comando.CommandText = "INSERT INTO compras (id_producto, cantidad, fecha) VALUES(@id, @cantidad, current_timestamp)";

                comando.Parameters.AddWithValue("@cantidad", cantidad);

                comando.Prepare();
                comando.ExecuteNonQuery();

                comando.CommandText = "UPDATE souvenirs SET stock = stock - @cantidad WHERE id = @id";

                comando.Prepare();
                comando.ExecuteNonQuery();

                return "";
            }
        }
    }
}
