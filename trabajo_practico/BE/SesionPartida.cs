using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class SesionPartida : Sesion
    {
		private List<BE.Usuario> _usuarios;

		public List<BE.Usuario> Usuarios
		{
			get { return _usuarios; }
			set { _usuarios = value; }
		}
	}
}
