using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class SesionUsuario : Sesion<BE.SesionUsuario>
    {
        public BE.SesionUsuario NuevaSesionUsuario(int usuarioID)
        {
            BE.SesionUsuario sesion = new BE.SesionUsuario
            {
                UsuarioID = usuarioID,
                Inicio = DateTime.Now,
            };

            return sesion;
        }

        public override void Guardar(BE.SesionUsuario obj)
        {
            obj.Final = DateTime.Now;
            SesionUsuarioMP mapper = new SesionUsuarioMP();
            mapper.Insertar(obj);
        }

        public override List<BE.SesionUsuario> ObtenerTodas()
        {
            throw new NotImplementedException();
        }
    }
}
