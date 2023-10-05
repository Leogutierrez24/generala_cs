using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JUEGO
{
    public class Generala
    {
        private Tablero _tablero = new Tablero();
        public Tablero Tablero
        {
            get { return _tablero; }
        }

        private List<Jugador> _jugadores = new List<Jugador>();
        public List<Jugador> Jugadores
        {
            get { return _jugadores; }
        }

        public void NuevoJuego()
        {

        }

        public void FinalizarJuego()
        {

        }

        public void AgregarJugador(Jugador nuevoJugador)
        {
            _jugadores.Add(nuevoJugador);
        }

        public void EstablecerTurnoJugador(Jugador jugador)
        {
            jugador.EstablecerTiros();
            _tablero.JugadorEnJuego = jugador;
        }

        public void ComprobarTiro(List<Dado> dados)
        {

        }
    }
}
