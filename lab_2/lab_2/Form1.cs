using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace lab_2
{
    public partial class Form1 : Form
    {
        double A, B, K;
        double x, y, y_2;
        public Form1()
        {
            InitializeComponent();
            KeyPreview = true;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.Rows.Clear();
                chart2.Series[0].Points.Clear();
                if (string.IsNullOrWhiteSpace(textBox4.Text)
                    || string.IsNullOrWhiteSpace(textBox5.Text)
                    || string.IsNullOrWhiteSpace(textBox6.Text))
                {
                    MessageBox.Show("Ви не заповнили всі поля", "Помилка");
                }
                A = double.Parse(textBox6.Text);
                B = double.Parse(textBox5.Text);
                K = double.Parse(textBox4.Text);
                x = A;
                int index = 0;
                while (x < B)
                {
                    y = Math.Pow(x + 1,2)/4;
                    y_2 = Math.Pow(x - 1, 2) / 4;
                    if (y < 50 && y > -50 && y_2 < 50 && y_2 > -50)
                    {

                        chart3.Series[0].Points.AddXY(x, y);
                        chart3.Series[1].Points.AddXY(x, y_2);
                        
                    }
                    if (y_2 / y < 50 && y_2 / y > -50 && y / y_2 < 50 && y / y_2 > -50)
                    {
                        chart2.Series[0].Points.AddXY(x, y_2 / y);
                        chart2.Series[1].Points.AddXY(x, y / y_2);
                    }
                    if (!Double.IsNaN(y) || !Double.IsNaN(y_2))
                    {
                        dataGridView2.Rows.Add(y,y_2, x);
                        dataGridView2.Rows[index].HeaderCell.Value = (++index).ToString();
                    }
                    
                    x += (B - A) / K;
                }         
            }
            catch { }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = (TextBox)sender; 
            if (char.IsDigit(e.KeyChar)||e.KeyChar == (char)Keys.Back)
            {
                return;
            }
            else if ((e.KeyChar == '.' && !string.IsNullOrEmpty(textBox.Text) && !textBox.Text.Contains(".") && textBox.Text != "-"))
            {
                return;
            }
            else if ((e.KeyChar == '-' && string.IsNullOrEmpty(textBox.Text) && !textBox.Text.Contains("-")))
            {
                return;
            }
            e.Handled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.Rows.Clear();
                chart1.Series[0].Points.Clear();
                
                if (string.IsNullOrWhiteSpace(textBox1.Text) 
                    || string.IsNullOrWhiteSpace(textBox2.Text) 
                    || string.IsNullOrWhiteSpace(textBox3.Text))
                {
                    MessageBox.Show("Ви не заповнили всі поля", "Помилка");
                }
                A = double.Parse(textBox1.Text);
                B = double.Parse(textBox2.Text);
                K = double.Parse(textBox3.Text);
                x = A;
                int index = 0;
                while (x < B)
                {
                    if (x != 0)
                    {
                        y = Math.Pow(x, 1/x);
                        if (y <= 100)
                        {
                            chart1.Series[0].Points.AddXY(x, y);
                        }
                    }
                    else
                    {
                        y = 0;
                    }
                    if (!Double.IsNaN(y))
                    {
                        dataGridView1.Rows.Add(y, x);
                        dataGridView1.Rows[index].HeaderCell.Value = (++index).ToString();
                    }
                    else
                    {
                        dataGridView1.Rows.Add('-', '-');
                        dataGridView1.Rows[index].HeaderCell.Value = (++index).ToString();
                    }
                    x += (B - A) / K;
                }
            }
            catch { }
        }
    }
}
