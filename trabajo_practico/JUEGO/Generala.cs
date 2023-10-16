using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JUEGO
{
    public class Generala
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

        private Cubilete _cubilete = new Cubilete();
        public Cubilete Cubilete
        {
            get { return _cubilete; }
        }

        private List<Categoria> _categorias = new List<Categoria>();
        public List<Categoria> Categorias
        {
            get { return _categorias; }
        }

        private List<Jugador> _jugadores = new List<Jugador>();
        public List<Jugador> Jugadores
        {
            get { return _jugadores; }
        }

        private Turno _turno = new Turno();
        public Turno Turno
        {
            get { return _turno; }
        }

        private Tablero _tablero = new Tablero();

        public Tablero Tablero
        {
            get { return _tablero; }
        }

        private Jugador _ganador;
        public Jugador Ganador
        {
            get { return _ganador; }
        }

        public Generala()
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

            _categorias = new List<Categoria>
            {
                new Categoria(CategoriaJuego.Uno),
                new Categoria(CategoriaJuego.Dos),
                new Categoria(CategoriaJuego.Tres),
                new Categoria(CategoriaJuego.Cuatro),
                new Categoria(CategoriaJuego.Cinco),
                new Categoria(CategoriaJuego.Seis),
                new Categoria(CategoriaJuego.Escalera),
                new Categoria(CategoriaJuego.Full),
                new Categoria(CategoriaJuego.Poker),
                new Categoria(CategoriaJuego.Generala),
            };
        }

        public void IniciarJuego()
        {
            _turno.JugadorEnJuego = _jugadores[0];
            RondaPosicionamiento();
            _turno.JugadorEnJuego.Cubilete = _cubilete;
        }

        public void FinalizarJuego()
        {

        }

        public void NuevoJugador(string nombre)
        {
            Jugador nuevoJugador = new Jugador(nombre);
            nuevoJugador.Puntaje.Categorias = _categorias;
            _jugadores.Add(nuevoJugador);
        }

        public void EliminarJugador(Jugador jugador)
        {
            _jugadores.Remove(jugador);
        }

        public void CambiarTurno()
        {
            Jugador jugadorEnJuego = _turno.JugadorEnJuego;
            Jugador nuevoJugador;
            int indexJugador = _jugadores.IndexOf(jugadorEnJuego);

            if (indexJugador == _jugadores.Count - 1)
            {
                nuevoJugador = _jugadores[0];
            } else
            {
                nuevoJugador = _jugadores[indexJugador + 1];
            }

            _turno.Terminar();
            _turno.JugadorEnJuego = nuevoJugador;
            RestablecerCubilete();
            _turno.JugadorEnJuego.Cubilete = _cubilete;
            _turno.EstablecerTiros();
        }


        // Acciones Jugador
        public void Jugar()
        {
            Tiro tiroRealizado = _turno.JugarTurno();
            _tablero.Bitacora.Registrar(tiroRealizado);

            if (tiroRealizado.NumeroDeTiro == 3)
            {
                CategoriaServida resultado = AnalizarTiroPrimerTiro(tiroRealizado);
                if (resultado == CategoriaServida.Generala)
                {
                    _ganador = _turno.JugadorEnJuego;
                    FinalizarJuego();
                }
            } else
            {

            }
        }

        public void JugarPosicionamiento()
        {

        }

        public void BloquearDadosApartados(List<Dado> dadosPorApartar)
        {
            dadosPorApartar.ForEach(dado =>
            {
                int index = _dados.FindIndex(item => item.Id == dado.Id);
                _dadosApartados.Add(_dados[index]);
                _dados.RemoveAt(index);
            });
        }

        // Tiros
        private CategoriaServida AnalizarTiroPrimerTiro(Tiro tiroPorAnalizar)
        {
            // Analiza si hubo un "Tiro Servido"

            // escalera
            if (DeterminarEscalera(tiroPorAnalizar.DadosJugados))
            {
                // escalera servida
                return CategoriaServida.Escalera;
            }

            // full
            if (DeterminarFull(tiroPorAnalizar.DadosJugados))
            {
                // escalera servida
                return CategoriaServida.Full;
            }

            // poker
            if (DeterminarPoker(tiroPorAnalizar.DadosJugados))
            {
                // poker servido
                return CategoriaServida.Poker;
            }

            // generala
            if (DeterminarGenerala(tiroPorAnalizar.DadosJugados))
            {
                // Gana el juego
                return CategoriaServida.Generala;
            }


        }

        private bool DeterminarEscalera(List<Dado> dados)
        {
            bool resultado = true;
            if (!dados.Exists(dado => dado.Valor == 2) || !dados.Exists(dado => dado.Valor == 3) ||
                !dados.Exists(dado => dado.Valor == 4) || !dados.Exists(dado => dado.Valor == 5)){
                resultado = false;
            } else {
                if (!dados.Exists(dado => dado.Valor == 1) || !dados.Exists(dado => dado.Valor == 6))
                {
                    resultado = false;
                }
            }

            return resultado;
        }

        private bool DeterminarFull(List<Dado> dados)
        { 
            bool resultado = false;
            Dado dado01 = dados[0];
            Dado dado02 = dados.Find(dado => dado.Valor != dado01.Valor);
            int cantDados01 = 0;
            int cantDados02 = 0;

            for(int i = 0; i < dados.Count; i++)
            {
                if (dados[i].Valor == dado01.Valor) cantDados01++;
                else if (dados[i].Valor == dado01.Valor) cantDados02++;
            }

            if ((cantDados01 == 3 && cantDados02 == 2) || (cantDados01 == 2 && cantDados02 == 3)) resultado = true;

            return resultado;
        }

        private bool DeterminarPoker(List<Dado> dados)
        {
            bool resultado = false;
            Dado dado = dados[0];

            List<Dado> dadosIguales = dados.FindAll(i => i.Valor == dado.Valor);

            if (dadosIguales.Count == 4) resultado = true;

            return resultado;
        }

        private bool DeterminarGenerala(List<Dado> dados)
        {
            bool resultado = true;
            Dado dadoLanzado = dados[0];

            if (dados.Exists(dado => dado.Valor != dadoLanzado.Valor)) resultado = false;

            return resultado;
        }



        // Acciones Cubilete
        private void InicializarCubilete()
        {
            _cubilete.PonerDados(_dados);
        }

        private void InicializarCubiletePosicionamiento()
        {
            while (_dados.Count > 1)
            {
                _dadosApartados.Add(_dados[0]);
                _dados.RemoveAt(0);
            }

            _cubilete.PonerDados(_dados);
        }

        public void RestablecerCubilete()
        {
            if (_dadosApartados.Count > 0)
            {
                while (_dadosApartados.Count != 0)
                {
                    _dados.Add(_dadosApartados[0]);
                    _dadosApartados.RemoveAt(0);
                }
            }

            _dados.ForEach(dado => dado.Restablecer());

            _cubilete.PonerDados(_dados);
        }


        /*  Ronda que determina el orden de juego que va a tener c/jugador.
            
            Las situaciones que pueden darse son dos: 
            1) Que todos los jugadores tengan números diferentes
            2) Que haya jugadores con números repetidos
         
            Caso 1) se van a distribuir de Mayor a Menor del dado que hayan obtenido.
            Caso 2) se tienen que determinar qué jugadores tienen valores iguales y realizar el proceso de seleccion nuevamente
            hasta que se obtengan números diferentes.
         */

        public void RondaPosicionamiento()
        {
           
        }

        public void DeterminarPosicionamiento()
        {
           
        }

        private bool DeterminarPosicionamientosRepetidos()
        {
            return false;
        }
    }
}
