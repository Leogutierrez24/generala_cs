using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Categoria
    {
        private CategoriaJuego _nombre;
        public CategoriaJuego Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        private TipoCategoria _tipo;
        public TipoCategoria Tipo
        {
            get { return _tipo; }
            set { _tipo = value; }
        }

        private int _puntos = 0;
        public int Puntos
        {
            get { return _puntos; }
            set { _puntos = value; }    
        }

        private bool _cerrada = false;
        public bool Cerrada
        {
            get { return _cerrada; }
            set { _cerrada = value; }
        }
    }
}
