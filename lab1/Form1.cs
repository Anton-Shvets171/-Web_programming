using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtN_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buCompute_Click(object sender, EventArgs e)
        {
            int n = 0, m = 0;
            double P, A, C;

            n = Convert.ToInt32(txtN.Text);
            m = Convert.ToInt32(txtM.Text);

            P = factorial(n);
            A = factorial(n) / factorial(n - m);
            C = factorial(n) / (factorial(m) * factorial(n - m));


            lbP.Text = Convert.ToString(P);
            lbA.Text = Convert.ToString(A);
            lbC.Text = Convert.ToString(C);

        }

        int factorial (int a)
        {
            int fa = 1;
            for (int i = 1; i <= a; i++)
            {
                fa *= i;
            }
            return fa;
        }
    }
}
