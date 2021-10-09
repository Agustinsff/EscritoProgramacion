using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVisual
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            Stock en = new Stock();
            en.StartPosition = FormStartPosition.CenterParent;
            en.ShowDialog();
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            Compras en = new Compras();
            en.StartPosition = FormStartPosition.CenterParent;
            en.ShowDialog();
        }
    }
}
