using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JUEGO
{
    public class TablaPuntos
    {
        private List<Categoria> _categorias = new List<Categoria>();
        public List<Categoria> Categorias
        {
            get { return _categorias; }
            set { _categorias = value; }
        }

        public TablaPuntos()
        {
            List<Categoria> categorias = new List<Categoria> {
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
            _categorias = categorias;
        }

        public void CerrarCategoria(CategoriaJuego nombreCategoria, int puntos)
        {
            int categoriaIndex = _categorias.FindIndex(categoria => categoria.Nombre == nombreCategoria);
            _categorias[categoriaIndex].Cerrar(puntos);
        }

        public int ObtenerPuntajeTotal()
        {
            int resultado = 0;
            _categorias.ForEach(categoria => resultado += categoria.Puntos);
            return resultado;
        }

    }
}
