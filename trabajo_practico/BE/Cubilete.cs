using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Cubilete
    {
        private List<Dado> _dados = new List<Dado>();
        public List<Dado> Dados
        {
            get { return _dados; }
            set { _dados = value; }
        }

        private bool _vacio = true;
        public bool Vacio
        {
            get { return _vacio; }
            set { _vacio = value; }
        }
    }
}
