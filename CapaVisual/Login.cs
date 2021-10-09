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
    public partial class Login : Form
    {
        int time = 300;
        Form mainForm;
        Image fondo;
        Color formColor;

        public Login()
        {
            InitializeComponent();
        }
        private void Login_Load(object sender, EventArgs e)
        {
            formColor = this.BackColor;
            fondo = this.BackgroundImage;
            panelBienvenida.Location = new Point(this.Width / 2 - panelBienvenida.Width / 2, this.Height / 2 - panelBienvenida.Height / 2); //centrado en el form
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            lblError.Visible = false;
            string respuesta = UsuarioControlador.Login(txtUser.Text, txtPass.Text);
            if (respuesta.Length > 0)
            {
                lblError.Text = respuesta;
                lblError.Visible = true;
            }
            else
            {
                mainForm = new CapaVisual.Main();
                timerBienvenida.Start();
                panelLogin.Visible = false;
                label2.Visible = false;
            }
        }

        private void timerBienvenida_Tick(object sender, EventArgs e)
        {
            if (time > 0)
            {
                time -= 1;
                if (this.BackColor == Color.FromArgb(0, 0, 0))
                {
                    transicionBienvenida.Show(panelBienvenida);
                }
                else
                {
                    this.BackgroundImage = null;
                    this.BackColor = Color.FromArgb(this.BackColor.R - 1, this.BackColor.G - 1, this.BackColor.B - 1);
                }
            }
            else
            {
                Restaurar();
                timerBienvenida.Stop();
                this.Hide();
                mainForm.Show();
            }
        }
        private void Restaurar()
        {
            time = 300;
            panelBienvenida.Visible = false;
            panelLogin.Visible = true;
            label2.Visible = true;
            this.BackgroundImage = fondo;
            this.BackColor = formColor;
        }

    }
}
