using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form09Isbn : Form
    {
        public Form09Isbn()
        {
            InitializeComponent();
        }
        private void btnValidar_CLick(object sender, EventArgs e)
        {
            // Usamos String tal y como pediste
            String isbn = txtIsbn.Text.Trim();

            // Comprobar que tiene exactamente 10 caracteres
            if (isbn.Length != 10)
            {
                label2.Text = "Debe introducir 10 caracteres.";
                label2.ForeColor = Color.Red;
                return;
            }

            // Comprobar que todos los caracteres son dígitos
            for (int i = 0; i < 10; i++)
            {
                if (!char.IsDigit(isbn[i]))
                {
                    label2.Text = "ISBN debe contener solo dígitos.";
                    label2.ForeColor = Color.Red;
                    return;
                }
            }

            // Calcular suma: cada dígito multiplicado por su posición (1..10)
            int suma = 0;
            for (int i = 0; i < 10; i++)
            {
                int digito = isbn[i] - '0';
                suma += digito * (i + 1);
            }

            // Comprobar resto entre 11
            if (suma % 11 == 0)
            {
                label2.Text = "ISBN Correcto";
                label2.ForeColor = Color.Green;
            }
            else
            {
                label2.Text = "ISBN Incorrecto";
                label2.ForeColor = Color.Red;
            }
        }
    }
}
