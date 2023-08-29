using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GENERALA.Clases
{
    public class Dado
    {
        private int _numero;
        public int Numero
        {
            get { return _numero; }
        }

        private int _valor;
        public int Valor
        {
            get { return _valor; }
        }

        public Dado() { }

        public Dado(int numero) 
        {
            _numero = numero;
            _valor = 0;
        }

        public void ObtenerValor()
        {
            Random r = new Random();
            _valor = r.Next(1, 7);
        }

        public void RestablecerValor()
        {
            _valor = 0;
        }
    }
}
