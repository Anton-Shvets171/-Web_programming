using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            this.Closing += OnClosing;
            InitializeComponent();
            InitializeInputData();
        }

        private void InitializeInputData()
        {
            try
            {
                using var reader = XmlReader.Create("input-data.xml");
                var serializer = new XmlSerializer(typeof(InputData));
                var data = (InputData) serializer.Deserialize(reader);
                txtN.Text = data.N.ToString();
                txtM.Text = data.M.ToString();
                Compute();
            }
            catch (Exception j)
            {
            }
        }

        private void OnClosing(object sender, CancelEventArgs e)
        {
            var data = new InputData
            {
                N = Convert.ToInt32(txtN.Text),
                M = Convert.ToInt32(txtM.Text)
            };
            using var writer = XmlWriter.Create("input-data.xml");
            var serializer = new XmlSerializer(data.GetType());
            serializer.Serialize(writer, data);
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
            Compute();
        }

        private void Compute()
        {
            int n = 0, m = 0;
            long P, A, C = 0;

            n = Convert.ToInt32(txtN.Text);
            m = Convert.ToInt32(txtM.Text);

            P = GetP(n);
            A = GetA(n, m);
            C = GetC(A, GetP(m));

            lbP.Text = Convert.ToString(P);
            lbA.Text = Convert.ToString(A);
            lbC.Text = Convert.ToString(C);
        }

        private static long GetP(int n)
        {
            long res = 1;
            for (int i = 2; i <= n; i++)
                res *= i;
            return res;
        }

        private static long GetA(int n, int m)
        {
            long res = 1;
            int cur = n;
            for (int i = 0; i < m; i++)
            {
                res *= cur;
                cur--;
            }

            return res;
        }

        private static long GetC(long A, long P)
        {
            return A / P;
        }
    }
}