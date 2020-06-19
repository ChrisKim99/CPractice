using static CPractice.Factoring;
using static CPractice.AverageInRange;
using System.Collections.Generic;
using System;
using static CPractice.Collections;
using System.Collections;
using System.Linq;
using CPractice.Concepts;
using System.Threading.Tasks.Sources;

namespace CPractice
{
    class Test
    {
        private const int Value = 500;
        private static void Main(string[] args)
        {


            //Factor(Value);
            //List<int> list = new List<int>() { 1, 2, 3, 4, 5 };
            //Average(list, 2, 4);
            //Practice test = new Practice();
            //test[0] = 1;
            //test[1] = 100;
            //test[3] = 300;
            //test[2] = 200;
            //test[4] = 400;

            // 
            //for (int i=0; i <= 2; i++)
            //{
            //    //_ = test[i];
            //    //Console.WriteLine(test[i]);
            //}

            //if (queue("Chris"))
            //{
            //    Console.WriteLine("Valid");
            //}

            //sortlist();

            //PartialClass Car = new PartialClass();
            //Car.Accelerate(5);
            //Car.Brake(3);
            //PartialClass Plane = new PartialClass();
            //Plane.Aviate(5);
            //Plane.Land(2);

            GenericCollection generic = new GenericCollection();
            generic.add_student(45.2, 3);
            generic.add_student(64.2, 2);
            
            List<Student> list = new List<Student> { };
            list.AddRange(generic.students);
            
            generic.students.Clear();

            generic.add_student(37.1, 4);
            generic.add_student(72.4, 1);

            generic.students.Insert(2, new Student(){score = 85.2, grade = 5});

            generic.students.RemoveAt(0);

            list.AddRange(generic.students);

            list.ForEach(student => Console.WriteLine("student grade is {0} student score is {1}", student.grade, student.score));

           

            int[] intArr = new int[2];
            intArr[0] = 0;
            intArr[1] = 1;
            
            foreach (int a in intArr)
            {
                Console.WriteLine(a);
            }
        }

    }
}