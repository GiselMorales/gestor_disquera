using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Discografia
{
    public partial class Formbase : Form
    {
        protected BindingSource bindingSource;

        public Formbase()
        {
            InitializeComponent();
        }
        protected void EstablecerBindingSource(BindingSource bs)
        {
            bindingSource = bs;
            MostrarPosicion(); 
        }

        protected void MostrarPosicion()
        {
            if (bindingSource == null)
            {
                etPosicion.Text = "Sin datos";
                return;
            }
            int total = bindingSource.Count;
            if (total == 0)
                etPosicion.Text = "No hay registros";
            else
                etPosicion.Text = $"{bindingSource.Position + 1} de {total}";
        }
        protected void btRegresar_Click(object sender, EventArgs e)
        {
         this.Close();


        }

        protected virtual void btañadir_Click(object sender, EventArgs e)
        {
            DataTable tabla = ((DataSet)bindingSource.DataSource).Tables[bindingSource.DataMember];
            DataRow nuevaFila = tabla.NewRow();
            tabla.Rows.Add(nuevaFila);
            MostrarPosicion();
        }

        protected virtual void btbuscar_Click(object sender, EventArgs e)
        {
            string textoBusqueda = ctBuscar.Text.ToLower();

            for (int i = 0; i < bindingSource.Count; i++)
            {
                var fila = (DataRowView)bindingSource[i];
                if (fila.Row.ItemArray.Any(campo => campo.ToString().ToLower().Contains(textoBusqueda)))
                {
                    bindingSource.Position = i;
                    MostrarPosicion();
                    return;
                }
            }

            MessageBox.Show("No se encontró el registro", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
        protected void btPrimero_Click(object sender, EventArgs e)
        {
            bindingSource.Position = 0;
            MostrarPosicion();
        }

        protected void btAnterior_Click(object sender, EventArgs e)
        {
            if (bindingSource.Position > 0)
                bindingSource.Position--;
            MostrarPosicion();
        }

        protected void btSiguiente_Click(object sender, EventArgs e)
        {
            try
            {
                if (bindingSource.Position < bindingSource.Count - 1)
                    bindingSource.Position++;
                MostrarPosicion();
            }
            catch {
                if (bindingSource.Count == null)
                    MessageBox.Show("No hay registros para mostrar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        protected void btUltimo_Click(object sender, EventArgs e)
        {
            bindingSource.Position = bindingSource.Count - 1;
            MostrarPosicion();
        }

        private void Formbase_Load(object sender, EventArgs e)
        {

        }

        private void btborrar_Click(object sender, EventArgs e)
        {

        }
    }
}
