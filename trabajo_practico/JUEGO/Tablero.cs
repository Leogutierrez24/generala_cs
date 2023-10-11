using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JUEGO
{
    public class Tablero
    {
        private List<Dado> _dados = new List<Dado>();
        public List<Dado> Dados
        {
            get { return _dados; }
        }

        private List<Dado> _dadosApartados = new List<Dado>();
        public List<Dado> DadosApartados
        {
            get { return _dadosApartados; }
        }

        private Jugador _jugadorEnJuego;
        public Jugador JugadorEnJuego
        {
            get { return _jugadorEnJuego; }
            set { _jugadorEnJuego = value; }
        }

        public Tablero()
        {
            _dados = new List<Dado>
            {
                new Dado(1),
                new Dado(2),
                new Dado(3),
                new Dado(4),
                new Dado(5),
                new Dado(6),
            };
        }

        public void AgregarDadosApartados(Dado dado)
        {
            _dadosApartados.Add(dado);
        }

        public void AgregarDadosApartados(List<Dado> dados)
        {
            dados.ForEach(dado => _dadosApartados.Add(dado));
        }

        public void RemoverDadosApartados(Dado dado)
        {
            _dadosApartados.Remove(dado);
        }

        public void RemoverDadosApartados(List<Dado> dados)
        {
            dados.ForEach(dado => _dados.Add(dado));
        }

        public void JugarTurno()
        {
            if (_jugadorEnJuego.Tiros != 0)
            {
                if (_jugadorEnJuego.Tiros == 3)
                {
                    ComprobarPrimerTiro();
                } else
                {
                    _jugadorEnJuego.TirarDados(_dados);
                    ComprobarTiros();
                }
            }
        }

        private void ComprobarTiros()
        {
            if (_jugadorEnJuego.Tiros == 0) _dadosApartados.ForEach(dado => _dados.Add(dado));
        }

        private void ComprobarPrimerTiro()
        {

        }
    }
}
