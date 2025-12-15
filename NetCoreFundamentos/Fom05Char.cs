using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Fom05Char : Form
    {
        public Fom05Char()
        {
            InitializeComponent();
        }
        private void btnASCII_Click(object sender, EventArgs e)
        {
            for (int i =  0; i <= 255; i++)
            {
                char caracter = (char)i;
                if (char.IsLetter(caracter) == true)
                {
                    this.txtLetras.Text = this.txtLetras.Text + caracter;

                }else if (char.IsNumber(caracter) == true)
                {
                    this.txtNumeros.Text = this.txtNumeros.Text + caracter;
                }
                else if (char.IsPunctuation(caracter) == true)
                {
                    this.txtPuntuacion.Text = this.txtPuntuacion.Text + caracter;
                }
            }
        }
    }
}
