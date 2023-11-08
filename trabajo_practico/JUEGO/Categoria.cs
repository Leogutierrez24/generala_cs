using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JUEGO
{
    public class Categoria
    {
        private readonly CategoriaJuego _nombre;
        public CategoriaJuego Nombre
        {
            get { return _nombre; }
        }

        private readonly TipoCategoria _tipo;
        public TipoCategoria Tipo
        {
            get { return _tipo; }
        }

        private int _puntos = 0;
        public int Puntos
        {
            get { return _puntos; }
        }

        private bool _cerrada = false;
        public bool Cerrada
        {
            get { return _cerrada; }
        }

        public Categoria(CategoriaJuego nombre, TipoCategoria tipo)
        {
            _nombre = nombre;
            _tipo = tipo;
        }

        public void Cerrar(int puntos)
        {
            _puntos = puntos;
            _cerrada = true;
        }

        public void Restablecer()
        {
            _puntos = 0;
            _cerrada = false;
        }

        public override string ToString()
        {
            return $"{_nombre}";
        }
    }
}
