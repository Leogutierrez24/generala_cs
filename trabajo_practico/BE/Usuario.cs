using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Usuario
    {
        private int _id;
        public int Id
        {
            get { return _id; }
        }

        private string _nombre;
        public string Nombre
        {
            get { return _nombre; }
        }

        private string _password;
        public string Password
        {
            get { return _password; }
        }

        public Usuario(int id, string nombre, string password) 
        { 
            _id = id;
            _nombre = nombre;
            _password = password;
        }

    }
}
