using System;

namespace Exemplo1
{
    class Program
    {
        static void Main(string[] args)
        {
            double num, resp;
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Boa noite ADS1 - Sejam bem vindos\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Exibindo o Quadrado e o Dobro de um Número\n");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Digite um número: ");
            num = Convert.ToDouble(Console.ReadLine());
            resp = num * num;
            //resp = Math.Pow(num, 2);
            Console.WriteLine("\nQuadrado = " + resp);
            resp = num * 2;
            Console.WriteLine("\nDobro = " + resp);
            Console.WriteLine("\n\nÓtimo descanso para todos !!!");
            Console.ReadKey();
        }
    }
}
