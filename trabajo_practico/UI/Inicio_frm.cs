using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Login;

namespace UI
{
    public partial class Inicio_frm : Form
    {
        public Inicio_frm()
        {
            InitializeComponent();
        }

        private void Jugar_btn_Click(object sender, EventArgs e)
        {
            Juego.Tablero_frm form = new Juego.Tablero_frm();
            form.Show();
            this.Hide();    
        }

        private void Registrarse_btn_Click(object sender, EventArgs e)
        {
            Registrar_frm form = new Registrar_frm();
            form.ShowDialog();
        }

        private void Ingresar_btn_Click(object sender, EventArgs e)
        {
            Ingresar_frm form = new Ingresar_frm();
            form.ShowDialog();
        }

        private void Cerrar_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
