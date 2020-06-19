using System;
using System.Collections.Generic;
using System.Text;

namespace CPractice.Concepts
{
    public partial class PartialClass
    {
        private int height;
        public void Aviate (int value)
        {
            height += value;
            Console.WriteLine("The plane at {0}", height);
        }

        public void Land (int value)
        {
            height -= value;
            Console.WriteLine("The plane at {0}", height);
        }
    }
   
}
