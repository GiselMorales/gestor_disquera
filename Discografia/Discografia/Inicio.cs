using Discografia.disqueralizardDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Discografia
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }
        private void btIniciarSesion_Click(object sender, EventArgs e)
        {
            var fila = disqueralizardDataSet1.Usuarios
          .FirstOrDefault(u => u.Correo == txtCorreo.Text && u.Contraseña == txtContraseña.Text);

            if (fila != null)
            {
                Formdisqueraa menu = new Formdisqueraa();
                menu.tipoUsuario = fila.TipoUsuario;
                menu.nombreUsuario = fila.Nombre;
                menu.Show();
                this.Hide();
            }
            else
            {
                lblMensaje.Text = "Correo o contraseña incorrectos.";
            }
        }
        private void label2_Click(object sender, EventArgs e)
        { }

        private void Inicio_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos
            this.usuariosTableAdapter1.Fill(this.disqueralizardDataSet1.Usuarios);
        }
    }
}
