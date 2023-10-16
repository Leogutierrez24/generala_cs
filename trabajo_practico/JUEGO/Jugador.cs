using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JUEGO
{
    public class Jugador
    {
        private string _nombre;
        public string Nombre
        {
            get { return _nombre; }
        }

        private TablaPuntos _puntaje;
        public TablaPuntos Puntaje
        {
            get { return _puntaje; }
            set { _puntaje = value; }
        }

        private Cubilete _cubilete;
        public Cubilete Cubilete
        {
            get { return _cubilete; }
            set { _cubilete = value; }
        }

        public Jugador(string nombre)
        {
            _nombre = nombre;
        }

        public List<Dado> TirarDados()
        {
            return _cubilete.TirarDados();
        }

        public void ElegirDados(List<Dado> dadosElegidos)
        {
            _cubilete.PonerDados(dadosElegidos);
        }

        public void CerrarCategoria(Categoria categoriaPorCerrar)
        {
            categoriaPorCerrar.Cerrar();
        }

        public bool TerminarTurno()
        {
            return true;
        }
    }
}
