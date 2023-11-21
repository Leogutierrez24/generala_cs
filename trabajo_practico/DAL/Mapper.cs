using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public abstract class Mapper<T>
    {
        internal Acceso acceso = new Acceso();

        public abstract void Insertar(T obj);

        public abstract void Actualizar(T obj);

        public abstract void Borrar(int id);

        public abstract List<T> Listar();
    }
}
