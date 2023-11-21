using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class SesionUsuario : Sesion
    {
		private int _usuarioID;
		public int UsuarioID
		{
			get { return _usuarioID; }
			set { _usuarioID = value; }
		}
	}
}
