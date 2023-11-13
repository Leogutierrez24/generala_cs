using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Jugador
    {
        private string _nombre;
        public string Nombre
        {
            get { return _nombre; }
        }

        private Cubilete _cubilete;
        public Cubilete Cubilete
        {
            get { return _cubilete; }
            set { _cubilete = value; }
        }

        private readonly List<Categoria> _categorias;
        public List<Categoria> Categorias
        {
            get { return _categorias; }
        }

        public Jugador(string nombre)
        {
            _nombre = nombre;
            _categorias = new List<Categoria>
            {
                new Categoria(CategoriaJuego.Uno, TipoCategoria.Menor),
                new Categoria(CategoriaJuego.Dos, TipoCategoria.Menor),
                new Categoria(CategoriaJuego.Tres, TipoCategoria.Menor),
                new Categoria(CategoriaJuego.Cuatro, TipoCategoria.Menor),
                new Categoria(CategoriaJuego.Cinco, TipoCategoria.Menor),
                new Categoria(CategoriaJuego.Seis, TipoCategoria.Menor),
                new Categoria(CategoriaJuego.Escalera, TipoCategoria.Mayor),
                new Categoria(CategoriaJuego.Full, TipoCategoria.Mayor),
                new Categoria(CategoriaJuego.Poker, TipoCategoria.Mayor),
                new Categoria(CategoriaJuego.Generala, TipoCategoria.Mayor),
            };
        }
    }
}
