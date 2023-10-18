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
        }

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
    }
}
