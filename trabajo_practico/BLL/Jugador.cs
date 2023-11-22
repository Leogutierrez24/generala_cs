using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Jugador
    {
        public static BE.Jugador CrearJugador(int id, string nombre)
        {
            BE.Jugador jugador = new BE.Jugador();
            jugador.UsuarioID = id;
            jugador.Nombre = nombre;
            jugador.Categorias = new List<BE.Categoria>
            {
                Categoria.CrearCategoria(BE.CategoriaJuego.Uno, BE.TipoCategoria.Menor),
                Categoria.CrearCategoria(BE.CategoriaJuego.Dos, BE.TipoCategoria.Menor),
                Categoria.CrearCategoria(BE.CategoriaJuego.Tres, BE.TipoCategoria.Menor),
                Categoria.CrearCategoria(BE.CategoriaJuego.Cuatro, BE.TipoCategoria.Menor),
                Categoria.CrearCategoria(BE.CategoriaJuego.Cinco, BE.TipoCategoria.Menor),
                Categoria.CrearCategoria(BE.CategoriaJuego.Seis, BE.TipoCategoria.Menor),
                Categoria.CrearCategoria(BE.CategoriaJuego.Escalera, BE.TipoCategoria.Mayor),
                Categoria.CrearCategoria(BE.CategoriaJuego.Full, BE.TipoCategoria.Mayor),
                Categoria.CrearCategoria(BE.CategoriaJuego.Poker, BE.TipoCategoria.Mayor),
                Categoria.CrearCategoria(BE.CategoriaJuego.Generala, BE.TipoCategoria.Mayor),
            };
            return jugador;
        }

        public static List<BE.Dado> TirarDados(BE.Cubilete cubilete)
        {
            return Cubilete.TirarDados(cubilete);
        }

        public static void ElegirDados(BE.Cubilete cubilete, List<BE.Dado> dadosElegidos)
        {
            Cubilete.PonerDados(cubilete, dadosElegidos);
        }

        public static int CalcularPuntajeTotal(BE.Jugador jugador)
        {
            int puntaje = 0;
            jugador.Categorias.ForEach(categoria => puntaje += categoria.Puntos);
            return puntaje;
        }
    }
}
