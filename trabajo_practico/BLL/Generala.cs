﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Generala
    {
        public void IniciarJuego()
        {
            NuevoTurno(_jugadores[0]);
        }

        public void FinalizarJuego()
        {
            if (!_generalaServida)
            {
                DeterminarGanador();
            }

            _turno.JugadorEnJuego = null;
        }

        public void NuevoJuego()
        {
            _ganador = null;
            if (_generalaServida) _generalaServida = false;
            _jugadores.ForEach(jugador => ReiniciarCategorias(jugador));
            NuevoTurno(_jugadores[0]);
        }

        private void DeterminarGanador()
        {
            Jugador jugadorMayorPuntaje = null;
            int mayorPuntajeObtenido = 0;

            _jugadores.ForEach(jugador =>
            {
                int puntajeTotal = jugador.CalcularPuntajeTotal();
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

        private bool ContinuarJuego()
        {
            bool resultado = true;

            _jugadores.ForEach(jugador =>
            {
                if (!jugador.Categorias.Exists(categoria => categoria.Cerrada == false)) resultado = false;
                else resultado = true;
            });

            return resultado;
        }

        private void ReiniciarCategorias(Jugador jugador)
        {
            jugador.Categorias.ForEach(categoria => categoria.Restablecer());
        }

        private void RestablecerTablero()
        {
            _tablero.RestablecerDadosApartados();
            _tablero.QuitarDadosTablero();
        }

        public Tiro Jugar()
        {
            Tiro tiroRealizado;
            if (_tablero.DadosEnTablero.Count == 0)
            {
                tiroRealizado = _turno.JugarTurno();
                if (tiroRealizado.NumeroDeTiro == 3)
                {
                    CategoriaServida catServida = ComprobarCategoriaObtenida(tiroRealizado);
                    if (catServida != CategoriaServida.Ninguna) tiroRealizado.CategoriaServida = catServida;
                }
                _tablero.PonerDadosEnTablero(tiroRealizado.DadosJugados);
            }
            else
            {
                tiroRealizado = null;
            }

            return tiroRealizado;
        }

        private CategoriaServida ComprobarCategoriaObtenida(Tiro tiroRealizado)
        {
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

        public void PuntuarCerrarCategoria(Categoria categoria)
        {
            if (_turno.TirosDisponibles < 3)
            {
                int puntaje = 0;
                if (categoria.Tipo == TipoCategoria.Menor)
                {
                    if (categoria.Nombre == CategoriaJuego.Uno) _dados.ForEach(dado => { if (dado.Valor == 1) puntaje++; });
                    else if (categoria.Nombre == CategoriaJuego.Dos) _dados.ForEach(dado => { if (dado.Valor == 2) puntaje += 2; });
                    else if (categoria.Nombre == CategoriaJuego.Tres) _dados.ForEach(dado => { if (dado.Valor == 3) puntaje += 3; });
                    else if (categoria.Nombre == CategoriaJuego.Cuatro) _dados.ForEach(dado => { if (dado.Valor == 4) puntaje += 4; });
                    else if (categoria.Nombre == CategoriaJuego.Cinco) _dados.ForEach(dado => { if (dado.Valor == 5) puntaje += 5; });
                    else if (categoria.Nombre == CategoriaJuego.Seis) _dados.ForEach(dado => { if (dado.Valor == 6) puntaje += 6; });
                }
                else
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

                categoria.Cerrar(puntaje);
                _turno.CategoriaCerrada = categoria;
            }
        }

        public int PonerDadosCubilete(List<Dado> dados)
        {
            int resultado;
            if (_cubilete.Dados.Count + dados.Count <= 5)
            {
                _turno.JugadorEnJuego.ElegirDados(dados);
                _tablero.QuitarDadoTablero(dados);
                resultado = 0;
            }
            else
            {
                resultado = -1;
            }
            return resultado;
        }

        private void NuevoTurno(Jugador jugador)
        {
            InicializarCubilete();
            jugador.Cubilete = _cubilete;
            _turno = new Turno(jugador);
        }

        private bool ComprobarCambioTurno()
        {
            bool resultado = true;

            if (_turno.CategoriaCerrada == null) resultado = false;

            return resultado;
        }

        public void CambiarTurno()
        {
            if (ComprobarCambioTurno())
            {
                Jugador jugadorEnJuego = _turno.JugadorEnJuego;
                jugadorEnJuego.Cubilete = null;
                Jugador nuevoJugador;
                int indexJugador = _jugadores.IndexOf(jugadorEnJuego);

                if (indexJugador == _jugadores.Count - 1)
                {
                    nuevoJugador = _jugadores[0];
                }
                else
                {
                    nuevoJugador = _jugadores[indexJugador + 1];
                }

                _turno.Terminar();
                NuevoTurno(nuevoJugador);
                RestablecerTablero();
            }
        }

        public void TerminarTurno()
        {
            bool seguirJugando = ContinuarJuego();

            if (!seguirJugando) FinalizarJuego();
            else CambiarTurno();
        }

        private void InicializarCubilete()
        {
            _cubilete.PonerDados(_dados);
        }

        private CategoriaServida AnalizarTiro(Tiro tiroPorAnalizar)
        {
            CategoriaServida resultado = CategoriaServida.Ninguna;

            if (DeterminarEscalera(tiroPorAnalizar.DadosJugados))
            {
                resultado = CategoriaServida.Escalera;
            }

            if (DeterminarFull(tiroPorAnalizar.DadosJugados))
            {
                resultado = CategoriaServida.Full;
            }

            if (DeterminarPoker(tiroPorAnalizar.DadosJugados))
            {
                resultado = CategoriaServida.Poker;
            }

            if (DeterminarGenerala(tiroPorAnalizar.DadosJugados))
            {
                resultado = CategoriaServida.Generala;
            }

            return resultado;
        }

        private bool DeterminarEscalera(List<Dado> dados)
        {
            bool resultado = true;
            if (!dados.Exists(dado => dado.Valor == 2) || !dados.Exists(dado => dado.Valor == 3) ||
                !dados.Exists(dado => dado.Valor == 4) || !dados.Exists(dado => dado.Valor == 5))
            {
                resultado = false;
            }
            else
            {
                if (dados.Exists(dado => dado.Valor == 1) || dados.Exists(dado => dado.Valor == 6))
                {
                    resultado = true;
                }
            }

            return resultado;
        }

        private bool DeterminarFull(List<Dado> dados)
        {
            bool resultado = false;
            Dado dado01 = dados[0];
            Dado dado02 = dados.Find(dado => dado.Valor != dado01.Valor);

            if (dado02 != null)
            {
                int cantDados01 = 0;
                int cantDados02 = 0;

                dados.ForEach(dado =>
                {
                    if (dado.Valor == dado01.Valor) cantDados01++;
                    else if (dado.Valor == dado02.Valor) cantDados02++;
                });

                if ((cantDados01 == 3 && cantDados02 == 2) || (cantDados01 == 2 && cantDados02 == 3)) resultado = true;
            }

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
