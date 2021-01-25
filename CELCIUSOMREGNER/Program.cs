using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CELCIUSOMREGNER
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Intast grader i Celcius");
            double Input = double.Parse(Console.ReadLine());

            Console.WriteLine("Reamur " + Input * 0.8);
            Console.WriteLine("Fahrenheit " + (Input * 1.8 + 32));
            Console.ReadKey(); 
        }
    }
}
