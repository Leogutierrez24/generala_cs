using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GENERALA.Clases
{
    public class Partida
    {
        private string _id;
        public string Id 
        { 
            get { return _id; } 
        }

        private List<Jugador> _jugadores = new List<Jugador>();
        public List<Jugador> Jugadores
        {
            get { return _jugadores; }
        }

        private Jugador _jugadorEnJuego;
        public Jugador JugadorEnJuego
        {
            get { return _jugadorEnJuego; }
        }

        private List<Dado> _dados = new List<Dado>();
        public List<Dado> Dados
        {
            get { return _dados; }
        }

        private bool _finJuego = false;
        public bool FinJuego
        {
            get { return _finJuego; }
        }

        public Partida(List<Jugador> jugadores, List<Dado> dados)
        {
            _id = Guid.NewGuid().ToString();
            _jugadores = jugadores;
            _dados = dados;
        }

        public void Finalizar()
        {
            _finJuego = true;
        }

        public void ComprobarJugador()
        {
            if (_jugadorEnJuego.Tiros == 0)
            {
                int indexJugadorActual = _jugadores.IndexOf(JugadorEnJuego);
                _jugadorEnJuego.
            }
        }
    }
}
