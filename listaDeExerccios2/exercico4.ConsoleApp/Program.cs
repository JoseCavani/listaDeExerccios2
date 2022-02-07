using System;

namespace exercico4.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool sucesso;
            double numeros = 0;
            Console.WriteLine("digite o numero");
        volta1:
            sucesso = double.TryParse(Console.ReadLine(), out numeros);
            if (sucesso == false)
            {
                Console.Clear();
                Console.WriteLine("valor invalido tente novamente");
                goto volta1;
            }
            if (numeros % 2 == 0)
                Console.WriteLine("Par");
            else
             Console.WriteLine("Impar");
            Console.ReadKey();
            
        }
    }
}
