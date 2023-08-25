using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1POO7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            QualMaior a;
            a = new QualMaior();

            Console.WriteLine("valor de n1");
            a.setn1(double.Parse(Console.ReadLine()));
            Console.WriteLine("valor de n2");
            a.setn2(double.Parse(Console.ReadLine()));

            a.calcular();
            Console.WriteLine("situação", a.getn1(), a.getn2());
        }
    }
}
