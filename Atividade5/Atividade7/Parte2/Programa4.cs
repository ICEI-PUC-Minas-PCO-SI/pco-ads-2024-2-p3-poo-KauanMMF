using System;

namespace Atividade7.Parte2
{
    public class ExcecaoAcimaDeCem : ApplicationException
    {
        public ExcecaoAcimaDeCem(string mensagem) : base(mensagem) { }
    }

    internal class Programa4
    {
        public static void rodar()
        {
            int soma = 0;
            int contador = 0;

            Console.WriteLine("Digite números para somar. Deve ser menor ou igual a 100.");

            try
            {
                while (true)
                {
                    try
                    {
                        Console.Write("Digite um número inteiro: ");
                        int numero =int.Parse(Console.ReadLine());

                        if (soma + numero > 100)
                        {
                            throw new ExcecaoAcimaDeCem("A soma ultrapassou 100!");
                        }

                        soma += numero;
                        contador++;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Entrada inválida. Por favor, digite um número inteiro válido.");
                    }
                    catch (OverflowException)
                    {
                        Console.WriteLine("O número digitado é muito grande. Tente novamente.");
                    }
                }
            }
            catch (ExcecaoAcimaDeCem ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine($"Soma total antes de ultrapassar 100: {soma}");
                Console.WriteLine($"Quantidade de números somados: {contador}");
                Console.WriteLine($"Média dos números somados: {soma / contador}");
            }
        }
    }
}
