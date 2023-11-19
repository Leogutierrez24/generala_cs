using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Turno
    {
        private Jugador _jugadorEnJuego;
        public Jugador JugadorEnJuego
        {
            get { return _jugadorEnJuego; }
            set { _jugadorEnJuego = value; }
        }

        private int _tirosDisponibles;
        public int TirosDisponibles
        {
            get { return _tirosDisponibles; }
            set { _tirosDisponibles = value; }
        }

        private bool _terminado = false;
        public bool Terminado
        {
            get { return _terminado; }
            set { _terminado = value; }
        }

        private Categoria _categoriaCerrada;
        public Categoria CategoriaCerrada
        {
            get { return _categoriaCerrada; }
            set { _categoriaCerrada = value; }
        }
    }
}
