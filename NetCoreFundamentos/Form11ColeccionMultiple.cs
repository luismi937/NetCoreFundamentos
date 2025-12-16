using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form11ColeccionMultiple : Form
    {
        public Form11ColeccionMultiple()
        {
            InitializeComponent();
            //la lista tendra seleccion multiple
            this.lstElementos.SelectionMode = SelectionMode.MultiExtended;
        }
        private void btnInsertar_Click(object sender, EventArgs e)
        {
            string elem = this.txtNuevo.Text;
            this.lstElementos.Items.Add(elem);
            this.txtNuevo.Focus();
            this.txtNuevo.SelectAll();

        }
        private void btnSeleccionados_CLick(object sender, EventArgs e)
        {
            string indices = "";
            string items = "";
            //vamos a recorrer los elementos seleccionados 
            foreach(string item in this.lstElementos.SelectedItems)
            {
                items += item + ", ";
            }
            //Visualizamos los indices seleccionados
            foreach(int index in this.lstElementos.SelectedIndices)
            {
                indices += index + ", ";
            }
            this.lblIndex.Text = indices.Trim(',');
            this.lblItem.Text = items.Trim(',');

        }
        private void btnBorrarTodo_Click(object senncer, EventArgs e)
        {
            this.lstElementos.Items.Clear();
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //quiero eliminar los elementos seleccionados 
            //para las acciones sobre las colecciones siempre
            //con bucles for usare el metodo removeAt por lo que reccorremos 
            //la coleccion selectedIndices 
           //debemos eliminar de forma inversa para que los indices no afecten al elemnto eliminado
           int numElementos = this.lstElementos.SelectedIndices.Count -1;
            for(int i = numElementos; i >=0; i--)
            {
                int index = this.lstElementos.SelectedIndices[i];
                //eliminamos de la coleccion
                this.lstElementos.Items.RemoveAt(index);

            }
        }
    }
}
