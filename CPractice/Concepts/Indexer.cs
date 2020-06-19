using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace CPractice
{
    class Practice
    {
        private int[] intArr = new int[5]; //define number of index
        public int this[int index]  //indexer
        {
            // get only works when there's a loop running
            get
            {
                if (index < 0 || index >= intArr.Length)
                    throw new IndexOutOfRangeException("Index out of range");
                //Console.WriteLine(index);
                //Console.WriteLine(intArr[index]);
                // if index is not assigned a value, by default it's 0
                // index comes from for loop in main method                
                return intArr[index]; //int
            }
            // set itself can run to assign values
            set 
            {
                if (index < 0 || index >= intArr.Length)
                    throw new IndexOutOfRangeException("Index out of range");
                // value stands for each int assigned in an order
                //Console.WriteLine(value);
                intArr[index] = value; // str
            }
        }
    }
}
