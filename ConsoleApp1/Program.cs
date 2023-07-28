using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string name = "senan";
            //string surname = "Orujov";

            //Console.WriteLine($"{name} ve {surname} ");

            //Console.WriteLine(name + " " + surname); 100 den kicik dirse ustune 1 gel 

            //int a = 1;
            //int number = 106;
            //if (number < 100) 
            //{
            //    Console.WriteLine(number + a);

            //}
            //else
            //{

            //Console.WriteLine(number - a);  0 dan kicik hemen ozw boywkdwrse 

            int number = 5;
            if (number < 0)
            {
                Console.WriteLine(number);
            }
            else if (number > 0 && number < 10)
            {
                number++;
                Console.WriteLine(number);
            }
            else if (number > 10)
            {
                number--;
                Console.WriteLine(number);
            }
            else
            {
                Console.WriteLine("SAĞOL");
            }
            Console.ReadLine();

        }
    }

}

