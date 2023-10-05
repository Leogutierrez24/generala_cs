using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public abstract class Mapper<T>
    {
        public abstract void Insertar();

        public abstract void Actualizar();

        public abstract T Listar();

    }
}
