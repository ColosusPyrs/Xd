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
    public partial class CalcIntLeyCou : Form
    {
        public CalcIntLeyCou()
        {
            InitializeComponent();
        }

        private void Atras_Click(object sender, EventArgs e)
        {
            this.Hide();
            CalcInicio CalcI = new CalcInicio();
            CalcI.Show();
        }

        private void ResultadoCoulomb_Click(object sender, EventArgs e)
        {
            
            /*
             * Ya funciona, soy god y estoy mamadicimo olv. >:v
             */

            double q1;
            double q2;
            double r;
            double K;
            double F;

            q1 = (q1 = Convert.ToSingle(textBox1.Text)) * Math.Pow(10, -6);

            q2 = (q2 = Convert.ToSingle(textBox2.Text)) * Math.Pow(10, -6);

            r = Math.Pow(((r = Convert.ToSingle(textBox3.Text)) * 0.01), 2);

            K = 9 * (Math.Pow(10, 9));

            F = K * (q1 * q2) / r;

            MessageBox.Show($"Resultado: {F}N.");

            this.Hide();
            CalcInicio CalcI = new CalcInicio();
            CalcI.Show();
        }
    }
}
