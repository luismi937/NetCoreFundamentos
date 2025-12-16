using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace NetCoreFundamentos
{
    public partial class Form08StringBuilder : Form
    {
        public Form08StringBuilder()
        {
            InitializeComponent();
        }
        private void btnString_Click(object sender, EventArgs e)
        {
            Stopwatch krono = new Stopwatch();
            string cadena = this.txtRich.Text;
            int longitud = cadena.Length;
            krono.Start();
            for (int i = 0; i < longitud; i++)
            {
                //siempre recuperamos la ultima letra
                char letra = cadena[longitud - 1];
                //eliminamos la ultima letra
                cadena = cadena.Remove(longitud - 1, 1);
                //insertamos la letra en la posicion de i del bucle
                cadena = cadena.Insert(i, letra.ToString());
            }
            //Finalizamos el proceso
            krono.Stop();
            //el concepto Stopwatch contiene una serie de propiedades para comprobar 
            //el tiempo entre procesos
            this.lblTiempo.Text = "segundos"
                +krono.Elapsed.Seconds
                +"milisegundos"
                +krono.Elapsed.Milliseconds;
            this.txtRich.Text = cadena;


        }
        private void btnStringBuilder_Click(object sender, EventArgs e)
        {
            Stopwatch krono = new Stopwatch();
            //vamos a utilizar StringBuilder
            StringBuilder cadena = new StringBuilder();
            //para añadir usamos append
            cadena.Append(this.txtRich.Text);
            int longitud = cadena.Length;
            krono.Start();
            for (int i = 0; i < longitud; i++)
            {
                //siempre recuperamos la ultima letra
                char letra = cadena[longitud - 1];
                //eliminamos la ultima letra
                cadena = cadena.Remove(longitud - 1, 1);
                //insertamos la letra en la posicion de i del bucle
                cadena = cadena.Insert(i, letra.ToString());
            }
            //Finalizamos el proceso
            krono.Stop();
            //el concepto Stopwatch contiene una serie de propiedades para comprobar 
            //el tiempo entre procesos
            this.lblTiempo.Text = "segundos"
                + krono.Elapsed.Seconds
                + "milisegundos"
                + krono.Elapsed.Milliseconds;
            this.txtRich.Text = cadena.ToString();

        }
    }
}
