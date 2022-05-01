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
    public partial class CalcEneCinPot : Form
    {
        public CalcEneCinPot()
        {
            InitializeComponent();
        }

        private void Atras_Click(object sender, EventArgs e)
        {
            this.Hide();
            CalcInicio CalcI = new CalcInicio();
            CalcI.Show();
        }

        private void Resultado_Click(object sender, EventArgs e)
        {
            float masa=0;
            float velocidad=0;
            float metrosSegundos=0;
            float eC=0;

            masa = Convert.ToSingle(textBox1.Text);
            velocidad = Convert.ToSingle(textBox2.Text);

            metrosSegundos = ((velocidad * 1000) / 3600);

            eC = ((metrosSegundos * metrosSegundos) * masa) / 2;

            MessageBox.Show($"Energia cinetica: {eC}.");

            this.Hide();
            CalcInicio CalcI = new CalcInicio();
            CalcI.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float masa;
            float altura;
            float eP;

            masa = Convert.ToSingle(textBox3.Text);
            altura = Convert.ToSingle(textBox4.Text);

            eP = masa * 9.81f * altura;

            MessageBox.Show($"Energia potencial: {eP}.");

            this.Hide();
            CalcInicio CalcI = new CalcInicio();
            CalcI.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
