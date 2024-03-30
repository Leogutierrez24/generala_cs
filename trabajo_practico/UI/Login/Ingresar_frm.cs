using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Login
{
    public partial class Ingresar_frm : Form
    {
        private readonly BLL.Usuario gUsuario;

        private readonly BLL.Sesion gSesion;

        public delegate void IngresarDelegado(object sender, SesionEventArgs e);

        public event IngresarDelegado LogearUsuario;

        public Ingresar_frm()
        {
            InitializeComponent();
            gUsuario = new BLL.Usuario();
            gSesion = new BLL.Sesion();
        }

        private bool CamposVacios()
        {
            bool inputsVacios = false;
            if (string.IsNullOrEmpty(Usuario_textBox.Text) || string.IsNullOrEmpty(Password_textBox.Text)) inputsVacios = true;
            return inputsVacios;
        }

        private void MostrarError(string error)
        {
            Error_lbl.Text = error;
            Error_lbl.Visible = true;
        }

        private void OcultarError()
        {
            Error_lbl.Text = string.Empty;
            Error_lbl.Visible = false;
        }

        private void LimpiarInputs()
        {
            Usuario_textBox.Text = string.Empty;
            Password_textBox.Text = string.Empty;
        }

        private void Ingresar_frm_Load(object sender, EventArgs e)
        {

        }

        private void Ingresar_btn_Click(object sender, EventArgs e)
        {
            OcultarError();
            if (!CamposVacios())
            {
                BE.Usuario u = new BE.Usuario
                {
                   Nombre = Usuario_textBox.Text,
                   Password = Password_textBox.Text,
                };

                u = gUsuario.Ingresar(u);

                if (u != null)
                {
                    BE.Sesion nuevaSesion = gSesion.NuevaSesion(u);
                    LogearUsuario?.Invoke(this, new SesionEventArgs(nuevaSesion));
                    LimpiarInputs();
                    this.Close();
                }
                else MostrarError("Nombre de usuario o contraseña inválidos.");
            } else MostrarError("¡Hay campos vacíos!");
        }

        private void Volver_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
