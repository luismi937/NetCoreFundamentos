using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form06EMail : Form
    {
        public Form06EMail()
        {
            InitializeComponent();
        }
        private void btnValidar_Click(object sender, EventArgs e)
        {
            string email = this.txtEmail.Text?.Trim() ?? string.Empty;
            if (string.IsNullOrWhiteSpace(email))
            {
                this.lblResultado.Text = "Introduce un correo electrónico.";
                this.lblResultado.ForeColor = Color.Orange;
                return;
            }

            int arrobaPos = email.IndexOf('@');
            int puntoPos = email.LastIndexOf('.');
            if (arrobaPos > 0 && puntoPos > arrobaPos + 1 && puntoPos < email.Length - 1)
            {
                this.lblResultado.Text = "El correo electrónico es válido.";
                this.lblResultado.ForeColor = Color.Green;
            }
            else
            {
                this.lblResultado.Text = "El correo electrónico no es válido.";
                this.lblResultado.ForeColor = Color.Red;
            }
        }
    }
}