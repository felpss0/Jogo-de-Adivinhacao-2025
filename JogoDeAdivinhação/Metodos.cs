namespace JogoDeAdivinhação
{
    class Metodos
    {
        public static void ExibirMenu() 
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
        }

        public static int DefinirDificuldade() 
        {
            int totalTentativas = 0;
            Console.Write("Digite sua escolha de dificuldade: ");
            string opcaoDificuldade = Console.ReadLine();

            if (opcaoDificuldade == "1")
                totalTentativas = 10;
            else if (opcaoDificuldade == "2")
                totalTentativas = 5;
            else
                totalTentativas = 3;

            return totalTentativas;
        }

        public static int GerarNumeroSecreto() 
        {
            Random geradorNumero = new Random();

            return geradorNumero.Next(1, 21);
        }

        public static void Jogar(int totalTentativas, int numeroSecreto) 
        {
            for (int tentativa = 1; tentativa <= totalTentativas; tentativa++)
            {
                Console.Clear();
                Console.WriteLine("--------------------");
                Console.WriteLine($"Tentativa {tentativa} de {totalTentativas}");
                Console.WriteLine("--------------------");

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
        }

        public static int ObterNumeroDoUsuario() 
        {
            int numeroDigitado;

            while (true) 
            {
                Console.Write("Digite um número entre 1 e 20: ");
                if (int.TryParse(Console.ReadLine(), out numeroDigitado) && numeroDigitado >= 1 && numeroDigitado <= 20)
                    return numeroDigitado;
                
                else
                    Console.WriteLine("Número inválido! Por favor, digite um número entre 1 e 20.");
                
            }
        }
    }
}
