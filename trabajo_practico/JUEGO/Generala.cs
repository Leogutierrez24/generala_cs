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

        private bool _generalaServida = false;

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
                new Categoria(CategoriaJuego.Uno, TipoCategoria.Menor),
                new Categoria(CategoriaJuego.Dos, TipoCategoria.Menor),
                new Categoria(CategoriaJuego.Tres, TipoCategoria.Menor),
                new Categoria(CategoriaJuego.Cuatro, TipoCategoria.Menor),
                new Categoria(CategoriaJuego.Cinco, TipoCategoria.Menor),
                new Categoria(CategoriaJuego.Seis, TipoCategoria.Menor),
                new Categoria(CategoriaJuego.Escalera, TipoCategoria.Mayor),
                new Categoria(CategoriaJuego.Full, TipoCategoria.Mayor),
                new Categoria(CategoriaJuego.Poker, TipoCategoria.Mayor),
                new Categoria(CategoriaJuego.Generala, TipoCategoria.Mayor),
            };
        }

        public void IniciarJuego()
        {
            _jugadores.ForEach(jugador =>
            {
                jugador.TablaPuntos = new TablaPuntos();
            });
            _turno.JugadorEnJuego = _jugadores[0];
            InicializarCubilete();
            _turno.JugadorEnJuego.Cubilete = _cubilete;
        }

        public void FinalizarJuego()
        {
            if (!_generalaServida)
            {
                DeterminarGanador();
            }

            _turno.JugadorEnJuego = null;
        }

        private void DeterminarGanador()
        {
            Jugador jugadorMayorPuntaje = null;
            int mayorPuntajeObtenido = 0;

            _jugadores.ForEach(jugador =>
            {
                int puntajeTotal = jugador.TablaPuntos.ObtenerPuntajeTotal();
                if (puntajeTotal > mayorPuntajeObtenido) jugadorMayorPuntaje = jugador;
            });

            _ganador = jugadorMayorPuntaje;
        }

        public void NuevoJugador(string nombre)
        {
            Jugador nuevoJugador = new Jugador(nombre);
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


        // Acciones del jugador
        public CategoriaServida Jugar()
        {
            Tiro tiroRealizado = _turno.JugarTurno();
            _tablero.Bitacora.Registrar(tiroRealizado);
            CategoriaServida resultado = AnalizarTiro(tiroRealizado);

            if (tiroRealizado.NumeroDeTiro == 3)
            {
                if (resultado == CategoriaServida.Generala)
                {
                    _ganador = _turno.JugadorEnJuego;
                    FinalizarJuego();
                }
            }

            return resultado;
        }

        public void CerrarCategoria(Categoria categoria)
        {
            int puntaje = 0;
            if (_dadosApartados.Count != 0) RestablecerDadosApartados();
            if (categoria.Tipo == TipoCategoria.Menor)
            {
                if (categoria.Nombre == CategoriaJuego.Uno) _dados.ForEach(dado => { if (dado.Valor == 1) puntaje++; });
                else if (categoria.Nombre == CategoriaJuego.Dos) _dados.ForEach(dado => { if (dado.Valor == 2) puntaje += 2; });
                else if (categoria.Nombre == CategoriaJuego.Tres) _dados.ForEach(dado => { if (dado.Valor == 3) puntaje += 3; });
                else if (categoria.Nombre == CategoriaJuego.Cuatro) _dados.ForEach(dado => { if (dado.Valor == 4) puntaje += 4; });
                else if (categoria.Nombre == CategoriaJuego.Cinco) _dados.ForEach(dado => { if (dado.Valor == 5) puntaje += 5; });
                else if (categoria.Nombre == CategoriaJuego.Seis) _dados.ForEach(dado => { if (dado.Valor == 6) puntaje += 6; });
            } else
            {
                if (categoria.Nombre == CategoriaJuego.Escalera)
                {
                    if (_turno.TirosDisponibles >= 2) puntaje = DeterminarEscalera(_dados) ? 25 : 0;
                    else puntaje = DeterminarEscalera(_dados) ? 20 : 0;
                }
                else if (categoria.Nombre == CategoriaJuego.Full)
                {
                    if (_turno.TirosDisponibles >= 2) puntaje = DeterminarFull(_dados) ? 35 : 0;
                    else puntaje = DeterminarFull(_dados) ? 30 : 0;
                }
                else if (categoria.Nombre == CategoriaJuego.Poker)
                {
                    if (_turno.TirosDisponibles >= 2) puntaje = DeterminarPoker(_dados) ? 45 : 0;
                    else puntaje = DeterminarPoker(_dados) ? 40 : 0;
                }
                else if (categoria.Nombre == CategoriaJuego.Generala) puntaje = DeterminarGenerala(_dados) ? 60 : 0;
            }

            _turno.JugadorEnJuego.TablaPuntos.CerrarCategoria(categoria.Nombre, puntaje);
        }

        public void TerminarTurno()
        {
            bool terminarPartida = false;

            _jugadores.ForEach(jugador =>
            {
                if (!jugador.TablaPuntos.Categorias.Exists(categoria => categoria.Cerrada == false))
                {
                    terminarPartida = true;
                }
            });

            if (terminarPartida)
            {
                FinalizarJuego();
            } else
            {
                CambiarTurno();
            }
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

        private void RestablecerDadosApartados()
        {
            _dadosApartados.ForEach(dado =>
            {
                int index = _dadosApartados.FindIndex(item => item.Id == dado.Id);
                _dados.Add(_dados[index]);
                _dadosApartados.RemoveAt(index);
            });
        }

        // Tiros
        private CategoriaServida AnalizarTiro(Tiro tiroPorAnalizar)
        {
            // Analiza si hubo un "Tiro Servido"
            CategoriaServida resultado = CategoriaServida.Ninguna;
            // escalera
            if (DeterminarEscalera(tiroPorAnalizar.DadosJugados))
            {
                // escalera servida
                resultado = CategoriaServida.Escalera;
            }

            // full
            if (DeterminarFull(tiroPorAnalizar.DadosJugados))
            {
                // escalera servida
               resultado = CategoriaServida.Full;
            }

            // poker
            if (DeterminarPoker(tiroPorAnalizar.DadosJugados))
            {
                // poker servido
                resultado = CategoriaServida.Poker;
            }

            // generala
            if (DeterminarGenerala(tiroPorAnalizar.DadosJugados))
            {
                // Gana el juego
               resultado = CategoriaServida.Generala;
            }

            return resultado;
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

        // Acciones del cubilete
        private void InicializarCubilete()
        {
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
    }
}
