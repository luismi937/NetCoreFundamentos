using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form18SumaCheckbox : Form
    {
        List<CheckBox> checkBoxes;

        public Form18SumaCheckbox()
        {
            InitializeComponent();
            this.checkBoxes = new List<CheckBox>();

            // collect checkboxes from the panel and wire events (matching your Designer names)
            foreach (CheckBox checkBox in this.panel1.Controls)
            {
                this.checkBoxes.Add(checkBox);
                checkBox.CheckedChanged += SumarCheck;
            }

            // optional: attach click handler to the Sum button
            this.btnSuma.Click += btnSuma_Click;
        }

        // event invoked when any checkbox changes state
        private void SumarCheck(object? sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender!;
            int valorCheck = int.Parse(checkBox.Text);
            int valorActual = 0;

            // parse current value safely
            if (!int.TryParse(this.textBox1.Text, out valorActual))
            {
                valorActual = 0;
            }

            // add or subtract depending on checked state
            int resultado = checkBox.Checked ? valorActual + valorCheck : valorActual - valorCheck;
            this.textBox1.Text = resultado.ToString();
        }

        // recompute sum from scratch (useful if you want a deterministic total)
        private void btnSuma_Click(object? sender, EventArgs e)
        {
            int suma = 0;
            foreach (CheckBox checkBox in this.checkBoxes)
            {
                if (checkBox.Checked)
                {
                    suma += int.Parse(checkBox.Text);
                }
            }
            this.textBox1.Text = suma.ToString();
        }
    }
}