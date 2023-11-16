using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Tiro
    {
        public static BE.Tiro CrearTiro(BE.Jugador jugador, List<BE.Dado> dadosJugados, int numeroTiro)
        {
            BE.Tiro tiro = new BE.Tiro
            {
                Jugador = jugador,
                DadosJugados = dadosJugados,
                NumeroDeTiro = numeroTiro,
            };

            return tiro;
        }
    }
}
