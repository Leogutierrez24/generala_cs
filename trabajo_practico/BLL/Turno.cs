using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Turno
    {
        public static BE.Turno CrearTurno(BE.Jugador jugador, int tirosDisponibles = 3)
        {
            BE.Turno turno = new BE.Turno();
            turno.JugadorEnJuego = jugador;
            turno.TirosDisponibles = tirosDisponibles;
            return turno;
        }

        public static void Terminar(BE.Turno turno)
        {
            turno.TirosDisponibles = 0;
            turno.Terminado = true;
        }

        public static BE.Tiro JugarTurno(BE.Cubilete cubilete, BE.Turno turno)
        {
            BE.Tiro nuevoTiro = null;

            if (turno.TirosDisponibles != 0 && !turno.Terminado && !cubilete.Vacio)
            {
                List<BE.Dado> dadosObtenidos = Cubilete.TirarDados(cubilete);
                nuevoTiro = Tiro.CrearTiro(turno.JugadorEnJuego, dadosObtenidos, turno.TirosDisponibles);
                turno.TirosDisponibles--;
                VerificarTirosDisponibles(turno);
            }

            return nuevoTiro;
        }

        private static void VerificarTirosDisponibles(BE.Turno turno)
        {
            if (turno.TirosDisponibles == 0) Terminar(turno);
        }
    }
}
