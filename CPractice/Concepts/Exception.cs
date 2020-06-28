using System;
using System.Collections.Generic;
using System.Text;
using CPractice.Concepts;

using System;
using System.IO;
namespace CPractice
{
    public class Exceptions
    {

        // Main Method 
        public static void t()
        {
            Console.Write("Please enter a number to divide 100: ");

            try
            {
                int num = int.Parse(Console.ReadLine());

                int result = 100 / num;

                Console.WriteLine("100 / {0} = {1}", num, result);
            }
            catch (DivideByZeroException ex)
            {
                Console.Write("Cannot divide by zero. Please try again.");
            }
            catch (InvalidOperationException ex)
            {
                Console.Write("Invalid operation. Please try again.");
            }
            catch (FormatException ex)
            {
                Console.Write("Not a valid format. Please try again.");
            }
            catch (Exception ex)
            {
                Console.Write("Error occurred! Please try again.");
            }
        }

        public static void file()
        {
            FileInfo file = null;

            try
            {
                Console.Write("Enter a file name to write: ");
                string fileName = Console.ReadLine();
                file = new FileInfo(fileName);
                Console.WriteLine(file);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error occurred: {0}", ex.Message);
            }
            finally
            {
                // clean up file object here;
                file = null;
            }
        }

        public static void nested()
        {
            var divider = 0;

            try
            {
                try
                {
                    var result = 100 / divider;
                }
                catch (NullReferenceException ex)
                {
                    Console.WriteLine("Inner casadtch");
                }
            }
            catch
            {
                Console.WriteLine("Outer catch");
            }
        }

        public static void student ()
        {
            Student std = new Student() { StudentName = "chris" };

            try
            {
                PrintStudentName(std);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey(true);
        }

        private static void PrintStudentName(Student std)
        {
            if (std == null)
                throw new NullReferenceException("Student object is null.");

            Console.WriteLine(std.StudentName);
        }

        public static void sequence()
        {
            try
            {
                Method1();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
        }

        static void Method1()
        {
            try
            {
                Method2();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        static void Method2()
        {
            string str = "c";
            try
            {
                Console.WriteLine(str[1]);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static void enter ()
        {
            int c = 0;
            Console.WriteLine("The series is:");
            for (int i = 1; i < 10; i++)
            {
                c = c + i;
                Console.Write(c + " ");
            }

            Console.Write("\nPress 'Enter' to exit the process...");

            // another use of "Console.ReadKey()" method 
            // here it asks to press the enter key to exit 
            while (Console.ReadKey().Key != ConsoleKey.Enter)
            {
            }

        }
    }
}