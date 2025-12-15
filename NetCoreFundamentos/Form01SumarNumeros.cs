using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form01SumarNumeros : Form
    {
        public Form01SumarNumeros()
        {
            InitializeComponent();
        }

        private void btnSumar_Click_1(object sender, EventArgs e)
        {
            //Leer los numeros
            string textoNumero1 = this.txtNumero1.Text;
            string textoNumero2 = this.txtNumero2.Text;
            //Convertir a enteros
            int numero1 = int.Parse(textoNumero1);
            int numero2 = int.Parse(textoNumero2);
            //Sumar
            int resultado = numero1 + numero2;
            //Mostrar el resultado
            this.lblResultado.Text = "El resultado es: " + resultado;
        }
    }
}
