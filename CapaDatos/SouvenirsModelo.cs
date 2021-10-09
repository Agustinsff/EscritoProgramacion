using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class SouvenirsModelo : Modelo
    {
        public string nombre;
        public string descripcion;
        public int id;
        public int stock;
        public int precio;
        DateTime fecha;

        public DataTable Listar()
        {
            comando.CommandText = "SELECT id, nombre, descripcion, stock, precio, fecha FROM souvenirs";

            comando.Prepare();
            reader = comando.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(reader);

            return dt;
        }

        public void Alta()
        {
            comando.CommandText = "INSERT INTO souvenirs (nombre, descripcion, stock, precio, fecha) VALUES (@nombre, @descripcion, @stock, @precio, current_timestamp)";

            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@descripcion", descripcion);
            comando.Parameters.AddWithValue("@stock", stock);
            comando.Parameters.AddWithValue("@precio", precio);

            comando.Prepare();
            comando.ExecuteNonQuery();
        }

        public void Eliminar()
        {
            comando.CommandText = "DELETE FROM souvenirs WHERE id = @id";

            comando.Parameters.AddWithValue("@id", id);

            comando.Prepare();
            comando.ExecuteNonQuery();
        }

        public void Modificar()
        {
            comando.CommandText = "UPDATE souvenirs SET nombre = @nombre, descripcion = @descripcion, stock = @stock, precio = @precio WHERE id = @id";

            comando.Parameters.AddWithValue("@id", id);
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@descripcion", descripcion);
            comando.Parameters.AddWithValue("@stock", stock);
            comando.Parameters.AddWithValue("@precio", precio);

            comando.Prepare();
            comando.ExecuteNonQuery();
        }
    }
}
