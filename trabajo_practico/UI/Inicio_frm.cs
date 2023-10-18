using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
