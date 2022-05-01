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
    public partial class CalcPotEle : Form
    {
        public CalcPotEle()
        {
            InitializeComponent();
        }

        private void Atras_Click(object sender, EventArgs e)
        {
            this.Hide();
            CalcInicio CalcI = new CalcInicio();
            CalcI.Show();
        }

        private void ResultadoCinetica_Click(object sender, EventArgs e)
        {
            float W;
            float q;
            float V;

            W = Convert.ToSingle(textBox1.Text);
            q = Convert.ToSingle(textBox2.Text);

            V = W / q;

            MessageBox.Show($"Resultado: {V}.");

            this.Hide();
            CalcInicio CalcI = new CalcInicio();
            CalcI.Show();
        }
    }
}
