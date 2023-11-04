using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JUEGO
{
    public class Tiro
    {
        private readonly List<Dado> _dadosJugados;

        public List<Dado> DadosJugados
        {
            get { return  _dadosJugados; }
        }

        private readonly Jugador _jugador;
        public Jugador Jugador
        {
            get { return _jugador; }
        }

        private readonly int _numeroDeTiro;
        public int NumeroDeTiro
        {
            get { return _numeroDeTiro; }
        }

        private CategoriaServida _categoriaServida = CategoriaServida.Ninguna;
        public CategoriaServida CategoriaServida
        {
            get { return _categoriaServida; }
            set { _categoriaServida = value; }
        }

        public Tiro(Jugador jugador, List<Dado> dadosJugados, int numeroTiro)
        {
            _jugador = jugador;
            _dadosJugados = dadosJugados;
            _numeroDeTiro = numeroTiro;
        }
    }
}
