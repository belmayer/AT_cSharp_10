using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        int aleatorio = random.Next(1, 51);
        int tentativas = 5;

        Console.WriteLine("Tente adivinhar um número entre 1 e 50  Você tem 5 tentativas");

        for (int i = 1; i <= tentativas; i++)
        {
            Console.Write($"Tentativa {i}: ");
            string entrada = Console.ReadLine();

            if (!int.TryParse(entrada, out int chute))
            {
                Console.WriteLine("Entrada inválida! Digite um número válido");
                i--;
            }
            else if (chute < 1 || chute > 50)
            {
                Console.WriteLine("Fora do intervalo! Digite um número entre 1 e 50");
                i--;
            }
            else
            {
                if (chute == aleatorio)
                {
                    Console.WriteLine($"Parabéns! Vc acertou o número {aleatorio} na tentativa {i}!");
                    return;
                }
                else if (chute < aleatorio)
                {
                    Console.WriteLine("O numero é maior! Tente novamente");
                }
                else
                {
                    Console.WriteLine("O numero é menor! Tente novamente");
                }
            }
        }

        Console.WriteLine($"Gameover! O numero era {aleatorio}");
    }
}
