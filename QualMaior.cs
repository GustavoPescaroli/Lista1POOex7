using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1POO7
{
    internal class QualMaior
    {
        private double n1;
        private double n2;

        public void setn1(double M)
        {
            n1 = M;
        }

        public void setn2(double M)
        {
            n2 = M;
        }
        public double getn1()
        {
            return n1;
        }
        public double getn2()
        {
            return n2;
        }
        public void calcular()
        {
            if (n1 == n2)
                Console.WriteLine("os dois são iguais {0} e {1}", n1, n2);
            else
                if (n1 > n2)
                Console.WriteLine("valor n1 {0} é maior que n2 {1}", n1, n2);
            else
                if (n1 < n2);
                    Console.WriteLine("valor de n1 {0} é menor que n2 {1}", n1, n2);

        }

        

        
    }
}
