using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogica;

namespace CapaVisual
{
    public partial class Agregar : Form
    {
        public Agregar()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string respuesta = SouvenirsControlador.Alta(txtNombre.Text, txtDesc.Text, txtStock.Text, txtPrecio.Text);

            txtError.Visible = false;
            if (respuesta.Length > 0)
            {
                txtError.Text = respuesta;
                txtError.Visible = true;
            }
            else
            {
                MessageBox.Show("Se agrego el producto con exito");
                Limpiar();
            }
        }

        private void Limpiar()
        {
            txtError.Visible = false;
            txtNombre.Text = "";
            txtDesc.Text = "";
            txtPrecio.Text = "";
            txtStock.Text = "";
        }
    }
}
