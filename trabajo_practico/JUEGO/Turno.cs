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
            set { _tirosDisponibles = value; }
        }

        private bool _terminado = false;
        public bool Terminado
        {
            get { return _terminado; }
        }

        public Turno(Jugador jugador, int tirosDisponibles = 3)
        {
            _jugadorEnJuego = jugador;
            _tirosDisponibles = tirosDisponibles;
        }

        public void Terminar()
        {
            _tirosDisponibles = 0;
            _terminado = true;
        }

        public Tiro JugarTurno()
        {
            Tiro nuevoTiro = null;

            if (_tirosDisponibles != 0 && !_terminado && !_jugadorEnJuego.Cubilete.Vacio)
            {
                List<Dado> dadosObtenidos = _jugadorEnJuego.TirarDados();
                nuevoTiro = new Tiro(_jugadorEnJuego, dadosObtenidos, _tirosDisponibles);
                _tirosDisponibles--;
                VerificarTirosDisponibles();
            }

            return nuevoTiro;
        }

        private void VerificarTirosDisponibles()
        {
            if (_tirosDisponibles == 0) Terminar();
        }
    }
}
