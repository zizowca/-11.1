using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Equation sol = new Equation();
            Console.Write("Введите значение коэффиента b:\t");
            sol.b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите значение коэффиента k:\t");
            sol.k = Convert.ToDouble(Console.ReadLine());
            sol.Root();
            Console.ReadKey();
        }
        public struct Equation //kx+b=0; kx=-b, x=-b/k
        {
            public double b;
            public double k;
            public void Root()
            {
                if (k != 0)
                {

                    double x = (-b / k);
                    Console.WriteLine("X = {0}", x);
                }
                else
                {
                    Console.WriteLine("Нет решения");
                }
            }

        }
    }
}
    

