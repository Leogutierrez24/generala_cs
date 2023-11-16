using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Generala
    {
        private List<Dado> _dados = new List<Dado>();
        public List<Dado> Dados
        {
            get { return _dados; }
            set { _dados =  value; }
        }

        private readonly Cubilete _cubilete = new Cubilete();
        public Cubilete Cubilete
        {
            get { return _cubilete; }
        }

        private List<Categoria> _categorias = new List<Categoria>();
        public List<Categoria> Categorias
        {
            get { return _categorias; }
            set { _categorias = value; }
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
            set { _turno = value; }
        }

        private Tablero _tablero;
        public Tablero Tablero
        {
            get { return _tablero; }
            set { _tablero = value; }
        }

        private Jugador _ganador;
        public Jugador Ganador
        {
            get { return _ganador; }
            set { _ganador = value; }
        }

        private bool _generalaServida = false;
        public bool GeneralaServida
        {
            get { return _generalaServida; }
            set { _generalaServida = value; }
        }
    }
}
