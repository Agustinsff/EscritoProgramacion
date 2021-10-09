using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaLogica
{
    public class UsuarioControlador
    {
        public static string Login(string id, string pass)
        {
            UsuarioModelo p = new UsuarioModelo() { id = id, pass = pass };
            if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(pass))
            {
                return "Debe rellenar todos los campos";
            }
            else if (p.Login() == false)
            {
                return "el usuario y/o la contraseña son incorrectos";
            }
            else
            {
                return "";
            }
        }
    }
}
