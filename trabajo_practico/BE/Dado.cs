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
            set { _id = value; }
        }

        private int _valor;
        public int Valor
        {
            get { return _valor; }
            set { _valor = value; }
        }
    }
}
