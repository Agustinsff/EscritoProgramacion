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
    public partial class Compras : Form
    {
        public Compras()
        {
            InitializeComponent();
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

        private void btnComprar_Click(object sender, EventArgs e)
        {
            Compra en = new Compra(
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

        private void Compras_Load(object sender, EventArgs e)
        {
            CargarStock();
        }
    }
}
