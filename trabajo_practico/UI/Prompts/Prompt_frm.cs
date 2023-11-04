using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Promps
{
    public partial class Prompt_frm : Form
    {
        public string mensaje = "";

        public bool resultado = false;

        public Prompt_frm(string mensaje)
        {
            InitializeComponent();
            this.mensaje = mensaje;
        }

        private void Aceptar_btn_Click(object sender, EventArgs e)
        {
            resultado = true;
        }

        private void Cancelar_btn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
