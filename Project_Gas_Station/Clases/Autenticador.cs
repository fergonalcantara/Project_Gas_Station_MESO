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
            Trabajador
        }

        private string usuarioAdmin = "admin";
        private string contraseniaAdmin = "admin12345*";
        private string usuarioTrabajador = "trabajador";
        private string contraseniaTrabajador = "totoGas#";

        public TipoDeUsuario Autenticar(string usuario, string contrasenia)
        {
            if (usuario == usuarioAdmin && contrasenia == contraseniaAdmin)
            {
                return TipoDeUsuario.Admin;
            }
            else if (usuario == usuarioTrabajador && contrasenia == contraseniaTrabajador)
            {
                return TipoDeUsuario.Trabajador;
            }
            return TipoDeUsuario.Ninguno;
        }
    }
}
