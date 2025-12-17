using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form16ListDelegados : Form
    {
        int contador;
        public Form16ListDelegados()
        {
            InitializeComponent();
            //inicializamos la variable contador
            this.contador = 0;
            //almacenamos todos los componentes bototnes en una nueva coleccion
            List<Button> botones = new List<Button>();
            //añadimos dinamicamente los botones del formulario
            foreach(Button control in this.Controls)
            {
                if(control is Button)
                {
                    botones.Add(control);
                }
                    

            }
            //vamos a crear un metodo para que todos los botones lean
            //al ser pulsados
             foreach(Button boton in botones)
            {
               boton.Click += PulsarBoton;


            }

        }

        private void PulsarBoton(object? sender, EventArgs e)
        {
            this.contador += 1;
            this.textBox1.Text = this.contador.ToString();
            //queremos acceder al objeto que ha realizado la peticion al metodo
            //Mediante sender se captura dicho objeto
            ((Button)sender).BackColor = Color.AliceBlue;
            sender.Text = "Pulsado";
        }
    }
}
