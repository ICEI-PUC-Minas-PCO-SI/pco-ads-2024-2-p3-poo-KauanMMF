internal class Programa3
{
    public static void rodar()
    {
        int[] vetor = new int[10];

        while (true)
        {
            try
            {
                Console.WriteLine("\nPreencha o vetor de 10 posições (0 a 9):");
                Console.Write("Digite a posição que quer adicionar um número: ");
                int pos = int.Parse(Console.ReadLine());

                if (vetor[pos] != 0)
                {
                    Console.WriteLine($"Erro: A posição {pos} já está preenchida com o valor {vetor[pos]}. Escolha outra posição.");
                }
                else
                {
                    Console.Write("Digite um valor para adicionar: ");
                    int valor = int.Parse(Console.ReadLine());

                    vetor[pos] = valor;
                    Console.WriteLine($"Valor {valor} inserido na posição {pos} com sucesso!");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Erro: Por favor, digite um número válido.");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Erro: Foi informada uma posição inexistente do vetor.");
            }
            finally
            {
                Console.WriteLine("\n|--- Vetor Atual ---|");
                for (int i = 0; i < vetor.Length; i++)
                {
                    Console.WriteLine($"Posição {i}: {vetor[i]}");
                }
            }
        }
    }
}
