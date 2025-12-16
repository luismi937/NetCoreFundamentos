using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form13TiendaProductos : Form
    {
        public Form13TiendaProductos()
        {
            InitializeComponent();

            // Ajustes de selección
            lstCosas.SelectionMode = SelectionMode.MultiExtended;
            lstAlmacen.SelectionMode = SelectionMode.One;

            // Suscribir eventos
            btnNuevo.Click += btnNuevo_Click;
            btnEliminar.Click += btnEliminar_Click;
            btnBorrar.Click += btnBorrar_Click;
            btnSeleccion.Click += btnSeleccion_Click;
            btnTodos.Click += btnTodos_Click;
            btnSubir.Click += btnSubir_Click;
            btnBajar.Click += btnBajar_Click;
            txtProductos.TextChanged += txtProductos_TextChanged;
        }

        private void txtProductos_TextChanged(object sender, EventArgs e)
        {
            // Restaurar color por si se marcó como repetido
            txtProductos.BackColor = SystemColors.Window;
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            string producto = txtProductos.Text.Trim();
            if (string.IsNullOrEmpty(producto))
            {
                MessageBox.Show("Introduce el nombre del producto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtProductos.Focus();
                return;
            }
            // Comprobar duplicados en la tienda (case-insensitive)
            for (int i = 0; i < lstCosas.Items.Count; i++)
            {
                if (string.Equals(lstCosas.Items[i].ToString(), producto, StringComparison.OrdinalIgnoreCase))
                {
                    // Marcar: seleccionar el existente y colorear la caja de texto
                    lstCosas.SelectedIndex = i;
                    lstCosas.Focus();
                    txtProductos.BackColor = Color.LightSalmon;
                    MessageBox.Show("Producto repetido en Tienda. No se añade.", "Repetido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            // Añadir producto
            lstCosas.Items.Add(producto);
            txtProductos.Clear();
            txtProductos.Focus();
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (lstCosas.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Seleccione uno o varios productos en Tienda para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            // Eliminar múltiples seleccionados (recorrer en reversa para índices)
            for (int i = lstCosas.SelectedIndices.Count - 1; i >= 0; i--)
            {
                int idx = lstCosas.SelectedIndices[i];
                lstCosas.Items.RemoveAt(idx);
            }
        }
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (lstCosas.Items.Count == 0)
            {
                return;
            }

            // Borrar todos los de la Tienda
            lstCosas.Items.Clear();
        }
        private void btnSeleccion_Click(object sender, EventArgs e)
        {
            if (lstCosas.SelectedItems.Count == 0)
            {
                MessageBox.Show("Seleccione productos en Tienda para enviar al Almacén.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Copiar seleccionados a lista temporal para poder eliminarlos luego
            List<string> seleccionados = new List<string>();
            foreach (var item in lstCosas.SelectedItems)
            {
                seleccionados.Add(item.ToString());
            }

            // Añadir al Almacén (evitar duplicados en almacén) y eliminar de la tienda
            foreach (string s in seleccionados)
            {
                bool existeEnAlmacen = false;
                for (int i = 0; i < lstAlmacen.Items.Count; i++)
                {
                    if (string.Equals(lstAlmacen.Items[i].ToString(), s, StringComparison.OrdinalIgnoreCase))
                    {
                        existeEnAlmacen = true;
                        break;
                    }
                }
                if (!existeEnAlmacen)
                {
                    lstAlmacen.Items.Add(s);
                }

                // eliminar de tienda (puede mostrar indices cambiantes, por eso Remove)
                lstCosas.Items.Remove(s);
            }
        }
        private void btnTodos_Click(object sender, EventArgs e)
        {
            if (lstCosas.Items.Count == 0)
            {
                return;
            }

            // Mover todo al Almacén (evitar duplicados en almacén)
            List<string> todos = new List<string>();
            for (int i = 0; i < lstCosas.Items.Count; i++)
            {
                todos.Add(lstCosas.Items[i].ToString());
            }

            foreach (string s in todos)
            {
                bool existeEnAlmacen = false;
                for (int i = 0; i < lstAlmacen.Items.Count; i++)
                {
                    if (string.Equals(lstAlmacen.Items[i].ToString(), s, StringComparison.OrdinalIgnoreCase))
                    {
                        existeEnAlmacen = true;
                        break;
                    }
                }

                if (!existeEnAlmacen)
                {
                    lstAlmacen.Items.Add(s);
                }
            }

            // Vaciar la tienda
            lstCosas.Items.Clear();
        }
        private void btnSubir_Click(object sender, EventArgs e)
        {
            int idx = lstAlmacen.SelectedIndex;
            if (idx <= 0)
            {
                // idx == -1 (no seleccionado) o ya está en la primera posición
                return;
            }

            object item = lstAlmacen.Items[idx];
            lstAlmacen.Items.RemoveAt(idx);
            lstAlmacen.Items.Insert(idx - 1, item);
            lstAlmacen.SelectedIndex = idx - 1;
            lstAlmacen.Focus();
        }
        private void btnBajar_Click(object sender, EventArgs e)
        {
            int idx = lstAlmacen.SelectedIndex;
            if (idx < 0 || idx >= lstAlmacen.Items.Count - 1)
            {
                // no seleccionado o ya en la última posición
                return;
            }

            object item = lstAlmacen.Items[idx];
            lstAlmacen.Items.RemoveAt(idx);
            lstAlmacen.Items.Insert(idx + 1, item);
            lstAlmacen.SelectedIndex = idx + 1;
            lstAlmacen.Focus();
        }
    }
}