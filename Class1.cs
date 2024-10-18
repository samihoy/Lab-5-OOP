using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5_OOP
{
    internal class Class1
    {
    }
    public class Circel
    {
        public Circel(int radie)
        {
            this.radie = radie;
        }
        public int radie { get; set; }
        public double Get_Area()
        {
            return radie * radie * Math.PI;

        }
        public double Omkrets()
        {
            return 2 * Math.PI * radie;
        }
        public double Volym()
        {
            return (4 * Math.PI * Math.Pow(radie, 3)) / 3;
        }
    }
    public class Triangel
    {
        public Triangel(int hypotenusa, int kateA, int kateB)
        {
            this.hypotenusa = hypotenusa;
            this.katetA = kateA;
            this.katetB = kateB;
        }

        public int hypotenusa { get; set; }
        public double katetA { get; set; }
        public double katetB { get; set; }

        public double Area()
        {
            return (katetA * katetB) / 2;
        }

    }
}
