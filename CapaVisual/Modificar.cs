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
    public partial class Modificar : Form
    {
        int idProducto;

        public Modificar(int id, string nombre, string descripcion, int stock, int precio)
        {
            InitializeComponent();

            idProducto = id;
            lblId.Text += id.ToString();
            txtNombre.Text = nombre;
            txtDesc.Text = descripcion;
            txtStock.Text = stock.ToString();
            txtPrecio.Text = precio.ToString();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string respuesta = SouvenirsControlador.Modificar(idProducto, txtNombre.Text, txtDesc.Text, txtStock.Text, txtPrecio.Text);

            if (respuesta.Length > 0)
            {
                txtError.Text = respuesta;
                txtError.Visible = true;
            }
            else
            {
                MessageBox.Show("Producto modificado con exito");
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
