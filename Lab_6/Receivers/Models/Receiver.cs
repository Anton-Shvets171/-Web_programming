using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Receivers.Models
{
    internal class Receiver
    {
        public float X { get; set; }
        public float Y { get; set; }
        public float ReceivedI { get; set; }


        public bool SutisfiesCircle(float k, float x, float y)
        {
            float xSquare = (x - X) * (x - X);
            float ySquare = (y - Y) * (y - Y);
            float error = Math.Abs((xSquare + ySquare) - (k / ReceivedI));
            return error <= (ReceivedI < 0.0001 ? 0.01 : 0.03) / ReceivedI;
        }
    }
}
