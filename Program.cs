using System;

namespace Sequencia_Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Sequência Fibonacci");
            Console.WriteLine("------------------------------------");

            Console.Write("Quantos termos você quer mostrar?");
            int num = int.Parse(Console.ReadLine());

            int t1 = 0;
            int t2 = 1;

            Console.WriteLine($"{t1}");
            Console.WriteLine($"{t2}");

            int cont = 3;
            while(cont <= num) {
                int t3 = t1 + t2;
                Console.WriteLine($"{t3}");
                t1 = t2;
                t2 = t3;
                cont++;

            }
            Console.WriteLine("FIM");
            
        }
    }
}
