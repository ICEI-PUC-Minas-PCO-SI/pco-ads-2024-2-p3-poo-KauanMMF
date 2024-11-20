using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade7.Parte1
{
    internal class Programa1
    {
        public static void rodar()
        {
            while (true)
            {
                try
                {
                    Console.Write("Digite um número inteiro: ");
                    int n = int.Parse(Console.ReadLine());

                    if (verificarNumeroPrimo(n))
                    {
                        Console.WriteLine($"O número {n} é primo.");
                    }
                    else
                    {
                        Console.WriteLine($"O número {n} não é primo.");
                    }
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ocorreu um erro, por favor, insira um número!");
                }
            }
        }
        static bool verificarNumeroPrimo(int numero) //Peguei da internet
        {
            bool ePrimo = true;
            for (int divisor = 2; divisor <= Math.Sqrt(numero); divisor++)
            {
                if (numero % divisor == 0)
                {
                    ePrimo = false;
                    break;
                }
            }
            return ePrimo;
        }
    }
}
