using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Usuario
    {
        public static BE.Usuario CrearUsuario(string usuario, string password)
        {
            BE.Usuario nuevoUsuario = new BE.Usuario
            {
                Nombre = usuario,
                Password = password
            };
            return nuevoUsuario;
        }

        public void Registrar(BE.Usuario usuario)
        {
            UsuarioMP mapper = new UsuarioMP();
            mapper.Insertar(usuario);
        }

        public BE.Usuario Ingresar(BE.Usuario usuario)
        {
            UsuarioMP mapper = new UsuarioMP();
            BE.Usuario usuarioEncontrado = mapper.Obtener(usuario.Nombre, usuario.Password);
            return usuarioEncontrado;
        }

        public void Eliminar(int id)
        {

        }

        public void Modificar(BE.Usuario usuario)
        {

        }
    }
}
