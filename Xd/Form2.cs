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
    public partial class CalcHaron : Form
    {
        private float a, b, c;
        private float perimetro, semiPerimetro, area;

        public CalcHaron()
        {
            InitializeComponent();
        }

        private void Atras_Click(object sender, EventArgs e)
        {
            this.Hide();
            CalcInicio CalcI = new CalcInicio();
            CalcI.Show();
        }

        private void lado1_Click(object sender, EventArgs e) //???
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            a = Convert.ToSingle(textBox1.Text);
        }

        private void CalcHaron_Load(object sender, EventArgs e)
        {
            //No quitar por nada en el mundo.
            //Si se elimina, la ventana se jode.
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            b = Convert.ToSingle(textBox2.Text);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            c = Convert.ToSingle(textBox3.Text);
        }

        private float Heron(float a, float b, float c)
        {
            float aux;

            perimetro = a + b + c;
            semiPerimetro = perimetro / 2;

            aux = a;
            a = semiPerimetro - aux;
            aux = b;
            b = semiPerimetro - aux;
            aux = c;
            c = semiPerimetro - aux;

            aux = semiPerimetro * a * b * c;

            area = Convert.ToSingle(Math.Sqrt(aux));

            return area;
        }

        private void Resultado_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Resultado:\n{Heron(a, b, c)}");

            this.Hide();
            CalcInicio CalcI = new CalcInicio();
            CalcI.Show();
        }
    }
}
