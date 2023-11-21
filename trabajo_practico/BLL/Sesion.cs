using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public abstract class Sesion<T>
    {
        public abstract void Guardar(T obj);

        public abstract List<T> ObtenerTodas();
    }
}
