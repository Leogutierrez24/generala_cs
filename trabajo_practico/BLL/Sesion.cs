using DAL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Sesion
    {
        private readonly SesionMP _mapper;

        public Sesion() 
        {
            _mapper = new SesionMP();
        }

        public BE.Sesion NuevaSesion(BE.Usuario usuario)
        {
            BE.Sesion sesion = new BE.Sesion
            {
                Usuario = usuario,
                Inicio = DateTime.Now,
            };

            return sesion;
        }

        public void Cerrar(BE.Sesion sesion)
        {
            sesion.Final = DateTime.Now;
            this.Guardar(sesion);
            sesion = null;
        }

        public void Guardar(BE.Sesion obj)
        {
            obj.Final = DateTime.Now;
            _mapper.Insertar(obj);
        }

        public List<BE.Sesion> ObtenerTodas()
        {
            return _mapper.Listar();
        }
    }
}
