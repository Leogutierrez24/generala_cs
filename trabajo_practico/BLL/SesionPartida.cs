using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class SesionPartida : Sesion<BE.SesionPartida>
    {
        private readonly SesionPartidaMP _mapper;

        public SesionPartida()
        {
            _mapper = new SesionPartidaMP();
        }

        public BE.SesionPartida NuevaPartida(BE.Usuario usuario01, BE.Usuario usuario02)
        {
            BE.SesionPartida sesion = new BE.SesionPartida
            {
                Usuario01 = usuario01,
                Usuario02 = usuario02,
                Inicio = DateTime.Now,
            };

            return sesion;
        }

        public override void Guardar(BE.SesionPartida obj)
        { 
            obj.Final = DateTime.Now;
            _mapper.Insertar(obj);
        }

        public override List<BE.SesionPartida> ObtenerTodas()
        {
            return _mapper.Listar();
        }
    }
}
