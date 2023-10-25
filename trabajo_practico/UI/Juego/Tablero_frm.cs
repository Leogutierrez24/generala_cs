using JUEGO;
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
        public Generala generala;

        public bool TableroVacio = false;

        public Tablero_frm()
        {
            InitializeComponent();
            generala = new Generala();
        }

        private void Tablero_frm_Load(object sender, EventArgs e)
        {
            generala.NuevoJugador("Jugador 01");
            generala.NuevoJugador("Jugador 02");

            CrearTablero();

            generala.IniciarJuego();
            this.ComenzarJuego();
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
        }

        private void ActualizarJugador()
        {
            Jugador_groupBox.Text = generala.Turno.JugadorEnJuego.Nombre;
            Tiros_lbl.Text = generala.Turno.TirosDisponibles.ToString();
        }

        private void ActualizarCubilete()
        {
            Cubilete_listBox.Items.Clear();

            if (generala.Cubilete.Dados.Count > 0)
            {
                generala.Cubilete.Dados.ForEach(dado =>
                {
                    Cubilete_listBox.Items.Add(dado);
                });
            } else
            {
                Cubilete_listBox.Items.Add("El cubilete esta vacío");
            }
        }

        private void ActualizarDados()
        {
            DadosEnTablero_listBox.Items.Clear();

            if (generala.Tablero.DadosEnTablero.Count > 0)
            {
                TableroVacio = false;
                generala.Tablero.DadosEnTablero.ForEach(dado =>
                {
                    DadosEnTablero_listBox.Items.Add(dado);
                });
            } else
            {
                TableroVacio = true;
                DadosEnTablero_listBox.Items.Add("No hay dados en el tablero");
            }
            
        }

        private void ActualizarDadosApartados()
        {
            DadosApartados_listBox.Items.Clear();

            if (generala.Tablero.DadosApartados.Count > 0)
            {
                generala.Tablero.DadosApartados.ForEach(dado =>
                {
                    DadosApartados_listBox.Items.Add(dado);
                });
            } else
            {
                DadosApartados_listBox.Items.Add("No hay dados apartados");
            }
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
            if (generala.Turno.TirosDisponibles == 0)
            {
                TirarDados_btn.Enabled = false;
                PonerDados_btn.Enabled = false;
                PonerTodos_btn.Enabled = false;
                ApartarDados_btn.Enabled = false;
            }
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
                    generala.Jugar();
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

        }

        private void TerminarTurno_btn_Click(object sender, EventArgs e)
        {

        }

        private void PonerDados_btn_Click(object sender, EventArgs e)
        {
            if (DadosEnTablero_listBox.SelectedItems.Count != 0)
            {
                List<Dado> dadosSeleccionados = new List<Dado>();
                foreach (object item in DadosEnTablero_listBox.SelectedItems)
                {
                    dadosSeleccionados.Add(item as Dado);
                }

                generala.PonerDadosCubilete(dadosSeleccionados);
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
                List<Dado> dadosSeleccionados = new List<Dado>();
                foreach(object item in DadosEnTablero_listBox.SelectedItems)
                {
                    dadosSeleccionados.Add(item as Dado);
                }

                generala.Tablero.ApartarDados(dadosSeleccionados);
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
                List<Dado> todosDados = new List<Dado>();
                foreach (object dado in DadosEnTablero_listBox.Items)
                {
                    todosDados.Add(dado as Dado);
                }
                generala.PonerDadosCubilete(todosDados);
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
