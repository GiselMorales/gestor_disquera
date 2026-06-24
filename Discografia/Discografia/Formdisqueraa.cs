using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Discografia
{
    public partial class Formdisqueraa : Form
    {
        public string tipoUsuario { get; set; }
        public string nombreUsuario { get; set; }
        public string TipoUsuario { get; private set; }

        public Formdisqueraa()
        {
            InitializeComponent();
            this.tipoUsuario = tipoUsuario;
            this.nombreUsuario = nombreUsuario;
        }

        private void Formdisqueraa_Load(object sender, EventArgs e)
        {
            this.usuariosTableAdapter1.Fill(this.disqueralizardDataSet1.Usuarios);

            // Ocultar todos por defecto
            btArtistas.Visible = false;
            btAlbumes.Visible = false;
            btCanciones.Visible = false;
            btProductores.Visible = false;
            btColaboraciones.Visible = false;
            btVentas.Visible = false;
            btaggusuario.Visible = false;

            switch (this.tipoUsuario)
            {
                case "Admin":
                    btArtistas.Visible = true;
                    btAlbumes.Visible = true;
                    btCanciones.Visible = true;
                    btProductores.Visible = true;
                    btColaboraciones.Visible = true;
                    btVentas.Visible = true;
                    btaggusuario.Visible = true;
                    break;
                case "Editor":
                    btArtistas.Visible = true;
                    btAlbumes.Visible = true;
                    btColaboraciones.Visible = true;
                    btCanciones.Visible = true;
                    lblcolabs.Visible = false;
                    lblproductores.Visible = false;
                    lblventas.Visible = false;
                    break ;
                case "Invitado":
                    btArtistas.Visible = true;
                    btAlbumes.Visible = true;
                    lblventas.Visible= false;
                    lblcolabs.Visible= false;
                    lblproductores.Visible= false;
                    lblcanciones.Visible= false;
                    break;
            }
        }
        private void btArtistas_Click(object sender, EventArgs e)
        {
            FormArtistas fa = new FormArtistas();
            fa.TipoUsuario = this.TipoUsuario;
            fa.ShowDialog();
            

        }

        private void btAlbumes_Click(object sender, EventArgs e)
        {
            FormAlbum fa = new FormAlbum();
            fa.ShowDialog();
        }

        private void btCanciones_Click(object sender, EventArgs e)
        {
            FormCancio fc = new FormCancio();
            fc.ShowDialog();
        }

        private void btVentas_Click(object sender, EventArgs e)
        {
            FormVentas fc = new FormVentas();
            fc.ShowDialog();
        }

        private void btColaboraciones_Click(object sender, EventArgs e)
        {
            FormColabs fc = new FormColabs();
            fc.ShowDialog();
        }

        private void btProductores_Click(object sender, EventArgs e)
        {
            FormProductores fc = new FormProductores();
            fc.ShowDialog();
        }

        private void btcerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            Inicio inicio = new Inicio();
            inicio.Show();
        }
    }
}
