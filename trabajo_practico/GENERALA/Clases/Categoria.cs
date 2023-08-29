using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GENERALA.Clases
{
    public class Categoria
    {
        private readonly TipoCategoria _tipo;
        public TipoCategoria Tipo
        {
            get { return _tipo; }
        }

        public bool _cerrada;
        public bool Cerrada
        {
            get { return _cerrada; }
        }

        public Categoria(TipoCategoria tipo)
        {
            _tipo = tipo;
            _cerrada = false;
        }

        public void Cerrar()
        {
            _cerrada = true;
        }
    }
}
