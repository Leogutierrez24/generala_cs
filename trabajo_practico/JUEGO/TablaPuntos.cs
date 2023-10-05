using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JUEGO
{
    public class TablaPuntos
    {
        private readonly List<Categoria> _categorias = new List<Categoria>();

        public TablaPuntos() 
        {
            _categorias = new List<Categoria>
            {
                new Categoria(CategoriaJuego.Uno),
                new Categoria(CategoriaJuego.Dos),
                new Categoria(CategoriaJuego.Tres),
                new Categoria(CategoriaJuego.Cuatro),
                new Categoria(CategoriaJuego.Cinco),
                new Categoria(CategoriaJuego.Seis),
                new Categoria(CategoriaJuego.Escalera),
                new Categoria(CategoriaJuego.Full),
                new Categoria(CategoriaJuego.Poker),
                new Categoria(CategoriaJuego.Generala),
            };
        }

        public int ObtenerPuntajeTotal()
        {
            int resultado = 0;
            _categorias.ForEach(categoria => resultado += categoria.Puntos);
            return resultado;
        }

    }
}
