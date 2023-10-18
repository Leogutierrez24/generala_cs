using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JUEGO
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
        }

        private bool _terminado = false;
        public bool Terminado
        {
            get { return _terminado; }
        }

        public void Terminar()
        {
            _jugadorEnJuego.Cubilete = null;
            _terminado = true;
        }

        public void EstablecerTiros(int cantidad = 3)
        {
            _tirosDisponibles = cantidad;
        }

        public Tiro JugarTurno()
        {
            Tiro nuevoTiro = null;

            if (_tirosDisponibles != 0 && !_terminado && !_jugadorEnJuego.Cubilete.Vacio)
            {
                List<Dado> dadosObtenidos = _jugadorEnJuego.TirarDados();
                nuevoTiro = new Tiro(_jugadorEnJuego, dadosObtenidos, _tirosDisponibles);
                _tirosDisponibles--;
                VerificarEstado();
            }

            return nuevoTiro;
        }

        private void VerificarEstado()
        {
            if (_tirosDisponibles == 0) _terminado = true;
        }
    }
}
