using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AntennVerificator
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        private static double Erf(double x)
        {
            // constants
            double a1 = 0.254829592;
            double a2 = -0.284496736;
            double a3 = 1.421413741;
            double a4 = -1.453152027;
            double a5 = 1.061405429;
            double p = 0.3275911;

            // Save the sign of x
            int sign = 1;
            if (x < 0)
                sign = -1;
            x = Math.Abs(x);

            // A&S formula 7.1.26
            double t = 1.0 / (1.0 + p * x);
            double y = 1.0 - (((((a5 * t + a4) * t) + a3) * t + a2) * t + a1) * t * Math.Exp(-x * x);

            return sign * y;
        }

        private void myButton1_Click(object sender, EventArgs e)
        {
            var k0 = 2;
            var n = 10;
            //var Pш = 0.046;
            double[] Pc = new double[] { 0.21, 0.28, 0.35, 0.44, 0.54, 0.61, 0.7, 0.8, 0.88, 0.95, 0.98 };
            double D;

            D = 0.5 * (1 - Erf((k0 - n * Pc[0]) / (System.Math.Sqrt(n * Pc[0] * (1 - Pc[0])))));
            textBox1.Text = D.ToString();
        }
    }
}
