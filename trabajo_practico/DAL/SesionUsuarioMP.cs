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
    public class SesionUsuarioMP : Mapper<BE.SesionUsuario>
    {
        public override void Actualizar(SesionUsuario obj)
        {
            throw new NotImplementedException();
        }

        public override void Borrar(int id)
        {
            throw new NotImplementedException();
        }

        public override void Insertar(SesionUsuario obj)
        {
            acceso.Conectar();
            List<SqlParameter> parametros = new List<SqlParameter>
            {
                acceso.CrearParametro(obj.UsuarioID, "@usuarioID"),
                acceso.CrearParametro(obj.Inicio.ToString(), "@inicio"),
                acceso.CrearParametro(obj.Final.ToString(), "@final"),
            };
            acceso.Escribir("SESION_USUARIO_ALTA", parametros);
            acceso.Desconectar();
        }

        public override List<BE.SesionUsuario> Listar()
        {
            List<BE.SesionUsuario> sesiones = new List<BE.SesionUsuario>();
            acceso.Conectar();
            DataTable tabla = acceso.Leer("SESION_USUARIO_LISTAR");
            acceso.Desconectar();

            if (tabla.Rows.Count > 0)
            {
                foreach(DataRow registro in tabla.Rows)
                {
                    BE.SesionUsuario sesion = new BE.SesionUsuario();
                    sesion.Id = int.Parse(registro["id"].ToString());
                    sesion.UsuarioID = int.Parse(registro["usuario_id"].ToString());
                    sesion.Inicio = Convert.ToDateTime(registro["inicio"].ToString());
                    sesion.Final = Convert.ToDateTime(registro["final"].ToString());
                    sesiones.Add(sesion);
                }
            }

            return sesiones;
        }
    }
}
