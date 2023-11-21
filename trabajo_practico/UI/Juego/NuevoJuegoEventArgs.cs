using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Juego
{
    public class NuevoJuegoEventArgs : EventArgs
    {
        public bool Resultado { get; }

        public NuevoJuegoEventArgs(bool resultado)
        {
            Resultado = resultado;
        }
    }
}
