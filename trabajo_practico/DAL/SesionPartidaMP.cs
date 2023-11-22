using BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SesionPartidaMP : Mapper<BE.SesionPartida>
    {
        private readonly UsuarioMP _mapper = new UsuarioMP();

        private readonly List<BE.Usuario> _usuarios;

        public SesionPartidaMP()
        {
            _usuarios = _mapper.Listar();
        }

        public override void Actualizar(SesionPartida obj)
        {
            throw new NotImplementedException();
        }

        public override void Borrar(int id)
        {
            throw new NotImplementedException();
        }

        public override void Insertar(SesionPartida obj)
        {
            acceso.Conectar();
            List<SqlParameter> parametros = new List<SqlParameter>
            {
                acceso.CrearParametro(obj.Usuario01.Id, "@usuario01_id"),
                acceso.CrearParametro(obj.Usuario02.Id, "@usuario02_id"),
                acceso.CrearParametro(obj.Inicio.ToString(), "@inicio"),
                acceso.CrearParametro(obj.Final.ToString(), "@final"),
            };
            acceso.Escribir("SESION_PARTIDA_ALTA", parametros);
            acceso.Desconectar();
        }

        public override List<SesionPartida> Listar()
        {
            List<BE.SesionPartida> sesiones = new List<BE.SesionPartida>();
            acceso.Conectar();
            DataTable tabla = acceso.Leer("SESION_PARTIDA_LISTAR");
            acceso.Desconectar();

            if (tabla != null)
            {
                foreach (DataRow registro in tabla.Rows)
                {
                    BE.SesionPartida sesion = new BE.SesionPartida();
                    sesion.Id = int.Parse(registro["id"].ToString());
                    sesion.Usuario01 = _usuarios.Find(usuario => usuario.Id == int.Parse(registro["id_usuario01"].ToString()));
                    sesion.Usuario02 = _usuarios.Find(usuario => usuario.Id == int.Parse(registro["id_usuario02"].ToString()));
                    sesion.Inicio = Convert.ToDateTime(registro["inicio"].ToString());
                    sesion.Final = Convert.ToDateTime(registro["final"].ToString());
                    sesiones.Add(sesion);
                }
            }

            return sesiones;
        }
    }
}
