using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Login
{
    public class UsuarioEventArgs : EventArgs
    {
        public BE.Usuario UsuarioRetornado { get; }

        public UsuarioEventArgs(BE.Usuario usuarioRetornado)
        {
            UsuarioRetornado = usuarioRetornado;
        }
    }
}
