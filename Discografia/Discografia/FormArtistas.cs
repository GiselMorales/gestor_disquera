using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Discografia
{
    public partial class FormArtistas : Discografia.Formbase
    {
        public string TipoUsuario { get; set; }
        public FormArtistas()
        {
            InitializeComponent();
            bindingSource = artistasBindingSource;
        }

        private void FormArtistas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'disqueralizardDataSet.Artistas' Puede moverla o quitarla según sea necesario.
            this.artistasTableAdapter.Fill(this.disqueralizardDataSet.Artistas);
            MostrarPosicion();
            if (TipoUsuario == "Invitado")
            {
                btañadir.Enabled = false;
                btborrar.Enabled = false;
            }

        }
        protected override void btañadir_Click(object sender, EventArgs e)
        {
            DataTable tabla = ((DataSet)bindingSource.DataSource).Tables[bindingSource.DataMember];
            DataRow nuevaFila = tabla.NewRow();
            nuevaFila["IDArtista"] = "837";
            nuevaFila["Nombre"] = "Nombre temporal";
            nuevaFila["Nacionalidad"] = "Nombre temporal";

            tabla.Rows.Add(nuevaFila);
            MostrarPosicion();
        }
    }
}
