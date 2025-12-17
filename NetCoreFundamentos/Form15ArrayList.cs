using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form15ArrayList : Form
    {
        public Form15ArrayList()
        {
            InitializeComponent();
            //creamos una coleccion generica
            List<Control> botones = new List<Control>();
            //detecta automaticamente los elementos
            botones.Add(this.button1);
            botones.Add(this.button2);
            botones.Add(this.button3);
            botones.Add(this.textBox1);
            botones[0].BackColor = Color.AliceBlue;






            //Vamos a crear una coleccion no tipada
            ArrayList coleccion = new ArrayList();
            coleccion.Add(this.button1);
            coleccion.Add(this.button2);
            coleccion.Add(this.button3);
            // si deseamos acceder a un objeto y modificar alguna caracteristica 
            //necesitamos reaizar casting 
            ((Button)coleccion[0]).BackColor = Color.Aqua;
            //podemos realizar casting con foreach
            foreach(Button boton in coleccion)
            {
                boton.BackColor = Color.Beige;
            }
            //y si añadimos otro control que no sea button
            coleccion.Add(this.textBox1);
            //nos abstraemos para casting en todos los objetos
            foreach(Control boton in coleccion)
            {
                boton.BackColor = Color.Beige;
                //cuabdo tenemos multiples objetos de diferentes clases
                //nos podemos abstraer del recorrido pero a lo mejor
                //necesitamos alguna caraceristica especial de cada uno
                if(boton is TextBox)
                {
                    ((TextBox)boton).Paste();
                }
            }
            this.button1.Click += MetodoDelegado; 

            void MetodoDelegado(object sender, EventArgs e)
            {
                
            }
        }

        private void Button1_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
