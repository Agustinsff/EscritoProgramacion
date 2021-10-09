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
    public partial class Compra : Form
    {
        int id_producto;

        public Compra(int id, string nombre, string descripcion, int stock, int precio)
        {
            InitializeComponent();

            txtCantidad.Text = "1";
            id_producto = id;
            lblId.Text += id.ToString();
            lblNombre.Text += nombre;
            lblDesc.Text += descripcion;
            lblStock.Text += stock.ToString();
            lblPrecio.Text += precio.ToString();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            string respuesta = CompraConstrolador.Compra(id_producto, txtCantidad.Text);

            txtError.Visible = false;
            if (respuesta.Length > 0)
            {
                txtError.Text = respuesta;
                txtError.Visible = true;
            }
            else
            {
                MessageBox.Show("Compra realizada");
                this.Close();
            }
        }
    }
}
