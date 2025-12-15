using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form02ColoresPosicion : Form
    {
        // Flag to ensure the button position changes only once
        //private bool hasPositionChanged = false;

        public Form02ColoresPosicion()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void btnPosicion_Click(object sender, EventArgs e)
        {
          int posX = int.Parse(this.txtPosX.Text);
          int posY = int.Parse(this.txtPosY.Text);
        }

        private void buttonCambiar_Click(object sender, EventArgs e)
        {
            int rojo = int.Parse(this.txtRojo.Text);
            int verde = int.Parse(this.txtVerde.Text);
            int azul = int.Parse(this.txtAzul.Text);
            if( rojo < 0 || rojo > 255)
            {
                MessageBox.Show("el valor de rojo debe estar entre 0 y 255");
            }
            else if(verde < 0 || verde > 255)
            {
                MessageBox.Show("el valor de verde debe estar entre 0 y 255");
            }
            else if (azul < 0 || azul > 255)
            {
                MessageBox.Show("el valor de azul debe estar entre 0 y 255");
            }
            else
            {

                this.BackColor = Color.FromArgb(rojo, verde, azul);
            }

        }
    }
}
