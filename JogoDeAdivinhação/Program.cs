namespace JogoDeAdivinhação
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //loop principal do jogo

            while (true) 
            {
                Console.Clear();
                Console.WriteLine("--------------------");
                Console.WriteLine("Jogo de Adivinhação");
                Console.WriteLine("--------------------");

                Console.WriteLine("Escolha um nivel de dificuldade: ");
                Console.WriteLine("------------------------------------");
                Console.WriteLine("1 - Fácil (10 tentativas)");
                Console.WriteLine("2 - Normal (5 tentativas)");
                Console.WriteLine("3 - Dificil (3 tentativas)");

                int totalTentativas = 0;
                Console.Write("Digite sua escolha de dificuldade: ");
                string opcaoDificuldade = Console.ReadLine();

                if (opcaoDificuldade == "1")
                    totalTentativas = 10;
                else if (opcaoDificuldade == "2")
                    totalTentativas = 5;
                else
                    totalTentativas = 3;


                    //gerar um numero secreto aleatorio
                    Random geradorNumero = new Random();

                int numeroSecreto = geradorNumero.Next(1,21);

                

                //logica das tentativas
                for (int tentativa = 1; tentativa <= totalTentativas; tentativa++) 
                {
                    Console.Clear();
                    Console.WriteLine("--------------------");
                    Console.WriteLine($"Tentativa {tentativa} de {totalTentativas}");
                    Console.WriteLine("--------------------");

                    
                    
                    
                    //logica do jogo

                    Console.Write("Digite um numero entre 1 e 20: ");
                    int numeroDigitado = Convert.ToInt32(Console.ReadLine());



                    if (numeroDigitado == numeroSecreto)
                    {
                        Console.WriteLine("--------------------");
                        Console.WriteLine("Voce acertou o numero secreto");
                        Console.WriteLine("--------------------");
                        break;
                    }

                    if (tentativa == totalTentativas)
                    {
                        Console.WriteLine("--------------------");
                        Console.WriteLine("Voce nao conseguiu acertar. O numero secreto era " + numeroSecreto);
                        Console.WriteLine("--------------------");

                        break;
                    }


                    else if (numeroDigitado > numeroSecreto)
                    {
                        Console.WriteLine("--------------------");
                        Console.WriteLine("o numero informado é maior que o numero secreto");
                        Console.WriteLine("--------------------");
                    }
                    else
                    {
                        Console.WriteLine("--------------------");
                        Console.WriteLine("o numero informado é menor que o numero secreto");
                        Console.WriteLine("--------------------");
                    }

                    Console.ReadLine();
                   

                }

                Console.WriteLine("Deseja continuar? (S/N) ");
                string opcaoContinuar = Console.ReadLine().ToUpper();

                if (opcaoContinuar != "S")
                    break;


            }
        }
    }
}
