using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculadora : Form
    {
        double num1 = 0;
        double num2 = 0;
        char Operacion;

        public Calculadora()
        {
            InitializeComponent();
        }
        private void añadirNumero(string numero)
        {
            if (textMain.Text == "0")
                textMain.Text = "";

            textMain.Text += numero;
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            var revisar = ((Button)sender);
                añadirNumero(revisar.Text);
        }

        private void btnUno_Click(object sender, EventArgs e)
        {
            var revisar = ((Button)sender);
            añadirNumero(revisar.Text);
        }

        private void btnDos_Click(object sender, EventArgs e)
        {
            var revisar = ((Button)sender);
            añadirNumero(revisar.Text);
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            var revisar = ((Button)sender);
            añadirNumero(revisar.Text);
        }

        private void btnCuatro_Click(object sender, EventArgs e)
        {
            var revisar = ((Button)sender);
            añadirNumero(revisar.Text);
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            var revisar = ((Button)sender);
            añadirNumero(revisar.Text);
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            var revisar = ((Button)sender);
            añadirNumero(revisar.Text);
        }

        private void btnSiete_Click(object sender, EventArgs e)
        {
            var revisar = ((Button)sender);
            añadirNumero(revisar.Text);
        }

        private void btnOcho_Click(object sender, EventArgs e)
        {
            var revisar = ((Button)sender);
            añadirNumero(revisar.Text);
        }

        private void btnNueve_Click(object sender, EventArgs e)
        {
            var revisar = ((Button)sender);
            añadirNumero(revisar.Text);
        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            var revisar = ((Button)sender);
            añadirNumero(revisar.Text);

            if (!textMain.Text.Contains("."))
            {
                textMain.Text += ".";
            }
        }

        private void operadores(object sender, EventArgs e)
        {
            var revisar = ((Button)sender);

            num1 = Convert.ToDouble(textMain.Text);
            Operacion = Convert.ToChar(revisar.Tag);

            textMain.Text = "0";
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            num2 = Convert.ToDouble(textMain.Text);

            if (Operacion == '+')
            {
                textMain.Text = (num1 + num2).ToString();
                num1 = Convert.ToDouble(textMain.Text);
            }

            if (Operacion == '-')
            {
                textMain.Text = (num1 - num2).ToString();
                num1 = Convert.ToDouble(textMain.Text);
            }

            if (Operacion == 'x')
            {
                textMain.Text = (num1 * num2).ToString();
                num1 = Convert.ToDouble(textMain.Text);
            }

            if (Operacion == '÷')
            {
                textMain.Text = (num1 / num2).ToString();
                num1 = Convert.ToDouble(textMain.Text);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (textMain.Text.Length > 1)
            {
                textMain.Text = textMain.Text.Substring(0, textMain.Text.Length - 1);
            }
            else
            {
                textMain.Text = "0";
            }
        }

        private void borrarTodo_Click(object sender, EventArgs e)
        {
            
            textMain.Text = "0";
            
        }

        private void btnSigno_Click(object sender, EventArgs e)
        {
          

            num1 = Convert.ToDouble(textMain.Text);
            num1 *= -1;
            textMain.Text = num1.ToString();

        }
    }
}
