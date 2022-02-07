using System;

namespace exercicio3.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool sucesso;
            double[] numeros = new double[3];
            Console.WriteLine("digite o peso");
        volta1:
            sucesso = double.TryParse(Console.ReadLine(), out numeros[0]);
            if (sucesso == false)
            {
                Console.Clear();
                Console.WriteLine("valor invalido tente novamente");
                goto volta1;
            }
            Console.WriteLine("digite a altura");
        volta2:
            sucesso = double.TryParse(Console.ReadLine(), out numeros[1]);
            if (sucesso == false)
            {
                Console.Clear();
                Console.WriteLine("valor invalido tente novamente");
                goto volta2;
            }
            numeros[2] = numeros[0] / Math.Pow(numeros [1],2);

            if (numeros[2] < 18.5)
                Console.WriteLine($"IMC = {numeros[2]} Abaixo do peso");
            else if (numeros[2] > 18.5 && 25 > numeros[2])
              Console.WriteLine($"IMC = {numeros[2]} Peso normal");
            else if (numeros[2] > 25 && 30 > numeros[2])
                Console.WriteLine($"IMC = {numeros[2]} Acima do peso");
            else
                Console.WriteLine($"IMC = {numeros[2]}  obeso");
            Console.ReadKey();
        }
    }
}
