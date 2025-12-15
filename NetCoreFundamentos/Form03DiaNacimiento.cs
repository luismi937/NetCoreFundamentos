using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form03DiaNacimiento : Form
    {
        public Form03DiaNacimiento()
        {
            InitializeComponent();
        }
        private void BtnMostrar_Click(object? sender, EventArgs e)
        {
            int dia = int.Parse(this.txtDia.Text);
            int mes = int.Parse(this.txtMes.Text);
            int año = int.Parse(this.txtAño.Text);
            if  (mes == 1)
            {
                mes = 13;
                año--;
            }else if (mes == 2)
            {
                mes = 14;
                año--;
            }
            //multiplicar el mes mas 1 por 3 / 5
            int op1 = (mes + 1) * 3 / 5;
            int op2 = año / 4;
            int op3 = año / 100;
            int op4 = año / 400;
            int op5 = dia + (mes * 2) + año + op1 + op2 - op3 + op4 + 2;
            int op6 = op5 / 7;
            int resultado = op5 - (op6 * 7);

            string diaSemana = "";
            if (resultado == 0)
            {
                diaSemana = "Sabado";
            } else if (resultado == 1)
            {
                diaSemana = "Domingo";
            }
            else if (resultado == 2)
            {
                diaSemana = "Lunes";
            }
            else if (resultado == 3)
            {
                diaSemana = "Martes";
            }
            else if (resultado == 4)
            {
                diaSemana = "Miércoles";
            }
            else if (resultado == 5)
            {
                diaSemana = "Jueves";
            }
            else if (resultado == 6)
            {
                diaSemana = "Viernes";
            }
            else
            {
                diaSemana = "ERROR LOGICO";
            }
            lblSolucion.Text = "el dia de la semana es" + diaSemana;
        }
    }
}

