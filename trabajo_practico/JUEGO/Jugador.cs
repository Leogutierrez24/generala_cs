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

        private Cubilete _cubilete;
        public Cubilete Cubilete
        {
            get { return _cubilete; }
            set { _cubilete = value; }
        }

        private TablaPuntos _tablaPuntos;
        public TablaPuntos TablaPuntos
        {
            get { return _tablaPuntos; }
            set { _tablaPuntos = value; }
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
    }
}
