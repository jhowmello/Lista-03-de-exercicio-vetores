using System;

class Program
{

    static void Main()
    {

        int[,] numero = new int[3, 5];



        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                telaInicial(i, j);
                Console.SetCursorPosition(30, 3);
                numero[i, j] = int.Parse(Console.ReadLine());
            }
        }


        Console.Clear();

        for (int i = 0; i < 3; i++)
        {
            int soma = 0;
            for (int j = 0; j < 5; j++)
            {

                soma = soma + numero[i, j];

            }
            Console.WriteLine($"A soma da linha {i + 1} é {soma}");
        }


    }

    private static void telaInicial(int i, int j)
    {
        Console.Clear();
        Console.WriteLine("╔═════════════════════════════════════════════════╗");
        Console.WriteLine("║             Vetor de Números                    ║");
        Console.WriteLine("╠═════════════════════════════════════════════════╣");
        Console.WriteLine($"║ Número da linha  {i + 1} coluna {j + 1}:                    ║");
        Console.WriteLine("╚═════════════════════════════════════════════════╝");
    }

    private static void telaNumero()
    {
        Console.Clear();
        Console.WriteLine("╔═══════════════════════════════════════╗");
        Console.WriteLine("║                  Números              ║");
        Console.WriteLine("╠═══════╦═══════╦═══════╦═══════╦═══════╣");
        Console.WriteLine("║       ║       ║       ║       ║       ║");
        Console.WriteLine("╠═══════╬═══════╬═══════╬═══════╬═══════╣");
        Console.WriteLine("║       ║       ║       ║       ║       ║");
        Console.WriteLine("╠═══════╬═══════╬═══════╬═══════╬═══════╣");
        Console.WriteLine("║       ║       ║       ║       ║       ║");
        Console.WriteLine("╚═══════╩═══════╩═══════╩═══════╩═══════╝");
    }

}