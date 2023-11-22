using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Jugador
    {
        private int _usuarioID;
        public int UsuarioID
        {
            get { return _usuarioID; }
            set { _usuarioID = value; }
        }

        private string _nombre;
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        private List<Categoria> _categorias;
        public List<Categoria> Categorias
        {
            get { return _categorias; }
            set { _categorias = value; }
        }
    }
}
