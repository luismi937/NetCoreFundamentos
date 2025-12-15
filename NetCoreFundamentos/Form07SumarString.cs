using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form07SumarString : Form
    {
        public Form07SumarString()
        {
            InitializeComponent();
        }
        private void btnSumar_Click(object sender, EventArgs e)
        {
            string textoNumeros = this.txtNumeros.Text;
            int suma = 0;
            //recorre,pos todo el contemido de textonumeros
            for(int i=0; i < textoNumeros.Length; i++)
            {
                //extraer cada caracter
                char caracter = textoNumeros[i];
                //convertir el caracter a numero
                int numero = int.Parse(caracter.ToString());
                suma += numero;

            }
            this.lblResultado.Text = "La suma es: " + suma;
        }
    }
}
