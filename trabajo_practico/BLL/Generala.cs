using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Generala
    {
        public BE.Generala InicializarGenerala()
        {
            BE.Generala generala = new BE.Generala();

            generala.Dados = new List<BE.Dado>
            {
                Dado.CrearDado(1),
                Dado.CrearDado(2),
                Dado.CrearDado(3),
                Dado.CrearDado(4),
                Dado.CrearDado(5),
            };

            generala.Categorias = new List<BE.Categoria>
            {
                Categoria.CrearCategoria(BE.CategoriaJuego.Uno, BE.TipoCategoria.Menor),
                Categoria.CrearCategoria(BE.CategoriaJuego.Dos, BE.TipoCategoria.Menor),
                Categoria.CrearCategoria(BE.CategoriaJuego.Tres, BE.TipoCategoria.Menor),
                Categoria.CrearCategoria(BE.CategoriaJuego.Cuatro, BE.TipoCategoria.Menor),
                Categoria.CrearCategoria(BE.CategoriaJuego.Cinco, BE.TipoCategoria.Menor),
                Categoria.CrearCategoria(BE.CategoriaJuego.Seis, BE.TipoCategoria.Menor),
                Categoria.CrearCategoria(BE.CategoriaJuego.Escalera, BE.TipoCategoria.Mayor),
                Categoria.CrearCategoria(BE.CategoriaJuego.Full, BE.TipoCategoria.Mayor),
                Categoria.CrearCategoria(BE.CategoriaJuego.Poker, BE.TipoCategoria.Mayor),
                Categoria.CrearCategoria(BE.CategoriaJuego.Generala, BE.TipoCategoria.Mayor),
            };

            generala.Tablero = new BE.Tablero();

            return generala;
        }

        public void IniciarJuego(BE.Generala generala, BE.Jugador jugador)
        {
            generala.Turno = NuevoTurno(generala, jugador);
        }

        public void FinalizarJuego(BE.Generala generala)
        {
            if (!generala.GeneralaServida)
            {
                DeterminarGanador(generala);
            }

            generala.Turno.JugadorEnJuego = null;
        }

        public void NuevoJuego(BE.Generala generala)
        {
            generala.Ganador = null;
            if (generala.GeneralaServida) generala.GeneralaServida = false;
            generala.Jugadores.ForEach(jugador => ReiniciarCategorias(jugador));
            NuevoTurno(generala, generala.Jugadores[0]);
        }

        private void DeterminarGanador(BE.Generala generala)
        {
            BE.Jugador jugadorMayorPuntaje = null;
            int mayorPuntajeObtenido = 0;

            generala.Jugadores.ForEach(jugador =>
            {
                int puntajeTotal = Jugador.CalcularPuntajeTotal(jugador);
                if (puntajeTotal > mayorPuntajeObtenido) jugadorMayorPuntaje = jugador;
            });

            generala.Ganador = jugadorMayorPuntaje;
        }

        private bool ContinuarJugando(BE.Generala generala)
        {
            bool resultado = true;

            generala.Jugadores.ForEach(jugador =>
            {
                if (!jugador.Categorias.Exists(categoria => categoria.Cerrada == false)) resultado = false;
                else resultado = true;
            });

            return resultado;
        }

        private void ReiniciarCategorias(BE.Jugador jugador)
        {
            jugador.Categorias.ForEach(categoria => Categoria.Restablecer(categoria));
        }

        private void RestablecerTablero(BE.Tablero tablero)
        {
            Tablero.RestablecerDadosApartados(tablero);
            Tablero.QuitarDadosTablero(tablero);
        }

        public BE.Tiro Jugar(BE.Generala generala)
        {
            BE.Tiro tiroRealizado = null;
            if (generala.Tablero.DadosEnTablero.Count == 0)
            {
                tiroRealizado = Turno.JugarTurno(generala.Cubilete, generala.Turno);
                if (tiroRealizado.NumeroDeTiro == 3)
                {
                    BE.CategoriaServida catServida = ComprobarCategoriaObtenida(generala, tiroRealizado);
                    if (catServida != BE.CategoriaServida.Ninguna) tiroRealizado.CategoriaServida = catServida;
                }
                Tablero.PonerDadosEnTablero(generala.Tablero, tiroRealizado.DadosJugados);
            }

            return tiroRealizado;
        }

        private BE.CategoriaServida ComprobarCategoriaObtenida(BE.Generala generala, BE.Tiro tiroRealizado)
        {
            BE.CategoriaServida resultado = AnalizarTiro(tiroRealizado);
            if (tiroRealizado.NumeroDeTiro == 3)
            {
                if (resultado == BE.CategoriaServida.Generala)
                {
                    generala.Ganador = generala.Turno.JugadorEnJuego;
                    FinalizarJuego(generala);
                }
            }

            return resultado;
        }

        public void PuntuarCerrarCategoria(BE.Generala generala, BE.Categoria categoria)
        {
            if (generala.Turno.TirosDisponibles < 3)
            {
                int puntaje = 0;
                if (categoria.Tipo == BE.TipoCategoria.Menor)
                {
                    if (categoria.Nombre == BE.CategoriaJuego.Uno) generala.Dados.ForEach(dado => { if (dado.Valor == 1) puntaje++; });
                    else if (categoria.Nombre == BE.CategoriaJuego.Dos) generala.Dados.ForEach(dado => { if (dado.Valor == 2) puntaje += 2; });
                    else if (categoria.Nombre == BE.CategoriaJuego.Tres) generala.Dados.ForEach(dado => { if (dado.Valor == 3) puntaje += 3; });
                    else if (categoria.Nombre == BE.CategoriaJuego.Cuatro) generala.Dados.ForEach(dado => { if (dado.Valor == 4) puntaje += 4; });
                    else if (categoria.Nombre == BE.CategoriaJuego.Cinco) generala.Dados.ForEach(dado => { if (dado.Valor == 5) puntaje += 5; });
                    else if (categoria.Nombre == BE.CategoriaJuego.Seis) generala.Dados.ForEach(dado => { if (dado.Valor == 6) puntaje += 6; });
                }
                else
                {
                    if (categoria.Nombre == BE.CategoriaJuego.Escalera)
                    {
                        if (generala.Turno.TirosDisponibles >= 2) puntaje = DeterminarEscalera(generala.Dados) ? 25 : 0;
                        else puntaje = DeterminarEscalera(generala.Dados) ? 20 : 0;
                    }
                    else if (categoria.Nombre == BE.CategoriaJuego.Full)
                    {
                        if (generala.Turno.TirosDisponibles >= 2) puntaje = DeterminarFull(generala.Dados) ? 35 : 0;
                        else puntaje = DeterminarFull(generala.Dados) ? 30 : 0;
                    }
                    else if (categoria.Nombre == BE.CategoriaJuego.Poker)
                    {
                        if (generala.Turno.TirosDisponibles >= 2) puntaje = DeterminarPoker(generala.Dados) ? 45 : 0;
                        else puntaje = DeterminarPoker(generala.Dados) ? 40 : 0;
                    }
                    else if (categoria.Nombre == BE.CategoriaJuego.Generala) puntaje = DeterminarGenerala(generala.Dados) ? 60 : 0;
                }

                Categoria.Cerrar(categoria, puntaje);
                generala.Turno.CategoriaCerrada = categoria;
            }
        }

        private BE.Turno NuevoTurno(BE.Generala generala, BE.Jugador jugador)
        {
            InicializarCubilete(generala);
            BE.Turno turno = Turno.CrearTurno(jugador);
            return turno;
        }

        private bool ComprobarCambioTurno(BE.Generala generala)
        {
            bool resultado = true;

            if (generala.Turno.CategoriaCerrada == null) resultado = false;

            return resultado;
        }

        public void CambiarTurno(BE.Generala generala)
        {
            if (ComprobarCambioTurno(generala))
            {
                BE.Jugador jugadorEnJuego = generala.Turno.JugadorEnJuego;
                BE.Jugador nuevoJugador;
                nuevoJugador = generala.Jugadores.Find(jugador => jugador.Nombre != jugadorEnJuego.Nombre);
                Turno.Terminar(generala.Turno);
                NuevoTurno(generala, nuevoJugador);
                RestablecerTablero(generala.Tablero);
            }
        }

        public void TerminarTurno(BE.Generala generala)
        {
            bool seguirJugando = ContinuarJugando(generala);

            if (!seguirJugando) FinalizarJuego(generala);
            else CambiarTurno(generala);
        }

        private void InicializarCubilete(BE.Generala generala)
        {
            Cubilete.PonerDados(generala.Cubilete, generala.Dados);
            generala.Dados.ForEach(dado => Dado.Restablecer(dado));
        }

        private BE.CategoriaServida AnalizarTiro(BE.Tiro tiroPorAnalizar)
        {
            BE.CategoriaServida resultado = BE.CategoriaServida.Ninguna;

            if (DeterminarEscalera(tiroPorAnalizar.DadosJugados))
            {
                resultado = BE.CategoriaServida.Escalera;
            }

            if (DeterminarFull(tiroPorAnalizar.DadosJugados))
            {
                resultado = BE.CategoriaServida.Full;
            }

            if (DeterminarPoker(tiroPorAnalizar.DadosJugados))
            {
                resultado = BE.CategoriaServida.Poker;
            }

            if (DeterminarGenerala(tiroPorAnalizar.DadosJugados))
            {
                resultado = BE.CategoriaServida.Generala;
            }

            return resultado;
        }

        private bool DeterminarEscalera(List<BE.Dado> dados)
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

        private bool DeterminarFull(List<BE.Dado> dados)
        {
            bool resultado = false;
            BE.Dado dado01 = dados[0];
            BE.Dado dado02 = dados.Find(dado => dado.Valor != dado01.Valor);

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

        private bool DeterminarPoker(List<BE.Dado> dados)
        {
            bool resultado = false;
            BE.Dado dado = dados[0];

            List<BE.Dado> dadosIguales = dados.FindAll(i => i.Valor == dado.Valor);

            if (dadosIguales.Count == 4) resultado = true;

            return resultado;
        }

        private bool DeterminarGenerala(List<BE.Dado> dados)
        {
            bool resultado = true;
            BE.Dado dadoLanzado = dados[0];

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
