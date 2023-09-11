using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GENERALA.Clases
{
    public class Tablero
    {
        private List<Jugador> _jugadores = new List<Jugador>();
        public List<Jugador> Jugadores
        {
            get { return _jugadores; }
        }

        private List<Dado> _dados = new List<Dado>();
        public List<Dado> Dados
        {
            get { return _dados; }
        }

        private Partida _partida;
        public Partida Partida
        {
            get { return _partida; }
        }

        public Tablero()
        {
            _dados = new List<Dado>
            {
                new Dado(1),
                new Dado(2),
                new Dado(3),
                new Dado(4),
                new Dado(5),
                new Dado(6),
            };
        }

        public void NuevaPartida()
        {
            _partida = new Partida(_jugadores, _dados);
        }

        public void FinPartida()
        {
            _partida.Finalizar();
        }

        public void AgregarJugador(Jugador jugador)
        {
            _jugadores.Add(jugador);
        }

        public void QuitarJugador(Jugador jugador)
        {
            _jugadores.Remove(jugador);
        }
    }
}
