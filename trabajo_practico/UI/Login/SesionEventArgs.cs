using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Login
{
    public class SesionEventArgs : EventArgs
    {
        public BE.Sesion SesionRetornada { get; }

        public SesionEventArgs(BE.Sesion sesionRetornada)
        {
            SesionRetornada = sesionRetornada;
        }
    }
}
