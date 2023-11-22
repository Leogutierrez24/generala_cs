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
            acceso.Conectar();
            List<SqlParameter> parametros = new List<SqlParameter>
            {
                acceso.CrearParametro(obj.Id, "@id"),
                acceso.CrearParametro(obj.Nombre, "@nombre"),
                acceso.CrearParametro(obj.Password, "@password"),
            };
            acceso.Escribir("USUARIO_ACTUALIZAR", parametros);
            acceso.Desconectar();
        }

        public override void Borrar(int id)
        {
            throw new NotImplementedException();
        }

        public override void Insertar(BE.Usuario obj)
        {
            acceso.Conectar();
            List<SqlParameter> parametros = new List<SqlParameter>
            {
                acceso.CrearParametro(obj.Nombre, "@nombre"),
                acceso.CrearParametro(obj.Password, "@password"),
            };
            
            acceso.Escribir("USUARIO_ALTA", parametros);
            acceso.Desconectar();
        }

        public override List<BE.Usuario> Listar()
        {
            List<BE.Usuario> usuarios = new List<BE.Usuario>();
            acceso.Conectar();
            DataTable tabla = acceso.Leer("USUARIO_LISTAR");
            acceso.Desconectar();

            if (tabla.Rows.Count > 0)
            {
                foreach(DataRow registro in tabla.Rows)
                {
                    BE.Usuario usuario = new BE.Usuario();
                    usuario.Id = int.Parse(registro["id"].ToString());
                    usuario.Nombre = registro["nombre"].ToString();
                    usuario.Password = registro["password"].ToString();
                    usuarios.Add(usuario);
                }
            }

            return usuarios;
        }

        public BE.Usuario Obtener(string usuario, string password)
        {
            acceso.Conectar();
            List<SqlParameter> parametros = new List<SqlParameter>
            {
                acceso.CrearParametro(usuario, "@nombre"),
                acceso.CrearParametro(password, "@password"),
            };

            DataTable tabla = acceso.Leer("USUARIO_OBTENER", parametros);

            BE.Usuario usuarioEncontrado;
            if (tabla.Rows.Count > 0)
            {
                DataRow registro = tabla.Rows[0];
                usuarioEncontrado = new BE.Usuario
                {
                    Id = int.Parse(registro["id"].ToString()),
                    Nombre = registro["nombre"].ToString(),
                    Password = registro["password"].ToString()
                };
            }
            else usuarioEncontrado = null;
            acceso.Desconectar();
            return usuarioEncontrado;
        }
    }
}
