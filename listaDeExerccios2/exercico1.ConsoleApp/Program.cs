using System;
/
namespace exercicio2.ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool sucesso;
            float[] numeros = new float[3];
            Console.WriteLine("digite o valor A");
        volta1:
            sucesso = float.TryParse(Console.ReadLine(), out numeros[0]);
            if (sucesso == false)
            {
                Console.Clear();
                Console.WriteLine("valor invalido tente novamente");
                goto volta1;
            }
            Console.WriteLine("digite o valor B");
        volta2:
            sucesso = float.TryParse(Console.ReadLine(), out numeros[1]);
            if (sucesso == false)
            {
                Console.Clear();
                Console.WriteLine("valor invalido tente novamente");
                goto volta2;
            }
            Console.WriteLine("digite o valor C");
        volta3:
            sucesso = float.TryParse(Console.ReadLine(), out numeros[2]);
            if (sucesso == false)
            {
                Console.Clear();
                Console.WriteLine("valor invalido tente novamente");
                goto volta3;
            }

          if (numeros[0] + numeros[1] > numeros[2])
                Console.WriteLine("A+B> C");
          else
                Console.WriteLine("A+B< C");
            Console.ReadKey();
        }
    }
}
