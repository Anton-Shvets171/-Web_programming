using Receivers.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Receivers
{
    public partial class Form1 : Form
    {
        private float k;
        private List<Receiver> receivers = new List<Receiver>();
        private Graphics canvas;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.canvas = pictureBox.CreateGraphics();
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            var me = (MouseEventArgs) e;
            if (me.Button == MouseButtons.Left)
            {
                receiverXInput.Text = me.X.ToString();
                receiverYInput.Text = me.Y.ToString();
            }
            else if (me.Button == MouseButtons.Right)
            {
                if (ReadK())
                    SendSignal(me.X, me.Y);
            }
        }

        private bool ReadK()
        {
            bool parsed = float.TryParse(kInput.Text, out float k);
            if (!parsed)
            {
                MessageBox.Show("Enter valid coefficient k!");
                return false;
            }
            this.k = k;
            return true;
        }

        private void SendSignal(float fromX, float fromY)
        {
            Vector2 p1 = new Vector2(fromX, fromY);
            foreach (var receiver in receivers)
            {
                Vector2 p2 = new Vector2(receiver.X, receiver.Y);
                receiver.ReceivedI = k / Vector2.DistanceSquared(p1, p2);
            }
            FullRender();
        }

        private void addReceiverBtn_Click(object sender, EventArgs e)
        {
            bool parsedX = int.TryParse(receiverXInput.Text, out int x);
            bool parsedY = int.TryParse(receiverYInput.Text, out int y);
            if (!parsedX || !parsedY 
                || x < 0 || y < 0  
                || x > canvas.VisibleClipBounds.Width 
                || y > canvas.VisibleClipBounds.Height)
            {
                MessageBox.Show("Enter valid coordinates!");
                return;
            }
            if (receivers.Any(r => r.X == x && r.Y == y))
            {
                MessageBox.Show("Such receiver already exists!");
                return;
            }
            this.receivers.Add(new Receiver { X = x, Y = y });
            this.receiverList.Items.Add($"Receiver #{receivers.Count}:   ({x}, {y})");
            RenderReceivers();
        }

        private void RenderReceivers()
        {
            canvas.Clear(Color.White);
            Brush brush = new SolidBrush(Color.Black);
            Pen pen = new Pen(brush);
            foreach (var receiver in receivers)
            {
                canvas.FillEllipse(brush, receiver.X - 3, receiver.Y - 3, 8, 8);
            }

        }

        private void FullRender()
        {
            RenderReceivers();
            RenderSender();
        }

        private bool PointSatisfies(float x, float y)
        {
            foreach (var receiver in receivers)
            {
                if (!receiver.SutisfiesCircle(this.k, x, y)) 
                    return false;
            }
            return true;
        }

        private void RenderSender()
        {
            if (!this.receivers.Any())
            {
                MessageBox.Show("Add some receivers first!");
                return;
            }
            senderLabel.Visible = false;
            Vector2? firstOccurence = null;
            Brush brush = new SolidBrush(Color.Red);
            for (int i = 0; i < canvas.VisibleClipBounds.Width; i++)
            {
                for (int j = 0; j < canvas.VisibleClipBounds.Height; j++)
                {
                    if (PointSatisfies(i, j))
                    {
                        if (firstOccurence == null)
                        {
                            firstOccurence = new Vector2(i, j);
                        }
                        canvas.FillEllipse(brush, i - 1, j - 1, 3, 3);
                    }
                }
            }
            if (receivers.Count > 1 && firstOccurence != null)
            {
                senderLabel.Text = $"The sender is approximately at ({((Vector2)firstOccurence).X}, {((Vector2)firstOccurence).Y})";
                senderLabel.Visible = true;
            }
        }
    }
}
