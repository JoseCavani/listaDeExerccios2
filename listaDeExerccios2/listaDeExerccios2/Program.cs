using System;

namespace listaDeExerccios2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool sucesso;
            Console.WriteLine("digite o valor de A");
        volta1:
            sucesso = float.TryParse(Console.ReadLine(), out float A);
            if (sucesso == false)
            {
                Console.Clear();
                Console.WriteLine("valor invalido tente novamente");
                goto volta1;
            }
            Console.WriteLine("digite o valor de B");
        volta2:
            sucesso = float.TryParse(Console.ReadLine(), out float B);
            if (sucesso == false)
            {
                Console.Clear();
                Console.WriteLine("valor invalido tente novamente");
                goto volta2;
            }
            Console.WriteLine("digite o valor de C");
        volta3:
            sucesso = float.TryParse(Console.ReadLine(), out float C);
            if (sucesso == false)
            {
                Console.Clear();
                Console.WriteLine("valor invalido tente novamente");
                goto volta3;
            }


            if (A+B < C)
               Console.WriteLine("valor de A+B e menor que C");

        }
    }
}
