using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JUEGO
{
    public class Bitacora
    {
        private List<Tiro> _tirosRealizados = new List<Tiro>();

        public List<Tiro> TirosRealizados
        {
            get { return _tirosRealizados; }
        }

        public void Registrar(Tiro tiro)
        {
            _tirosRealizados.Add(tiro);
        }
    }
}
