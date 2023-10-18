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

        private List<Jugador> _jugadores;

        public List<Jugador> Jugadores
        {
            get { return _jugadores; }
            set { _jugadores = value; }
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
