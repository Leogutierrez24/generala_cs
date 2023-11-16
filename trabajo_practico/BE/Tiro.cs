using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Tiro
    {
        private List<Dado> _dadosJugados;
        public List<Dado> DadosJugados
        {
            get { return _dadosJugados; }
            set { _dadosJugados = value; }
        }

        private Jugador _jugador;
        public Jugador Jugador
        {
            get { return _jugador; }
            set { _jugador = value; }
        }

        private int _numeroDeTiro;
        public int NumeroDeTiro
        {
            get { return _numeroDeTiro; }
            set { _numeroDeTiro = value; }
        }

        private CategoriaServida _categoriaServida = CategoriaServida.Ninguna;
        public CategoriaServida CategoriaServida
        {
            get { return _categoriaServida; }
            set { _categoriaServida = value; }
        }
    }
}
