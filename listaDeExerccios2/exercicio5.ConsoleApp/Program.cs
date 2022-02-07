using System;

namespace exercicio5.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A,B,C;
            bool sucesso;
            Console.WriteLine("digite o valor de A");
        volta1:
            sucesso = int.TryParse(Console.ReadLine(), out  A);
            if (sucesso == false)
            {
                Console.Clear();
                Console.WriteLine("valor invalido tente novamente");
                goto volta1;
            }
            Console.WriteLine("digite o valor de B");
        volta2:
            sucesso = int.TryParse(Console.ReadLine(), out  B);
            if (sucesso == false)
            {
                Console.Clear();
                Console.WriteLine("valor invalido tente novamente");
                goto volta2;
            }
            if (A == B)
            {
                C = A + B;
                Console.WriteLine($"{A}+{B} = {C}");
            }
            else
            {
                C = A * B;
                Console.WriteLine($"{A}*{B} = {C}");
            }
            Console.ReadKey();
        }
    }
}
