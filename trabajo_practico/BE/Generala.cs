using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Generala
    {
        private readonly List<Dado> _dados = new List<Dado>();
        public List<Dado> Dados
        {
            get { return _dados; }
        }

        private readonly Cubilete _cubilete = new Cubilete();
        public Cubilete Cubilete
        {
            get { return _cubilete; }
        }

        private readonly List<Categoria> _categorias = new List<Categoria>();
        public List<Categoria> Categorias
        {
            get { return _categorias; }
        }

        private readonly List<Jugador> _jugadores = new List<Jugador>();
        public List<Jugador> Jugadores
        {
            get { return _jugadores; }
        }

        private Turno _turno;
        public Turno Turno
        {
            get { return _turno; }
        }

        private readonly Tablero _tablero;
        public Tablero Tablero
        {
            get { return _tablero; }
        }

        private Jugador _ganador;
        public Jugador Ganador
        {
            get { return _ganador; }
        }

        private bool _generalaServida = false;
    }
}
