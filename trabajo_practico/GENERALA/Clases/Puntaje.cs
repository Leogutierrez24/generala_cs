using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GENERALA.Clases
{
    public class Puntaje
    {
        private int _uno;
        public int Uno
        {
            get { return _uno; }
            set { _uno = value; }
        }

        private int _dos;
        public int Dos
        {
            get { return _dos; }
            set { _dos = value; }
        }

        private int _tres;
        public int Tres
        {
            get { return _tres; }
            set { _tres = value; }
        }

        private int _cuatro;
        public int Cuatro
        {
            get { return _cuatro; }
            set { _cuatro = value; }
        }

        private int _cinco;
        public int Cinco
        {
            get { return _cinco; }
            set { _cinco = value; }
        }

        private int _seis;
        public int Seis
        {
            get { return _seis; }
            set { _seis = value; }
        }

        private int _escalera;
        public int Escalera
        {
            get { return _escalera; }
            set { _escalera = value; }
        }

        private int _full;
        public int Full
        {
            get { return _full; }
            set { _full = value; }
        }

        private int _poker;
        public int Poker
        {
            get { return _poker; }
            set { _poker = value; }
        }

        private int _generala;
        public int Generala
        {
            get { return _generala; }
            set { _generala = value; }
        }

        public Puntaje()
        {
            Restablecer();
        }

        public int CalcularTotal()
        {
            return _uno + _dos + _tres + _cuatro + _cinco + _seis + _escalera + _full + _poker + _generala;
        }

        public void Restablecer()
        {
            _uno = 0;
            _dos = 0;
            _tres = 0;
            _cuatro = 0;
            _cinco = 0;
            _seis = 0;
            _escalera = 0;
            _full = 0;
            _poker = 0;
            _generala = 0;
        }
    }
}
