using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Gas_Station.Clases
{
    public class Autenticador
    {
        public enum TipoDeUsuario
        {
            Ninguno,
            Admin,
        }

        private string usuarioAdmin = "admin";
        private string contraseniaAdmin = "admin12345*";

        public TipoDeUsuario Autenticar(string usuario, string contrasenia)
        {
            if (usuario == usuarioAdmin && contrasenia == contraseniaAdmin)
            {
                return TipoDeUsuario.Admin;
            }
            return TipoDeUsuario.Ninguno;
        }
    }
}
