using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form10ColeccionGrafica : Form
    {
        public Form10ColeccionGrafica()
        {
            InitializeComponent();
        }
        private void btnInsertar_CLick(object sender, EventArgs e)
        {
            string elem = this.txtNuevo.Text;
            this.lstElementos.Items.Add(elem);
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //string elemSeleccionado = this.lstElementos.SelectedItem.ToString();
            //this.lstElementos.Items.Remove(elemSeleccionado);
            int index = this.lstElementos.SelectedIndex;
            this.lstElementos.Items.RemoveAt(index);
        }
        private void btnBorrarTodo_Click(object sender, EventArgs e)
        {
            this.lstElementos.Items.Clear();
        }
        private void lstElementos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.lstElementos.SelectedIndex != -1)
            {
                this.lblIndex.Text = this.lstElementos.SelectedIndex.ToString();
                this.lblItem.Text = this.lstElementos.SelectedItem.ToString();
            }
        }
    }
}
