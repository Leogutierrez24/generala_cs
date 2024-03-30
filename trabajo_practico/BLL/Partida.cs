using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Partida
    {
        private readonly PartidaMP _mapper;

        private static BLL.Partida instance = null;

        private Partida()
        {
            _mapper = new PartidaMP();
        }

        public static BLL.Partida getInstance()
        {
            if (instance == null) instance = new BLL.Partida();
            return instance;
        }

        public BE.Partida NuevaPartida(BE.Usuario usuario01, BE.Usuario usuario02)
        {
            BE.Partida partida = new BE.Partida
            {
                Jugador01 = usuario01,
                Jugador02 = usuario02,
                Inicio = DateTime.Now,
            };

            return partida;
        }

        public void EstablecerResultado(BE.Partida partida, BE.Usuario ganador, BE.Usuario perdedor)
        {
            partida.Ganador = ganador;
            partida.Perdedor = perdedor;
        }

        public void EstablecerEmpate(BE.Partida partida)
        {
            partida.Empate = true;
        }

        public void Finalizar(BE.Partida partida)
        {
            if (!partida.Empate && (partida.Ganador != null && partida.Perdedor != null) || partida.Empate)
            {
                partida.Fin = DateTime.Now;
                this.Guardar(partida);
            }            
        }

        public void Guardar(BE.Partida obj)
        { 
            _mapper.Insertar(obj);
        }

        public List<BE.Partida> ObtenerTodas()
        {
            return _mapper.Listar();
        }
    }
}
