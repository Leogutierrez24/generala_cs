using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GENERALA.Clases
{
    public class Jugador
    {
        private string _id;
        public string Id
        {
            get { return _id; }
        }

        private string _nombre;
        public string Nombre
        {
            get { return _nombre; }
        }

        private Puntaje _puntos;
        public Puntaje Puntos
        {
            get { return _puntos; }
        }

        private List<Categoria> _categorias = new List<Categoria>();
        public List<Categoria> Categorias
        {
            get { return _categorias; }
        }

        private List<Dado> _dadosApartados = new List<Dado>();
        public List<Dado> DadosApartados
        {
            get { return _dadosApartados; }
        }

        private int _puntosActuales;
        public int PuntosActuales
        {
            get { return _puntosActuales; }
        }

        private int _tiros;
        public int Tiros
        {
            get { return _tiros; }
        }

        public Jugador(string id)
        {
            _id = id;
            InicializarCategorias();
        }

        public Jugador(string id, string nombre)
        {
            _id = id;
            _nombre = nombre;
            InicializarCategorias();
        }

        private void InicializarCategorias()
        {
            _categorias = new List<Categoria>
            {
                new Categoria(TipoCategoria.Uno),
                new Categoria(TipoCategoria.Dos),
                new Categoria(TipoCategoria.Tres),
                new Categoria(TipoCategoria.Cuatro),
                new Categoria(TipoCategoria.Cinco),
                new Categoria(TipoCategoria.Escalera),
                new Categoria(TipoCategoria.Full),
                new Categoria(TipoCategoria.Poker),
                new Categoria(TipoCategoria.Generala)
            };
        }

        public void CambiarNombre(string nombre)
        {
            _nombre = nombre;
        }

        private void TirarDados(List<Dado> dados)
        {
            if (_tiros != 0)
            {
                dados.ForEach(dado => dado.ObtenerValor());
                _tiros--;
            }
        }

        public void SeleccionarDados(List<Dado> dados)
        {
            dados.ForEach((dado) =>
            {
                if (_dadosApartados.Count != 0)
                {
                    if (!_dadosApartados.Contains(dado))
                    {
                        _dadosApartados.Add(dado);
                    }
                } else
                {
                    _dadosApartados = dados;
                }
            });
        }

        public void QuitarDados(List<Dado> dados)
        {
            dados.ForEach((dado) =>
            {
                _dadosApartados.Remove(dado);
            });
        }

        public Categoria CerrarCategoria(Categoria categoria)
        {
            Categoria categoriaPorCerrar = _categorias.Find(i => i.Tipo == categoria.Tipo);
            categoriaPorCerrar.Cerrar();
            return categoriaPorCerrar;
        }

        public void EstablecerTurnos()
        {
            _tiros = 3;
        }
    }
}
