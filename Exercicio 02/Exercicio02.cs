using System;
using System.ComponentModel;

class Program
{

    static void Main()
    {
        const int n = 1;
        const int v = 1;
        string[] produto = new string[n];
        double[] preco = new double[n];
        double[] valor = new double[v];

        InserirVetor(n, produto, preco);
        InserirValor(valor);
        MostrarVetor(produto, preco, valor);

    }

    private static void InserirVetor(int n, string[] produtos, double [] preco)
    {
        
        
        for (int x = 0; x < n; x++)
        {
            telaInicial();
            Console.SetCursorPosition(10, 3);
            produtos[x] = Console.ReadLine();
            
            Console.SetCursorPosition(8, 5);
            preco [x] = double.Parse(Console.ReadLine());
            
        }
    }
    private static void InserirValor(double[] valor)
    {

        for (int x = 0; x < 1; x++)
        {
            solicitaValor();
            Console.SetCursorPosition(8, 3);
            valor[0] = double.Parse(Console.ReadLine());
        }
    }


    private static void MostrarVetor(string[] produtos, double[] preco, double [] valor)
    {
        Console.Clear();
        
        Console.WriteLine("╔════════════════════════════════════════════╗");
        Console.WriteLine("║  Lista de Produtos ate o valor digitado    ║");
        Console.WriteLine("╠════════════════════════════════════════════╣");
        Console.WriteLine("║ Produto                | Preço             ║");
        Console.WriteLine("╠════════════════════════╦═══════════════════╣");

        int produtosExibidos = 0;

        for (int i = 0; i < produtos.Length; i++)
        {
            if (preco[i] <= valor[0])
            {
                Console.WriteLine($"║ {produtos[i],-22} | {preco[i],15:C2}");
                produtosExibidos++;
            }
           
        }
        if (produtosExibidos == 0)
        {
            Console.WriteLine("║      Nenhum produto encontrado nesse valor.║");
        }
        Console.WriteLine("╚════════════════════════════════════════════╝");

    }

    private static void telaInicial()
    {
        Console.Clear();
        Console.WriteLine("╔════════════════════════════════╗");
        Console.WriteLine("║ Escreva um produto e seu preço ║");
        Console.WriteLine("╠════════════════════════════════╣");
        Console.WriteLine("║ Produto:                       ║");
        Console.WriteLine("║                                ║");
        Console.WriteLine("║ Preço:                         ║");
        Console.WriteLine("╚════════════════════════════════╝");

    }
    private static void solicitaValor()
    {
        Console.Clear();
        Console.WriteLine("╔════════════════════════════════╗");
        Console.WriteLine("║        Digite um valor         ║");
        Console.WriteLine("╠════════════════════════════════╣");
        Console.WriteLine("║ valor:                         ║");
        Console.WriteLine("╚════════════════════════════════╝");

    }
}