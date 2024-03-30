using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Partida
    {
		private int _id;
		public int Id
		{
			get { return _id; }
			set { _id = value; }
		}

		private BE.Usuario _jugador01;
		public BE.Usuario Jugador01
		{
			get { return _jugador01; }
			set { _jugador01 = value; }
		}

		private BE.Usuario _jugador02;
		public BE.Usuario Jugador02
		{
			get { return _jugador02; }
			set { _jugador02 = value; }
		}

		private BE.Usuario _ganador;
		public BE.Usuario Ganador
		{
			get { return _ganador; }
			set { _ganador = value; }
		}

		private BE.Usuario _perdedor;
		public BE.Usuario Perdedor
		{
			get { return _perdedor; }
			set { _perdedor = value; }
		}

		private DateTime _inicio;
		public DateTime Inicio
		{
			get { return _inicio; }
			set { _inicio = value; }
		}

		private DateTime _fin;
		public DateTime Fin
		{
			get { return _fin; }
			set { _fin = value; }
		}

		private bool _empate = false;
		public bool Empate
		{
			get { return _empate ; }
			set { _empate  = value; }
		}

	}
}
