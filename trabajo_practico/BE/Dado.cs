using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
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
            set { _valor = value; }
        }

        public Dado(int id)
        {
            _id = id;
            _valor = 0;
        }

        public override string ToString()
        {
            return $"Nro: {_id} | Valor: {_valor}";
        }
    }
}
