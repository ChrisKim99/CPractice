using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;

namespace CPractice.Concepts
{
    public class GenericCollection
    {
        public IList<Student> students = new List<Student> { };
        public void add_student(double score, int grade)
        {
            students.Add(new Student() { score = score, grade = grade });
        }
            
            

        }
    }
