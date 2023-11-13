using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace UI.Login
{
    public partial class Registrar_frm : Form
    {
        public Registrar_frm()
        {
            InitializeComponent();
        }

        private bool ComprobarCampos()
        {
            bool inputsVacios = false;
            if (string.IsNullOrEmpty(Usuario_textBox.Text) || string.IsNullOrEmpty(Password_textBox.Text) || string.IsNullOrEmpty(PasswordRep_textBox.Text)) inputsVacios = true;
            return inputsVacios;
        }

        private bool ComprobarPassword()
        {
            bool passwordValida = true;
            if (Password_textBox.Text != PasswordRep_textBox.Text) passwordValida = false;
            return passwordValida;
        }

        private void MostrarError(string error)
        {
            Error_lbl.Text = error;
            Error_lbl.Visible = true;
        }

        private void LimpiarError()
        {
            Error_lbl.Text = string.Empty;
            Error_lbl.Visible = false;
        }

        private void Registrar_frm_Load(object sender, EventArgs e)
        {
            
        }

        private void CrearUsuario_btn_Click(object sender, EventArgs e)
        {
            LimpiarError();
            if (!ComprobarCampos())
            {
                if (ComprobarPassword())
                {
                    MessageBox.Show("Usuario creado");
                }
                else
                {
                    MostrarError("Las contraseñas no coinciden");
                }
            }
            else
            {
                MostrarError("Hay campos vacíos");
            }
        }

        private void Cancelar_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
