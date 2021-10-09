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
    public partial class Stock : Form
    {
        public Stock()
        {
            InitializeComponent();
        }

        private void Stock_Load(object sender, EventArgs e)
        {
            CargarStock();
        }

        private void CargarStock()
        {
            dgvStock.Rows.Clear();
            DataTable dtstock = SouvenirsControlador.Listar();

            for (int i = 0; i < dtstock.Rows.Count; i++)
            {
                dgvStock.Rows.Add(dtstock.Rows[i][0], dtstock.Rows[i][1], dtstock.Rows[i][2], dtstock.Rows[i][3], dtstock.Rows[i][4], dtstock.Rows[i][5]);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Agregar en = new Agregar();
            en.StartPosition = FormStartPosition.CenterParent;
            en.ShowDialog();
            CargarStock();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int selectedId = int.Parse(dgvStock.CurrentRow.Cells[0].Value.ToString());
            DialogResult result = MessageBox.Show("Realmente desea eliminar el producto con id "+ selectedId +" ?", "Confirmación", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                SouvenirsControlador.Eliminar(selectedId);
            }
            CargarStock();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Modificar en = new Modificar(
                int.Parse(dgvStock.CurrentRow.Cells[0].Value.ToString()), 
                dgvStock.CurrentRow.Cells[1].Value.ToString(), 
                dgvStock.CurrentRow.Cells[2].Value.ToString(), 
                int.Parse(dgvStock.CurrentRow.Cells[3].Value.ToString()), 
                int.Parse(dgvStock.CurrentRow.Cells[4].Value.ToString())
                );

            en.StartPosition = FormStartPosition.CenterParent;
            en.ShowDialog();
            CargarStock();
        }
    }
}
