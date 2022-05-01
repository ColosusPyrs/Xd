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
    public partial class CalcPenRec : Form
    {
        public CalcPenRec()
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
            float Y;
            float B;
            float X;
            float M;

            Y = Convert.ToSingle(textBox1.Text);
            B = Convert.ToSingle(textBox2.Text);
            X = Convert.ToSingle(textBox3.Text);

            M = (Y - B) / X;

            MessageBox.Show($"Resultado M: {M}");

            this.Hide();
            CalcInicio CalcI = new CalcInicio();
            CalcI.Show();
        }
    }
}
