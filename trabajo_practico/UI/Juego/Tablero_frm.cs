using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Juego
{
    public partial class Tablero_frm : Form
    {
        public BE.Generala generala;

        public readonly BLL.Generala gestor = new BLL.Generala();

        public bool TableroVacio = false;

        private bool _volverJugar = false;

        private readonly ResumenPartida_frm _resumenPartida;

        private BE.Partida _partida;

        private BLL.Partida _gestorPartida;

        public Tablero_frm(BE.Usuario jugador01, BE.Usuario jugador02)
        {
            InitializeComponent();
            generala = gestor.InicializarGenerala();
            gestor.EstablecerJugador(generala, jugador01);
            gestor.EstablecerJugador(generala, jugador02);
            _gestorPartida = BLL.Partida.getInstance();
            _partida = _gestorPartida.NuevaPartida(jugador01, jugador02);

            _resumenPartida = new ResumenPartida_frm(generala, gestor);
            _resumenPartida.NuevoJuego += ResumenPartida_frm_NuevoJuego;
        }

        private void ResumenPartida_frm_NuevoJuego(object sender, NuevoJuegoEventArgs e)
        {
            this._volverJugar = e.Resultado;
        }

        private void Tablero_frm_Load(object sender, EventArgs e)
        {
            gestor.IniciarJuego(generala);
            CrearTablero();
            ComenzarJuego();
        }

        // Información del Juego
        private void CrearTablero()
        {
            for(int i = 0; i < generala.Jugadores.Count; i++)
            {
                if (i == 0) Tablero_dataGridView.Columns.Add("", "Categorias");
                Tablero_dataGridView.Columns.Add($"Jugador {i + 1}", generala.Jugadores[i].Nombre);
            }
            
            generala.Categorias.ForEach(categoria =>
            {
                Tablero_dataGridView.Rows.Add(categoria.Nombre);
            });

            ActualizarPuntajes();
        }

        private void ReiniciarJuego()
        {
            gestor.NuevoJuego(generala);
            DesbloquearBotones();
            DesbloquearBotonesDados();
            ActualizarPuntajes();
            ActualizarDados();
            ActualizarDadosApartados();
            ActualizarCubilete();
            ActualizarJugador();
        }

        private void ActualizarPuntajes()
        {
            for (int i = 0; i < generala.Jugadores.Count; i++)
            {
                for (int j = 0; j < generala.Categorias.Count; j++)
                {
                    Tablero_dataGridView.Rows[j].Cells[i + 1].Value = generala.Jugadores[i].Categorias[j].Puntos;
                }
            }
        }

        private void ActualizarJugador()
        {
            Jugador_groupBox.Text = generala.Turno.JugadorEnJuego.Nombre;
            Tiros_lbl.Text = generala.Turno.TirosDisponibles.ToString();
        }

        private void ActualizarContenedorDados(List<BE.Dado> listaDados, ListBox contenedor, string msj = "Contenedor vacío.")
        {
            contenedor.Items.Clear();

            if (listaDados.Count > 0)
            {
                listaDados.ForEach(dado =>
                {
                    contenedor.Items.Add(dado);
                });
                contenedor.DisplayMember = "Valor";
            } else
            {
                contenedor.Items.Add(msj);
            }
        }

        private void ActualizarCubilete()
        {
            ActualizarContenedorDados(generala.Cubilete.Dados, Cubilete_listBox, "El cubilete esta vacío");
        }

        private void ActualizarDados()
        {
            ActualizarContenedorDados(generala.Tablero.DadosEnTablero, DadosEnTablero_listBox, "No hay dados en el tablero");
        }

        private void ActualizarDadosApartados()
        {
            ActualizarContenedorDados(generala.Tablero.DadosApartados, DadosApartados_listBox, "No hay dados apartados");         
        }

        private void TurnoJugado()
        {
            ActualizarCubilete();
            ActualizarDados();
            ActualizarDadosApartados();
            Tiros_lbl.Text = generala.Turno.TirosDisponibles >= 1 ? generala.Turno.TirosDisponibles.ToString() : "Te quedaste sin tiros";
        }

        // Métodos de Comprobación
        private void ComprobarTirosDisponibles()
        {
            if (generala.Turno.TirosDisponibles == 0) BloquearBotonesDados();
        }

        private void DetectarJuegoServido(BE.Tiro tiro)
        {
            if (tiro.CategoriaServida != BE.CategoriaServida.Ninguna) MessageBox.Show("¡Categoria servida obtenida!\n" + tiro.CategoriaServida);       
        }

        private void BloquearBotones()
        {
            CerrarCategoria_btn.Enabled = false;
            TirarDados_btn.Enabled = false;
        }

        private void DesbloquearBotones()
        {
            CerrarCategoria_btn.Enabled = true;
            TirarDados_btn.Enabled = true;
        }

        private void BloquearBotonesDados()
        {
            TirarDados_btn.Enabled = false;
            PonerDados_btn.Enabled = false;
            PonerTodos_btn.Enabled = false;
            ApartarDados_btn.Enabled = false;
        }

        private void DesbloquearBotonesDados()
        {
            TirarDados_btn.Enabled = true;
            PonerDados_btn.Enabled = true;
            PonerTodos_btn.Enabled = true;
            ApartarDados_btn.Enabled = true;
        }

        // Acciones del Juego
        private void ComenzarJuego()
        {
            ActualizarJugador();
            ActualizarCubilete();
            ActualizarDados();
            ActualizarDadosApartados();
        }

        // Botones del Formulario
        private void TirarDados_btn_Click(object sender, EventArgs e)
        {
            if (generala.Tablero.DadosEnTablero.Count == 0)
            {
                if (generala.Cubilete.Dados.Count != 0)
                {
                    BE.Tiro tiroJugado = gestor.Jugar(generala);
                    DetectarJuegoServido(tiroJugado);
                    TurnoJugado();
                    ComprobarTirosDisponibles();
                }
                else
                {
                    MessageBox.Show("¡El cubilete esta vacío!");
                }
            } else
            {
                MessageBox.Show("¡Todavía hay dados en el tablero!");
            }
        }

        private void CerrarCategoria_btn_Click(object sender, EventArgs e)
        {
            if (generala.Turno.TirosDisponibles < 3)
            {
                CerrarCategoria_frm frm = new CerrarCategoria_frm(generala, gestor);
                frm.ShowDialog();
                ActualizarPuntajes();
                if (generala.Turno.CategoriaCerrada != null) BloquearBotones();
            }
            else MessageBox.Show("Tirá al menos una vez los dados para poder cerrar una categoria.");
        }

        private void TerminarTurno_btn_Click(object sender, EventArgs e)
        {
            
                if (generala.Turno.CategoriaCerrada != null)
                {
                    gestor.TerminarTurno(generala);
                    if (!generala.PartidaTerminada)
                    {
                        DesbloquearBotones();
                        ActualizarJugador();
                        ActualizarDados();
                        ActualizarDadosApartados();
                        ActualizarCubilete();
                        DesbloquearBotonesDados();
                    } else {
                        _gestorPartida.Guardar(_partida);
                        _resumenPartida.ShowDialog();
                        if (_volverJugar)
                        {
                            BE.Partida nuevaPartida = _gestorPartida.NuevaPartida(_partida.Jugador01, _partida.Jugador02);
                            _partida = nuevaPartida;
                            ReiniciarJuego();
                        } else this.Close();
                    }
                } else MessageBox.Show("Es necesario Cerrar una categoria para poder terminar el turno.");
        }

        private void PonerDados_btn_Click(object sender, EventArgs e)
        {
            if (DadosEnTablero_listBox.SelectedItems.Count != 0)
            {
                List<BE.Dado> dadosSeleccionados = new List<BE.Dado>();
                foreach (object item in DadosEnTablero_listBox.SelectedItems)
                {
                    dadosSeleccionados.Add(item as BE.Dado);
                }

                BLL.Cubilete.PonerDados(generala.Cubilete, dadosSeleccionados);
                BLL.Tablero.QuitarDadoTablero(generala.Tablero, dadosSeleccionados);
                ActualizarDados();
                ActualizarCubilete();
            } else
            {
                MessageBox.Show("No hay dados seleccionados para agregar.");
            }
        }

        private void ApartarDados_btn_Click(object sender, EventArgs e)
        {
            if (DadosEnTablero_listBox.SelectedItems.Count != 0)
            {
                List<BE.Dado> dadosSeleccionados = new List<BE.Dado>();
                foreach(object item in DadosEnTablero_listBox.SelectedItems)
                {
                    dadosSeleccionados.Add(item as BE.Dado);
                }

                BLL.Tablero.ApartarDados(generala.Tablero, dadosSeleccionados);
                ActualizarDados();
                ActualizarDadosApartados();
            } else
            {
                MessageBox.Show("No hay dados seleccionados para apartar.");
            }
        }

        private void PonerTodos_btn_Click(object sender, EventArgs e)
        {
            if (!TableroVacio)
            {
                List<BE.Dado> todosDados = new List<BE.Dado>();
                foreach (object dado in DadosEnTablero_listBox.Items)
                {
                    todosDados.Add(dado as BE.Dado);
                }
                BLL.Cubilete.PonerDados(generala.Cubilete, todosDados);
                BLL.Tablero.QuitarDadoTablero(generala.Tablero, todosDados);
                ActualizarDados();
                ActualizarCubilete();
            } else
            {
                MessageBox.Show("No hay dados para agregar.");
            }
        }
        private void Ayuda_btn_Click(object sender, EventArgs e)
        {
            Reglas_frm frm = new Reglas_frm();
            frm.ShowDialog();
        }
    }
}
