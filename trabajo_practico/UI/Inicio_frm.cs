using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Juego;
using UI.Login;
using UI.Registros;

namespace UI
{
    public partial class Inicio_frm : Form
    {
        private BE.Sesion _sesion01;

        private BE.Sesion _sesion02;

        private readonly BLL.Sesion _gestorSesion;

        private readonly BLL.Partida _gestorPartida;

        private readonly Ingresar_frm _ingresarFrm;

        private Tablero_frm _tableroFrm;

        public Inicio_frm()
        {
            InitializeComponent();
            _ingresarFrm = new Ingresar_frm();
            _ingresarFrm.LogearUsuario += Ingresar_frm_LogearUsuario;
            _sesion01 = null;
            _sesion02 = null;
            _gestorSesion = new BLL.Sesion();
            _gestorPartida = BLL.Partida.getInstance();
        }

        private void Tablerofrm_Closed(object sender, EventArgs e)
        {
            this.Show();
            _tableroFrm = null;
            GC.Collect();
        }

        private void Ingresar_frm_LogearUsuario(object sender, SesionEventArgs e)
        {
            if (_sesion01 == null) _sesion01 = e.SesionRetornada;
            else if (_sesion02 == null) _sesion02 = e.SesionRetornada;
        }

        private void Inicio_frm_Load(object sender, EventArgs e)
        {
            ComprobarUsuarios();
        }

        private void ComprobarUsuarios()
        {
            NombreUsuario1_lbl.Text = _sesion01 == null ? "No hay usuario logeado" : _sesion01.Usuario.Nombre;
            NombreUsuario2_lbl.Text = _sesion02 == null ? "No hay usuario logeado" : _sesion02.Usuario.Nombre;
        }

        private void Jugar_btn_Click(object sender, EventArgs e)
        {
            if (_sesion01 == null || _sesion02 == null)
            {
                MessageBox.Show("¡Se necesitan dos usuarios para poder jugar!");
            } else
            {
                this.Hide();
                _tableroFrm = new Tablero_frm(_sesion01.Usuario, _sesion02.Usuario);
                _tableroFrm.Closed += Tablerofrm_Closed;
                _tableroFrm.ShowDialog();
            }
        }

        private void Registrarse_btn_Click(object sender, EventArgs e)
        {
            Registrar_frm form = new Registrar_frm();
            form.ShowDialog();
        }

        private void Ingresar_btn_Click(object sender, EventArgs e)
        {
            if (_sesion01 == null || _sesion02 == null)
            {
                _ingresarFrm.ShowDialog();
                ComprobarUsuarios();
                DetectarUsuario();
            }
            else
            {
                MessageBox.Show("¡Límite de usuarios conectados!");
            }
        }

        private void Cerrar_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DetectarUsuario()
        {
            if (_sesion01 != null) CerrarSesion1_btn.Visible = true;
            if (_sesion02 != null) CerrarSesion2_btn.Visible = true;
        }

        private void CerrarSesionInputs(Label label, Button btn)
        {
            label.Text = "No hay usuario logeado";
            btn.Visible = false;
        }

        private void CerrarSesion1_btn_Click(object sender, EventArgs e)
        {            
            CerrarSesionInputs(NombreUsuario1_lbl, CerrarSesion1_btn);
            _gestorSesion.Guardar(_sesion01);
            _sesion01 = null;
        }

        private void CerrarSesion2_btn_Click(object sender, EventArgs e)
        {
            CerrarSesionInputs(NombreUsuario2_lbl, CerrarSesion2_btn);
            _gestorSesion.Guardar(_sesion02);
        }

        private void VerRegistros_btn_Click(object sender, EventArgs e)
        {
            Registro_Frm form = new Registro_Frm();
            form.ShowDialog();
        }
    }
}
