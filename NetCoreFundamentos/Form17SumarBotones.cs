using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    
    public partial class Form17SumarBotones : Form
    {
        List<Button> botones;
        public Form17SumarBotones()
        {
            InitializeComponent();
            this.botones = new List<Button>();
            //recorremos todos los botones del panel como solo he dibujado botones hacemos la abstraccion a button
            foreach(Button boton in this.panel1.Controls)
            {
                this.botones.Add(boton);
                boton.Click += SumarBoton;
            }
        }
        private void SumarBoton(object? sender, EventArgs e)
        {
           Button boton = (Button)sender;
           int valorBoton = int.Parse(boton.Text);
           int valorActual = int.Parse(this.textBox1.Text);
           int suma = valorActual + valorBoton;
              this.textBox1.Text = suma.ToString();
        }
        private void btnIniciar_Cick(object sender, EventArgs e)
        {
            Random random = new Random();
            foreach (Button boton in this.botones)
            {
                int aleat = random.Next(1, 10);
                boton.Text = aleat.ToString();
            }

        }
    }
}
