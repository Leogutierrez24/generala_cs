using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public abstract class Mapper<T>
    {
        public abstract void Insertar(T obj);

        public abstract void Actualizar(T obj);

        public abstract void Borrar(T obj);

        public abstract T Listar();

    }
}
