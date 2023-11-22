using DAL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class SesionUsuario : Sesion<BE.SesionUsuario>
    {
        private readonly SesionUsuarioMP _mapper;

        public SesionUsuario() 
        {
            _mapper = new SesionUsuarioMP();
        }

        public BE.SesionUsuario NuevaSesionUsuario(BE.Usuario usuario)
        {
            BE.SesionUsuario sesion = new BE.SesionUsuario
            {
                Usuario = usuario,
                Inicio = DateTime.Now,
            };

            return sesion;
        }

        public override void Guardar(BE.SesionUsuario obj)
        {
            obj.Final = DateTime.Now;
            _mapper.Insertar(obj);
        }

        public override List<BE.SesionUsuario> ObtenerTodas()
        {
            return _mapper.Listar();
        }
    }
}
