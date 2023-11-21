using System;
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

        public readonly BE.Generala generala;
        public readonly BLL.Generala gestor;

        public CerrarCategoria_frm(BE.Generala generala, BLL.Generala gestor)
        {
            InitializeComponent();
            this.generala = generala;
            this.gestor = gestor;
        }

        private void CargarCategorias()
        {
            generala.Turno.JugadorEnJuego.Categorias.ForEach(categoria =>
            {
                if (categoria.Cerrada != true) Categorias_listBox.Items.Add(categoria);
            });
            Categorias_listBox.DisplayMember = "Nombre";
        }

        private void CargarDados()
        {
            generala.Dados.ForEach(dado => DadosObtenidos_listBox.Items.Add(dado));
            DadosObtenidos_listBox.DisplayMember = "Valor";
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
                gestor.PuntuarCerrarCategoria(generala, Categorias_listBox.SelectedItem as BE.Categoria);
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
