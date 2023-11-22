using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Registros
{
    public partial class Registro_Frm : Form
    {
        private readonly BLL.SesionUsuario _gestorSesionUsuario;

        private readonly BLL.SesionPartida _gestorSesionPartida;

        private List<BE.SesionUsuario> _listaSesiones = new List<BE.SesionUsuario>();

        private List<BE.SesionPartida> _listaPartidas = new List<BE.SesionPartida>();

        public Registro_Frm()
        {
            InitializeComponent();
            _gestorSesionUsuario = new BLL.SesionUsuario();
            _gestorSesionPartida = new BLL.SesionPartida();
        }

        private void CargarSesiones()
        {
            Sesiones_dataGridView.Columns.Add("sesion_id", "Sesion ID");
            Sesiones_dataGridView.Columns.Add("usuario_nombre", "Usuario");
            Sesiones_dataGridView.Columns.Add("inicio", "Inicio");
            Sesiones_dataGridView.Columns.Add("final", "Final");

            for (int i = 0; i < _listaSesiones.Count; i++)
            {
                Sesiones_dataGridView.Rows.Add(1);
                Sesiones_dataGridView.Rows[i].Cells[0].Value = _listaSesiones[i].Id;
                Sesiones_dataGridView.Rows[i].Cells[1].Value = _listaSesiones[i].Usuario.Nombre;
                Sesiones_dataGridView.Rows[i].Cells[2].Value = _listaSesiones[i].Inicio;
                Sesiones_dataGridView.Rows[i].Cells[3].Value = _listaSesiones[i].Final;
            }
        }

        private void CargarPartidas()
        {
            Partidas_dataGridView.Columns.Add("sesion_id", "Sesión ID");
            Partidas_dataGridView.Columns.Add("usuario01_nombre", "Usuario 01");
            Partidas_dataGridView.Columns.Add("usuario02_nombre", "Usuario 02");
            Partidas_dataGridView.Columns.Add("inicio", "Inicio");
            Partidas_dataGridView.Columns.Add("final", "Final");            

            for(int i = 0; i < _listaPartidas.Count; i++)
            {
                Sesiones_dataGridView.Rows.Add(1);
                Partidas_dataGridView.Rows[i].Cells[0].Value = _listaPartidas[i].Id;
                Partidas_dataGridView.Rows[i].Cells[1].Value = _listaPartidas[i].Usuario01.Nombre;
                Partidas_dataGridView.Rows[i].Cells[2].Value = _listaPartidas[i].Usuario02.Nombre;
                Partidas_dataGridView.Rows[i].Cells[3].Value = _listaPartidas[i].Inicio;
                Partidas_dataGridView.Rows[i].Cells[4].Value = _listaPartidas[i].Final;
            }
        }

        private void Registro_Frm_Load(object sender, EventArgs e)
        {
            _listaSesiones = _gestorSesionUsuario.ObtenerTodas();
            _listaPartidas = _gestorSesionPartida.ObtenerTodas();
            CargarSesiones();
            CargarPartidas();
        }
    }
}
