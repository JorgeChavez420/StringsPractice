using System;
using System.Collections.Generic;

namespace StringsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            string value1 = "";
            string value2 = value1;

            value1 = "hola";
            value2 = value1.ToUpper();
            
            int a = int.Parse("2");
            int b = Convert.ToInt32("2");
            int c = 4;
            string cStr = c.ToString();

            Console.WriteLine($"\"{value1}\" -> \"{value2}\"");

            Console.WriteLine("-----");

            value1 = "[Jhon, Peter, Charlie] ";
            value2 = value1.ToLower();
            Console.WriteLine(value1);
            Console.WriteLine(value2);

            Console.WriteLine("-----");

            value1 = "Pizza ";
            char[] charArray = value1.ToCharArray();
            Array.Reverse( charArray );
            
            value2 = new string( charArray );
            Console.WriteLine(value1); 
            Console.WriteLine(value2);
            Console.WriteLine($"\"{value1}\" -> \"{value2}\"");

            Console.WriteLine("-----");

            
            value1 = "ave, banco, comida, duda, ejercicio, fuente, girasol";
            value2 = value1.ToUpper();
            
            int d = int.Parse("2");
            int e = Convert.ToInt32("2");
            string cStr1 = c.ToString();

            Console.WriteLine($"\"{value1}\" -> \"{value2}\"");

        }
    }
}
