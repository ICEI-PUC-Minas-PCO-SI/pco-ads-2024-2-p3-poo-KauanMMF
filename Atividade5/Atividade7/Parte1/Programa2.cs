using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade7.Parte1
{
    using System;

    class Programa2
    {
        public static void rodar()
        {
            while (true)
            {
                try
                {
                    int operacao = -1;
                    do
                    {
                        Console.WriteLine("\n|---CALCULADORA---|");
                        Console.WriteLine("Escolha uma operação: ");
                        Console.WriteLine("0 - Sair do programa");
                        Console.WriteLine("1 - Soma (+)");
                        Console.WriteLine("2 - Subtração (-)");
                        Console.WriteLine("3 - Multiplicação (*)");
                        Console.WriteLine("4 - Divisão (/)");
                        Console.WriteLine("5 - Módulo (%)");
                        Console.WriteLine("|-----------------|\n");


                        Console.Write("Digite o número da operação: ");
                        operacao = int.Parse(Console.ReadLine());

                        if (operacao < 0 || operacao > 5)
                        {
                            Console.WriteLine("Operação inválida. Tente novamente!");
                        }
                        if(operacao == 0)
                        {
                            Console.WriteLine("Saindo do programa.");
                            Environment.Exit(0); //não sei como funciona
                        }
                    } while (operacao < 1 || operacao > 5);

                    Console.Write("Digite o primeiro número: ");
                    double num1 = double.Parse(Console.ReadLine());

                    Console.Write("Digite o segundo número: ");
                    double num2 = double.Parse(Console.ReadLine());

                    double resultado = 0;

                    switch (operacao)
                    {
                        case 1:
                            resultado = num1 + num2;
                            Console.WriteLine($"Resultado: {num1} + {num2} = {resultado}");
                            break;
                        case 2:
                            resultado = num1 - num2;
                            Console.WriteLine($"Resultado: {num1} - {num2} = {resultado}");
                            break;
                        case 3:
                            resultado = num1 * num2;
                            Console.WriteLine($"Resultado: {num1} * {num2} = {resultado}");
                            break;
                        case 4:
                            if (num2 == 0)
                            {
                                throw new DivideByZeroException("Não é possível dividir por zero.");
                            }
                            resultado = num1 / num2;
                            Console.WriteLine($"Resultado: {num1} / {num2} = {resultado}");
                            break;
                        case 5:
                            resultado = num1 % num2;
                            Console.WriteLine($"Resultado: {num1} % {num2} = {resultado}");
                            break;
                    }

                    break; // Sai do try
                }
                catch (FormatException)
                {
                    Console.WriteLine("Erro: Por favor, insira valores numéricos válidos.");
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Não é possível calcular o módulo com divisor zero.");
                }

                Console.WriteLine("Tente novamente!\n");
            }
        }
    }

}
