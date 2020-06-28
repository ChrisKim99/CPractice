using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace CPractice.Concepts
{

    [Serializable]
    public class Calulate
    {
        public int value;
        public string name;
        public virtual void add(int a)
        {
            value += a;
        }
        public virtual void subtract(int a)
        {
            value -= a;
        }    

        public virtual void show_value()
        {
            Console.WriteLine(value);
        }
    }
    public class Custom_Exception: Calulate
    {
        public override void add(int a)
        {
            base.add(a);
        }

        public override void subtract(int a)
        {
            base.subtract(a);
        }

        public override void show_value()
        {
            base.show_value();
        }
    }

    class test_serializable
    {
        public void serializable()
        {
            Calulate custom_Exception = new Calulate();
            custom_Exception.name = "Serialzable test";
          
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("C:\\Users\\Lenovo\\Examples.txt", FileMode.Create, FileAccess.Write);

            formatter.Serialize(stream, custom_Exception);
            stream.Close();

            stream = new FileStream("C:\\Users\\Lenovo\\Examples.txt", FileMode.Open, FileAccess.Read);
            Calulate new_custom_Exception = (Calulate)formatter.Deserialize(stream);

            Console.WriteLine(new_custom_Exception.name);
        }
        
        
    }
}
