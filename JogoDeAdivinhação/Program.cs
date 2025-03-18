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
                Metodos.ExibirMenu();

                int totalTentativas = Metodos.DefinirDificuldade();
                int numeroSecreto = Metodos.GerarNumeroSecreto();

                Metodos.Jogar(totalTentativas, numeroSecreto);
                Console.WriteLine("Deseja continuar? (S/N) ");
                string opcaoContinuar = Console.ReadLine().ToUpper();

                if (opcaoContinuar != "S")
                    break;


            }
        }
    }
}
