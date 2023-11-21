using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public abstract class Sesion
    {
		protected int _id;
		public int Id
		{
			get { return _id; }
			set { _id = value; }
		}

		private DateTime _inicio;
		public DateTime Inicio
		{
			get { return _inicio; }
			set { _inicio = value; }
		}

		private DateTime _final;
		public DateTime Final
		{
			get { return _final; }
			set { _final = value; }
		}
	}
}
