using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class SesionMP : Mapper<BE.Sesion>
    {
        private readonly UsuarioMP _mapper = new UsuarioMP();

        private readonly List<BE.Usuario> _usuarios;

        public SesionMP()
        {
            _usuarios = _mapper.Listar();
        }

        public override void Actualizar(Sesion obj)
        {
            throw new NotImplementedException();
        }

        public override void Borrar(int id)
        {
            throw new NotImplementedException();
        }

        public override void Insertar(Sesion obj)
        {
            acceso.Conectar();
            List<SqlParameter> parametros = new List<SqlParameter>
            {
                acceso.CrearParametro(obj.Usuario.Id, "@usuarioID"),
                acceso.CrearParametro(obj.Inicio.ToString(), "@inicio"),
                acceso.CrearParametro(obj.Final.ToString(), "@final"),
            };
            acceso.Escribir("SESION_USUARIO_ALTA", parametros);
            acceso.Desconectar();
        }

        public override List<BE.Sesion> Listar()
        {
            List<BE.Sesion> sesiones = new List<BE.Sesion>();
            acceso.Conectar();
            DataTable tabla = acceso.Leer("SESION_USUARIO_LISTAR");
            acceso.Desconectar();

            if (tabla.Rows.Count > 0)
            {
                foreach(DataRow registro in tabla.Rows)
                {
                    BE.Sesion sesion = new BE.Sesion();
                    sesion.Id = int.Parse(registro["id"].ToString());
                    sesion.Usuario = _usuarios.Find(usuario => usuario.Id == int.Parse(registro["usuario_id"].ToString()));
                    sesion.Inicio = Convert.ToDateTime(registro["inicio"].ToString());
                    sesion.Final = Convert.ToDateTime(registro["final"].ToString());
                    sesiones.Add(sesion);
                }
            }

            return sesiones;
        }
    }
}
