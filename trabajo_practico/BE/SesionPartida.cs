using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class SesionPartida : Sesion
    {
		private BE.Usuario _usuario01;
		public BE.Usuario Usuario01
		{
			get { return _usuario01; }
			set { _usuario01 = value; }
		}

		private BE.Usuario _usuario02;
		public BE.Usuario Usuario02
		{
			get { return _usuario02; }
			set { _usuario02 = value; }
		}
	}
}
