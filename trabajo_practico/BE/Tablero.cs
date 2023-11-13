using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Tablero
    {
        private List<Dado> _dadosEnTablero = new List<Dado>();
        public List<Dado> DadosEnTablero
        {
            get { return _dadosEnTablero; }
        }

        private List<Dado> _dadosApartados = new List<Dado>();
        public List<Dado> DadosApartados
        {
            get { return _dadosApartados; }
        }

        public Tablero() { }
    }
}
