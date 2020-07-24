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
        double primero;
        double segundo;
        string operador;
        public Calculadora()
        {
            InitializeComponent();
        }

        Clases.ClsSuma obj = new Clases.ClsSuma();
        Clases.ClsResta obj2 = new Clases.ClsResta();
        Clases.ClsMultiplicacion obj3 = new Clases.ClsMultiplicacion();
        Clases.ClsDivision obj4 = new Clases.ClsDivision();
        private void btn0_Click(object sender, EventArgs e)
        {
            CalcScreen.Text = CalcScreen.Text + "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            CalcScreen.Text = CalcScreen.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            CalcScreen.Text = CalcScreen.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            CalcScreen.Text = CalcScreen.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            CalcScreen.Text = CalcScreen.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            CalcScreen.Text = CalcScreen.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            CalcScreen.Text = CalcScreen.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            CalcScreen.Text = CalcScreen.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            CalcScreen.Text = CalcScreen.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            CalcScreen.Text = CalcScreen.Text + "9";
        }

        private void btnpoint_Click(object sender, EventArgs e)
        {
            CalcScreen.Text = CalcScreen.Text + ".";
        }

        private void btnplus_Click(object sender, EventArgs e)
        {
            operador = "+";
            primero = double.Parse(CalcScreen.Text);
            CalcScreen.Clear();
        }

        private void btnsubtract_Click(object sender, EventArgs e)
        {
            operador = "-";
            primero = double.Parse(CalcScreen.Text);
            CalcScreen.Clear();
        }

        private void btnmultiplication_Click(object sender, EventArgs e)
        {
            operador = "*";
            primero = double.Parse(CalcScreen.Text);
            CalcScreen.Clear();
        }

        private void btndivision_Click(object sender, EventArgs e)
        {
            operador = "/";
            primero = double.Parse(CalcScreen.Text);
            CalcScreen.Clear();
        }

        private void btnequal_Click(object sender, EventArgs e)
        {
            segundo = double.Parse(CalcScreen.Text);

            double Sum;
            double Res;
            double Mul;
            double Div;

            switch(operador)
            {
                case "+":
                    Sum = obj.Sumar((primero), (segundo));
                    CalcScreen.Text = Sum.ToString();
                    break;
                case "-":
                    Res = obj2.Restar((primero), (segundo));
                    CalcScreen.Text = Res.ToString();
                    break;
                case "*":
                    Mul = obj3.Multiplicacion((primero), (segundo));
                    CalcScreen.Text = Mul.ToString();
                    break;
                case "/":
                    Div = obj4.Dividir((primero), (segundo));
                    CalcScreen.Text = Div.ToString();
                    break;
            }
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            CalcScreen.Clear();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (CalcScreen.Text.Length == 1)
                CalcScreen.Text = "";
            else
                CalcScreen.Text = CalcScreen.Text.Substring(0, CalcScreen.Text.Length - 1);
        }
    }
}
