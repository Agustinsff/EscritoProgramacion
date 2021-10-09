using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class UsuarioModelo : Modelo
    {
        public string id;
        public string pass;

        public bool Login()
        {
            comando.CommandText = "SELECT usuarios.id FROM usuarios WHERE usuarios.id = @id AND usuarios.pass = @pass";

            comando.Parameters.AddWithValue("@id", id);
            comando.Parameters.AddWithValue("@pass", pass);

            comando.Prepare();
            reader = comando.ExecuteReader();

            if (reader.HasRows)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
