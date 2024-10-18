using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circel shape = new Circel(5);

            Circel shape2 = new Circel(6);
            Triangel shape3 = new Triangel(4, 5, 3);
            Console.WriteLine(shape.Get_Area());
            Console.WriteLine(shape2.Get_Area());
            Console.WriteLine(shape.Omkrets());
            Console.WriteLine(shape2.Omkrets());
            Console.WriteLine(shape.Volym());
            Console.WriteLine(shape3.Area());

        }
    }
}
