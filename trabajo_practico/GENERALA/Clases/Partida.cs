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

        public Partida(List<Jugador> jugadores)
        {
            _id = Guid.NewGuid().ToString();
            _jugadores = jugadores;
            _dados = new List<Dado> { 
                new Dado(1),
                new Dado(2),
                new Dado(3),
                new Dado(4),
                new Dado(5),
            };
        }

        public void Finalizar()
        {
            _finJuego = true;
        }
    }
}
