namespace AdivinheNumero
{
    class Program
    {
        static void Main(string[] args)
        {
            Random numeroAleatorio = new Random();
            int numeroVencedor = numeroAleatorio.Next(1, 100);

            int tentativas = 0;

            Boolean vitoria = false;

            Console.Write("JOGO - TENTE ADIVINHAR O NÚMERO!\n\n");

            while (!vitoria)
            {
                
                try
                {
                    tentativas++;

                    Console.Write("Escolha um número entre 1 e 100: ");
                    String numeroEscolhidoEntrada = Console.ReadLine();
                    int numeroEscolhido = int.Parse(numeroEscolhidoEntrada);

                    while (numeroEscolhido < 1 || numeroEscolhido > 100)
                    {
                        Console.WriteLine("Você escolheu um número inválido. \n");

                        Console.Write("Escolha um número entre 1 e 100: ");
                        numeroEscolhidoEntrada = Console.ReadLine();
                        numeroEscolhido = int.Parse(numeroEscolhidoEntrada);
                    }

                    if (numeroEscolhido > numeroVencedor)
                    {
                        Console.WriteLine("Muito alto! Escolha um número menor...\n");
                    }
                    else if (numeroEscolhido < numeroVencedor)
                    {
                        Console.WriteLine("Muito baixo! Escolha um número maior...\n");
                    }
                    else if (numeroEscolhido == numeroVencedor)
                    {
                        Console.WriteLine("Você acertou!\n");
                        Console.WriteLine("Numero de tentativas: {0}", tentativas);

                        vitoria = true;
                    }
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Você inseriu um texto.\n");
                    tentativas--;
                } 
            }

            Console.WriteLine("Obrigado por jogar!");
            Console.ReadKey(true);
        }
    }
}