using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace CapaDatos
{
    public class Modelo
    {
        protected string IpDb;
        protected string NombreDb;
        protected string UsuarioDb;
        protected string PasswordDb;

        protected MySqlConnection conexion;
        protected MySqlCommand comando;
        protected MySqlDataReader reader;

        public Modelo()
        {
            inicializarConexion();
            conexion = new MySqlConnection("server=" + IpDb + "; userid=" + UsuarioDb + "; password=" + PasswordDb + "; database=" + NombreDb);
            comando = new MySqlCommand();
            comando.Connection = conexion;
            conexion.Open();
        }

        private void inicializarConexion()
        {
            IpDb = "localhost";
            NombreDb = "escrito";

            
            UsuarioDb = "root";
            PasswordDb = "root";
        }
    }
}
