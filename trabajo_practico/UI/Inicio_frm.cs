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
        public BE.Usuario usuario01;

        public BE.Usuario usuario02;

        private BE.SesionUsuario _sesion01;

        private BE.SesionUsuario _sesion02;

        private BE.SesionPartida _partida;

        private readonly BLL.SesionUsuario _gestorSesion;

        private readonly BLL.SesionPartida _gestorPartida;

        private readonly Ingresar_frm _ingresarFrm;

        private Tablero_frm _tableroFrm;

        public Inicio_frm()
        {
            InitializeComponent();
            _ingresarFrm = new Ingresar_frm();
            _ingresarFrm.LogearUsuario += Ingresar_frm_LogearUsuario;
            usuario01 = null;
            usuario02 = null;
            _gestorSesion = new BLL.SesionUsuario();
            _gestorPartida = new BLL.SesionPartida();
        }

        private void Tablerofrm_Closed(object sender, EventArgs e)
        {
            this.Show();
            _tableroFrm = null;
            GC.Collect();
        }

        private void Ingresar_frm_LogearUsuario(object sender, UsuarioEventArgs e)
        {
            if (usuario01 == null)
            {
                usuario01 = e.UsuarioRetornado;
                _sesion01 = _gestorSesion.NuevaSesionUsuario(usuario01);
            }
            else if (usuario02 == null)
            {
                usuario02 = e.UsuarioRetornado;
                _sesion02 = _gestorSesion.NuevaSesionUsuario(usuario02);
            }
        }

        private void Inicio_frm_Load(object sender, EventArgs e)
        {
            ComprobarUsuarios();
        }

        private void ComprobarUsuarios()
        {
            NombreUsuario1_lbl.Text = usuario01 == null ? "No hay usuario logeado." : usuario01.Nombre;
            NombreUsuario2_lbl.Text = usuario02 == null ? "No hay usuario logeado." : usuario02.Nombre;
        }

        private void Jugar_btn_Click(object sender, EventArgs e)
        {
            if (usuario01 == null || usuario02 == null)
            {
                MessageBox.Show("¡Se necesitan dos usuarios para poder jugar!");
            } else
            {
                this.Hide();
                _partida = _gestorPartida.NuevaPartida(usuario01, usuario02);
                _tableroFrm = new Tablero_frm(usuario01, usuario02, _partida, _gestorPartida);
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
            if (usuario01 == null || usuario02 == null)
            {
                _ingresarFrm.ShowDialog();
                ComprobarUsuarios();
                DetectarUsuario();
            }
            else
            {
                MessageBox.Show("¡Ya no pueden ingresar más usuarios!");
            }
        }

        private void Cerrar_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DetectarUsuario()
        {
            if (usuario01 != null) CerrarSesion1_btn.Visible = true;
            if (usuario02 != null) CerrarSesion2_btn.Visible = true;
        }

        private void CerrarSesionInputs(Label label, Button btn)
        {
            label.Text = "No hay usuario logeado.";
            btn.Visible = false;
        }

        private void CerrarSesion1_btn_Click(object sender, EventArgs e)
        {
            usuario01 = null;
            CerrarSesionInputs(NombreUsuario1_lbl, CerrarSesion1_btn);
            _gestorSesion.Guardar(_sesion01);
            _sesion01 = null;
        }

        private void CerrarSesion2_btn_Click(object sender, EventArgs e)
        {
            usuario02 = null;
            CerrarSesionInputs(NombreUsuario2_lbl, CerrarSesion2_btn);
            _gestorSesion.Guardar(_sesion02);
            _sesion02 = null;
        }

        private void VerRegistros_btn_Click(object sender, EventArgs e)
        {
            Registro_Frm form = new Registro_Frm();
            form.ShowDialog();
        }
    }
}
