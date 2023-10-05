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

        public Categoria(CategoriaJuego categoria)
        {
            _nombre = categoria;
        }

        public void EstablecerPuntos(int puntos)
        {
            _puntos = puntos;
        }

        public void Cerrar()
        {
            _cerrada = true;
        }
    }
}
