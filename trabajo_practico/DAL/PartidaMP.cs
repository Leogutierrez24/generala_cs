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
    public class PartidaMP : Mapper<BE.Partida>
    {
        private readonly UsuarioMP _mapper = new UsuarioMP();

        private readonly List<BE.Usuario> _usuarios;

        public PartidaMP()
        {
            _usuarios = _mapper.Listar();
        }

        public override void Actualizar(Partida obj)
        {
            throw new NotImplementedException();
        }

        public override void Borrar(int id)
        {
            throw new NotImplementedException();
        }

        public override void Insertar(Partida obj)
        {
            acceso.Conectar();
            List<SqlParameter> parametros = new List<SqlParameter>
            {
                acceso.CrearParametro(obj.Jugador01.Id, "@usuario01_id"),
                acceso.CrearParametro(obj.Jugador02.Id, "@usuario02_id"),
                acceso.CrearParametro(obj.Inicio.ToString(), "@inicio"),
                acceso.CrearParametro(obj.Fin.ToString(), "@final"),
            };
            acceso.Escribir("SESION_PARTIDA_ALTA", parametros);
            acceso.Desconectar();
        }

        public override List<Partida> Listar()
        {
            List<BE.Partida> partidas = new List<BE.Partida>();
            acceso.Conectar();
            DataTable tabla = acceso.Leer("SESION_PARTIDA_LISTAR");
            acceso.Desconectar();

            if (tabla != null)
            {
                foreach (DataRow registro in tabla.Rows)
                {
                    BE.Partida sesion = new BE.Partida();
                    sesion.Id = int.Parse(registro["id"].ToString());
                    sesion.Jugador01 = _usuarios.Find(usuario => usuario.Id == int.Parse(registro["id_usuario01"].ToString()));
                    sesion.Jugador02 = _usuarios.Find(usuario => usuario.Id == int.Parse(registro["id_usuario02"].ToString()));
                    sesion.Inicio = Convert.ToDateTime(registro["inicio"].ToString());
                    sesion.Fin = Convert.ToDateTime(registro["final"].ToString());
                    partidas.Add(sesion);
                }
            }

            return partidas;
        }
    }
}
