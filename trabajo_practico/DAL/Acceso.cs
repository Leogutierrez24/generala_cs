using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    internal class Acceso
    {
        private SqlConnection _conexion;

        private readonly string _dataSource = "DESKTOP-33NRQM9";

        public void Conectar()
        {
            string connectionString = $"Data Source={_dataSource};Initial Catalog=TRABAJO_PRACTICO;Integrated Security=SSPI";
            _conexion = new SqlConnection(connectionString);
            _conexion.Open();
        }

        public void Desconectar()
        {
            _conexion.Close();
            _conexion = null;
            GC.Collect();
        }

        private SqlCommand CrearComando(string query, List<SqlParameter> parametros = null)
        {
            SqlCommand comando = new SqlCommand
            {
                Connection = _conexion,
                CommandType = CommandType.StoredProcedure,
                CommandText = query,
            };

            parametros?.ForEach(parametro => comando.Parameters.Add(parametro));

            return comando;
        }

        public SqlParameter CrearParametro(string valorParam, string nombreParam)
        {
            SqlParameter parametro = new SqlParameter
            {
                ParameterName = nombreParam,
                Value = valorParam,
                DbType = DbType.String,
            };

            return parametro;
        }

        public SqlParameter CrearParametro(int valorParam, string nombreParam)
        {
            SqlParameter parametro = new SqlParameter
            {
                ParameterName = nombreParam,
                Value = valorParam,
                DbType = DbType.Int32,
            };

            return parametro;
        }

        public int Escribir(string query, List<SqlParameter> parametros = null)
        {
            int filasAfectadas;
            SqlCommand comando = CrearComando(query, parametros);

            try
            {
                comando.ExecuteNonQuery();
                filasAfectadas = 0;
            } catch (SqlException ex)
            {
                filasAfectadas = -1;
            }

            return filasAfectadas;
        }

        public DataTable Leer(string query, List<SqlParameter> parametros = null)
        {
            DataTable tabla = new DataTable();
            using(SqlDataAdapter adaptador = new SqlDataAdapter())
            {
                adaptador.SelectCommand = CrearComando(query, parametros);
                adaptador.Fill(tabla);
                adaptador.Dispose();
            }

            return tabla;
        }
    }
}
