using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Xd
{
    public partial class Calc2doGrado : Form
    {
        public Calc2doGrado()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            //No quitar por nada en el mundo.
            //Si se elimina, la ventana se jode.
        }

        private void SeparadorHaron_Click(object sender, EventArgs e)//???
        {

        }

        private void Atras_Click(object sender, EventArgs e)
        {
            this.Hide();
            CalcInicio CalcI = new CalcInicio();
            CalcI.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Lado3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Lado2_Click(object sender, EventArgs e)
        {

        }

        private void Lado1_Click(object sender, EventArgs e)
        {

        }

        private void Resultado_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);
            double c = Convert.ToDouble(textBox3.Text);
            double r1, r2, m;

            m = Math.Pow(b, 2);

            r1 = (-b + (Math.Sqrt(m - 4 * a * c))) / (2 * a);
            r2 = (-b - (Math.Sqrt(m - 4 * a * c))) / (2 * a);


            MessageBox.Show($"X1: {r1}.\nX2: {r2}.");

            this.Hide();
            CalcInicio CalcI = new CalcInicio();
            CalcI.Show();
        }
    }
}
