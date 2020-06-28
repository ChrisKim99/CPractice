using System;
using System.Collections.Generic;
using System.Text;

namespace CPractice.Concepts
{
    public partial class PartialClass
    {
        private int speed;
        public void Accelerate(int value)
        {
            speed += value;
            Console.WriteLine("The speed is at {0}", speed);
        }

        public void Brake (int value)
        {
            speed -= value*value;
            Console.WriteLine("The speed is at {0}", speed);
        }
    }
}
