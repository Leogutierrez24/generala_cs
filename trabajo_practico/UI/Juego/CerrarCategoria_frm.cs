using System;
using JUEGO;
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
    public partial class CerrarCategoria_frm : Form
    {

        public readonly Generala generala;

        public CerrarCategoria_frm(Generala generala)
        {
            InitializeComponent();
            this.generala = generala;
        }

        private void CargarCategorias()
        {
            generala.Turno.JugadorEnJuego.Categorias.ForEach(categoria =>
            {
                if (categoria.Cerrada != true) Categorias_listBox.Items.Add(categoria);
            });
        }

        private void CargarDados()
        {
            generala.Dados.ForEach(dado => DadosObtenidos_listBox.Items.Add(dado));
        }

        private void CerrarCategoria_frm_Load(object sender, EventArgs e)
        {
            CargarCategorias();
            CargarDados();            
        }

        private void CerrarCategoria_btn_Click(object sender, EventArgs e)
        {
            if (Categorias_listBox.SelectedItems.Count == 1)
            {
                generala.PuntuarCerrarCategoria(Categorias_listBox.SelectedItem as Categoria);
                Close();
            } else
            {
                MessageBox.Show("Selecciona una categoria para poder continuar."); ;
            }
        }

        private void Cancelar_btn_Click(object sender, EventArgs e)
        {
            Close();
        }

        
    }
}
