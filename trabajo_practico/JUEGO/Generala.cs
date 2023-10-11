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

        public void IniciarJuego()
        {

        }

        public void FinalizarJuego()
        {

        }

        public void AgregarJugador(Jugador nuevoJugador)
        {
            _jugadores.Add(nuevoJugador);
        }

        public void CambiarTurnoJugador()
        {
            Jugador jugadorEnJuego = _tablero.JugadorEnJuego;
            Jugador nuevoJugador;
            int indexJugador = _jugadores.IndexOf(jugadorEnJuego);

            if (indexJugador == _jugadores.Count - 1)
            {
                nuevoJugador = _jugadores[0];
            } else
            {
                nuevoJugador = _jugadores[indexJugador + 1];
            }

            EstablecerTurnoJugador(nuevoJugador);
        }

        public void EstablecerTurnoJugador(Jugador jugador)
        {
            jugador.EstablecerTiros();
            _tablero.JugadorEnJuego = jugador;
        }

        private void EstablecerPuntuacion(Categoria categoria)
        {
            
        }

        public void CerrarCategoria(Categoria categoria)
        {
            if (!categoria.Cerrada)
            {
                EstablecerPuntuacion(categoria);
                categoria.Cerrar();
            }
        }

        public void ComprobarTiro(List<Dado> dados)
        {

        }
    }
}
