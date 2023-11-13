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
        public Ingresar_frm()
        {
            InitializeComponent();
        }

        private bool CamposVacios()
        {
            bool inputsVacios = false;
            if (string.IsNullOrEmpty(Usuario_textBox.Text) || string.IsNullOrEmpty(Password_textBox.Text)) inputsVacios = true;
            return inputsVacios;
        }

        private void MostarError(string error)
        {
            Error_lbl.Text = error;
            Error_lbl.Visible = true;
        }

        private void OcultarError()
        {
            Error_lbl.Text = string.Empty;
            Error_lbl.Visible = false;
        }

        private void Ingresar_frm_Load(object sender, EventArgs e)
        {

        }

        private void Ingresar_btn_Click(object sender, EventArgs e)
        {
            OcultarError();
            if (!CamposVacios())
            {

            } else
            {
                MostarError("¡Hay campos vacíos!");
            }
        }

        private void Volver_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
