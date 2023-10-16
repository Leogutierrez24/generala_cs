using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JUEGO
{
    public class Tablero
    {
        private readonly Bitacora _bitacora = new Bitacora();
        public Bitacora Bitacora
        {
            get { return _bitacora; }
        }

        public void RegistrarTiro(Tiro nuevoTiro)
        {
            _bitacora.Registrar(nuevoTiro);
        }
    }
}
