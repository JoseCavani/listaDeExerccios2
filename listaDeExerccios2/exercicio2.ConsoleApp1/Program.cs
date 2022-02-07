using System;

namespace exercicio2.ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool sucesso;
            float[] numeros = new float[3];
            Console.WriteLine("digite o primeiro valor");
        volta1:
            sucesso = float.TryParse(Console.ReadLine(), out numeros[0]);
            if (sucesso == false)
            {
                Console.Clear();
                Console.WriteLine("valor invalido tente novamente");
                goto volta1;
            }
            Console.WriteLine("digite o segundo valor");
        volta2:
            sucesso = float.TryParse(Console.ReadLine(), out numeros[1]);
            if (sucesso == false)
            {
                Console.Clear();
                Console.WriteLine("valor invalido tente novamente");
                goto volta2;
            }
            Console.WriteLine("digite o terceiro valor");
        volta3:
            sucesso = float.TryParse(Console.ReadLine(), out numeros[2]);
            if (sucesso == false)
            {
                Console.Clear();
                Console.WriteLine("valor invalido tente novamente");
                goto volta3;
            }

            Array.Sort(numeros);
            Array.Reverse(numeros);
            foreach (int value in numeros)
            {
                Console.Write(value + "/");
            }
            Console.ReadKey();
        }
    }
}
