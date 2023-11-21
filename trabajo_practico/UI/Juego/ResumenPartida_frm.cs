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
    public partial class ResumenPartida_frm : Form
    {
        public BE.Generala generala;

        public BLL.Generala gestor;

        public delegate void delNuevoJuego(object sender, NuevoJuegoEventArgs e);

        public event delNuevoJuego NuevoJuego;

        public bool nuevoJuego = false;

        public ResumenPartida_frm(BE.Generala generala, BLL.Generala gestor)
        {
            InitializeComponent();
            this.generala = generala;
            this.gestor = gestor;
        }

        private void ResumenPartida_frm_Load(object sender, EventArgs e)
        {
            TablaCategorias_dataGridView.DataSource = null;
            for (int i = 0; i < generala.Jugadores.Count; i++)
            {
                if (i == 0) TablaCategorias_dataGridView.Columns.Add("", "Categorias");
                TablaCategorias_dataGridView.Columns.Add($"Jugador {i + 1}", generala.Jugadores[i].Nombre);
            }

            generala.Categorias.ForEach(categoria =>
            {
                TablaCategorias_dataGridView.Rows.Add(categoria.Nombre);
            });

            for (int i = 0; i < generala.Jugadores.Count; i++)
            {
                for (int j = 0; j < generala.Categorias.Count; j++)
                {
                   TablaCategorias_dataGridView.Rows[j].Cells[i + 1].Value = generala.Jugadores[i].Categorias[j].Puntos;
                }
            }

            PtsJugador01Titulo_lbl.Text = $"Pts obtenidos por {generala.Jugadores[0].Nombre}";
            PtsJugador02Titulo_lbl.Text = $"Pts obtenidos por {generala.Jugadores[1].Nombre}";
            this.ActualizarInfo();
        }

        private void ActualizarInfo()
        {
            JugadorGanador_lbl.Text = generala.Ganador.Nombre;
            PtsJugador01_lbl.Text = BLL.Jugador.CalcularPuntajeTotal(generala.Jugadores[0]).ToString();
            PtsJugador02_lbl.Text = BLL.Jugador.CalcularPuntajeTotal(generala.Jugadores[1]).ToString();
        }

        private void VolverJugar_btn_Click(object sender, EventArgs e)
        {
            nuevoJuego = true;
            NuevoJuego?.Invoke(this, new NuevoJuegoEventArgs(nuevoJuego));
            this.Close();
        }

        private void VolverInicio_btn_Click(object sender, EventArgs e)
        {
            nuevoJuego = false;
            NuevoJuego?.Invoke(this, new NuevoJuegoEventArgs(nuevoJuego));
            this.Close();
        }
    }
}
