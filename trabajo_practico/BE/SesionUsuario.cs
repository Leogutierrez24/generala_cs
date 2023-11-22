using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class SesionUsuario : Sesion
    {
		private BE.Usuario _usuario;
		public BE.Usuario Usuario
		{
			get { return _usuario; }
			set { _usuario = value; }
		}
	}
}
