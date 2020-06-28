using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace CPractice
{
    class Collections
    {
        public static bool queue(string qvalue)
        {
            Queue queue = new Queue();
            queue.Enqueue("Chris");
            queue.Enqueue("Alex");
            queue.Enqueue("Rohit");
            
            if(queue.Contains(qvalue) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static public bool stack(string svalue) {
            Stack stack = new Stack();
            stack.Push("Cindy");
            stack.Push("Christine");
            stack.Push("Mami");

            if(stack.Contains(svalue) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static public void list()
        {
            List<string> list = new List<string> { };
            list.Add("a");
            list.Add("b");
            list.Add("c");

            
            Console.WriteLine(list.IndexOf("b"));
            list.RemoveRange(0, 2);
            foreach (string v in list)
            {
                Console.WriteLine(v);
            }
        }

        static public void hash()
        {
            
            Hashtable hash = new Hashtable();
            hash.Add("one", 1);
            hash.Add("two", 2);
            hash.Add(3, "three");
            hash.Add("four", "four");
            hash.Add("list", new List<int> { 1, 2, 3 });
            hash.Add("dict", new Hashtable());

            foreach (var v in hash.Keys)
            {
                if (v == "list")
                {
                    List<int> list = (List<int>)hash[v];
                    foreach (int a in list)
                    {
                        Console.WriteLine(a);
                    }
                }
                if (v == "dict")
                {
                    Hashtable dict = (Hashtable)hash[v];
                    
                    dict.Add("name1", "Chris");
                    dict.Add("name2", "Alex");
                    foreach (var b in dict.Keys)
                    {
                        if (b == "name1")
                        {
                            string value = (string)dict[b];
                            Console.WriteLine(value);
                        }
                    }
                }
            }
        }

        public static void sortlist()
        {
            
            SortedList sortedlist = new SortedList();
            sortedlist.Add(new List<int> { 1, 2}, null);
            sortedlist.Add(new List<int> { 1, 2, 3}, null);
            sortedlist.Add(new List<int> { 1 }, null);
            foreach (List<int> list in sortedlist.Keys)
            {
               
                
            }
          
        }

    }
}
