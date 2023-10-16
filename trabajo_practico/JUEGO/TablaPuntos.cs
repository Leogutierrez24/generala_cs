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

        private int _posicionJuego = 0;
        public int PosicionJuego
        {
            get { return _posicionJuego; }
            set { _posicionJuego = value; }
        }

        public TablaPuntos(List<Categoria> categorias) 
        {
            _categorias = categorias;
        }

        public int ObtenerPuntajeTotal()
        {
            int resultado = 0;
            _categorias.ForEach(categoria => resultado += categoria.Puntos);
            return resultado;
        }

    }
}
