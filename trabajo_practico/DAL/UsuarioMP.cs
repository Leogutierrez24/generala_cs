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
    public class UsuarioMP : Mapper<BE.Usuario>
    {
        public override void Actualizar(BE.Usuario obj)
        {
            List<SqlParameter> parametros = new List<SqlParameter>
            {
                acceso.CrearParametro(obj.Id, "@id"),
                acceso.CrearParametro(obj.Nombre, "@nombre"),
                acceso.CrearParametro(obj.Password, "@password"),
            };

            acceso.Escribir("USUARIO_ACTUALIZAR", parametros);
        }

        public override void Borrar(int id)
        {
            throw new NotImplementedException();
        }

        public override void Insertar(BE.Usuario obj)
        {
            List<SqlParameter> parametros = new List<SqlParameter>
            {
                acceso.CrearParametro(obj.Nombre, "@nombre"),
                acceso.CrearParametro(obj.Password, "@password"),
            };
            
            acceso.Escribir("USUARIO_ALTA", parametros);
        }

        public override Usuario Listar()
        {
            throw new NotImplementedException();
        }

        public override BE.Usuario Obtener(Usuario obj)
        {
            List<SqlParameter> parametros = new List<SqlParameter>
            {
                acceso.CrearParametro(obj.Nombre, "@nombre"),
                acceso.CrearParametro(obj.Password, "@password"),
            };

            DataTable tabla = acceso.Leer("USUARIO_OBTENER", parametros);
            BE.Usuario usuario;

            if (tabla.Rows.Count > 0)
            {
                DataRow registro = tabla.Rows[0];
                usuario = new BE.Usuario(int.Parse(registro["ID"].ToString()),
                    registro["NOMBRE"].ToString(),
                    registro["PASSWORD"].ToString());
            }
            else usuario = null;

            return usuario;
        }
    }
}
