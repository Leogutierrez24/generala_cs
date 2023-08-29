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

        private List<Dado> _dados = new List<Dado>();
        public List<Dado> Dados
        {
            get { return _dados; }
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

        public void TirarDados(List<Dado> dados)
        {
            dados.ForEach(dado => dado.ObtenerValor());
        }
    }
}
