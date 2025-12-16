using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form12ColeccionNumeros : Form
    { // Campo para mantener el generador y la colección de números
        private readonly Random random = new Random();
        private readonly List<int> numeros = new List<int>();
        public Form12ColeccionNumeros()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnGenerar_Click(object sender, EventArgs e)
            {
            // Limpiar colección y listbox
            numeros.Clear();
            lstNumeros.Items.Clear();
            txtSuma.Text = string.Empty;
            txtPares.Text = string.Empty;
            txtImpares.Text = string.Empty;

            // Generar 10 números aleatorios entre 1 y 100 (inclusive 1, exclusivo 101)
            for (int i = 0; i < 10; i++)
            {
                int valor = random.Next(1, 101);
                numeros.Add(valor);
                lstNumeros.Items.Add(valor);
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            if (numeros.Count == 0)
            {
                MessageBox.Show("Primero genere los números.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int sumaTotal = 0;
            int sumaPares = 0;
            int sumaImpares = 0;

            foreach (int n in numeros)
            {
                sumaTotal += n;
                if (n % 2 == 0)
                {
                    sumaPares += n;
                }
                else
                {
                    sumaImpares += n;
                }
            }

            txtSuma.Text = sumaTotal.ToString();
            txtPares.Text = sumaPares.ToString();
            txtImpares.Text = sumaImpares.ToString();
        }
    }
}
