using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Tablero
    { 
        public static void PonerDadosEnTablero(BE.Tablero tablero, List<BE.Dado> dados)
        {
            dados.ForEach(dado => tablero.DadosEnTablero.Add(dado));
        }

        public static void QuitarDadosTablero(BE.Tablero tablero)
        {
            tablero.DadosEnTablero.Clear();
        }

        public static void QuitarDadoTablero(BE.Tablero tablero, List<BE.Dado> dados)
        {
            dados.ForEach(dado => tablero.DadosEnTablero.Remove(dado));
        }

        public static void ApartarDados(BE.Tablero tablero, List<BE.Dado> dados)
        {
            dados.ForEach(dado => tablero.DadosApartados.Add(dado));
            tablero.DadosApartados.ForEach(dadoApartado => tablero.DadosEnTablero.Remove(dadoApartado));
        }

        public static void RestablecerDadosApartados(BE.Tablero tablero)
        {
            while (tablero.DadosApartados.Count != 0)
            {
                tablero.DadosEnTablero.Add(tablero.DadosApartados[0]);
                tablero.DadosApartados.RemoveAt(0);
            }
        }
    }
}
