using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JUEGO
{
    public class Dado
    {
        private int _id;
        public int Id
        {
            get { return _id; }
        }

        private int _valor;
        public int Valor
        {
            get { return _valor; }  
        }

        public Dado(int id)
        {
            _id = id;
            _valor = 0;
        }

        public void Tirar()
        {
            Random valorAleatorio = Helper.random;
            _valor = valorAleatorio.Next(0, 7);
        }
    }
}
