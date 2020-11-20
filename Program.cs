using System;

namespace Sequencia_Fibonacci
{
    class Program
    {
        static void Main(string[] args)

        //A série de Fibonacci é formada pela seqüência 0,1,1,2,3,5,8,13,21,34,55,...
        //Regis, pesquise como funciona o algoritmo Fibonacci.
        //Faça um programa que gere a série até que o valor seja maior que 500.
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

            // for (int cont = 3; cont < num; cont++)
            // {   
            //     int t3 = t1 + t2;
            //     if(t3 >= 500){
            //         break;
            //     }
            //     Console.WriteLine($"{t3}");
            //     t1 = t2;
            //     t2 = t3;
                
            // }
        
            while(cont <= num) {
                int t3 = t1 + t2;
                if(t3 >= 500){
                    break;
                }
                Console.WriteLine($"{t3}");
                t1 = t2;
                t2 = t3;
                cont++;
                
            }
            
            Console.WriteLine("FIM");
            
        }
    }
}
