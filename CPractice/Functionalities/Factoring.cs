using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace CPractice
{
   public class Factoring
    {
        public static void Factor(int value)
        {
            static List<int> help(int v, int d)
            {
                if(d > Math.Pow(v, 0.5) && d != 0 && d != 1){
                    return new List<int>{v};
                }else if(v <= 0 || v == 1) {
                    return new List<int>{};
                }else{
                    switch (v % d)
                    {
                        case 0:
                            List<int> list = new List<int>() { d };
                            foreach (var a in help(v / d, d))
                            {
                                list.Add(a);
                            };              
                        return list;
                         
                    default:
                        return help(v, d + 1);
                }   
                }
            }
            var ans = help(value, 2);
            foreach(var i in ans){
                Console.WriteLine(i);            
            }
            Console.WriteLine("Factoring Done");
        }

    }
}