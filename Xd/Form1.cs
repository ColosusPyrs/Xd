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
    public partial class CalcInicio : Form
    {
        public CalcInicio()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //No quitar por nada en el mundo.
            //Si se elimina, la ventana se jode.
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void AreaHeron_Click(object sender, EventArgs e)
        {
            this.Hide();
            CalcHaron CalcH = new CalcHaron();
            CalcH.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Calc2doGrado Calc2G = new Calc2doGrado();
            Calc2G.Show();
        }

        private void EnergiaCineticaPotencial_Click(object sender, EventArgs e)
        {
            this.Hide();
            CalcEneCinPot CalcECP = new CalcEneCinPot();
            CalcECP.Show();
        }

        private void PotencialEle_Click(object sender, EventArgs e)
        {
            this.Hide();
            CalcPotEle CalcPE = new CalcPotEle();
            CalcPE.Show();
        }

        private void IntencidadLeyCoulomb_Click(object sender, EventArgs e)
        {
            this.Hide();
            CalcIntLeyCou CalcILC = new CalcIntLeyCou();
            CalcILC.Show();
        }

        private void PendienteRecta_Click(object sender, EventArgs e)
        {
            this.Hide();
            CalcPenRec CalcPR = new CalcPenRec();
            CalcPR.Show();
        }
    }
}
