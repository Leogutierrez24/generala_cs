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
        public void Registrar(BE.Usuario usuario)
        {
            UsuarioMP mapper = new UsuarioMP();
            mapper.Insertar(usuario);
        }
    }
}
