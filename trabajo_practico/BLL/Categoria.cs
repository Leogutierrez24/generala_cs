using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Categoria
    {
        public static BE.Categoria CrearCategoria(BE.CategoriaJuego nombre, BE.TipoCategoria tipo)
        {
            BE.Categoria categoria = new BE.Categoria();
            categoria.Nombre = nombre;
            categoria.Tipo = tipo;
            return categoria;
        }

        public static void Cerrar(BE.Categoria categoria, int puntos)
        {
            categoria.Puntos = puntos;
            categoria.Cerrada = true;
        }

        public static void Restablecer(BE.Categoria categoria)
        {
            categoria.Puntos = 0;
            categoria.Cerrada = false;
        }
    }
}
