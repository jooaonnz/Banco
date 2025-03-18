namespace Banco
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("1-Conta corrente");
            Console.WriteLine("2-Conta pupança");
        
            int op = Convert.ToInt32(Console.ReadLine());

            switch (op) 
            {
                case 0:
                    Console.WriteLine("SAINDO");
                    break;

                case 1:
                    Console.WriteLine("Conta corrente \n");
                    ContaCorrente cc = new ContaCorrente(0, "", 0);
                    cc.ContaCorrenteExibir();
                    ExibirMenu();

                    break;

                case 2:
                    Console.WriteLine("Conta poupança \n");
                    ContaPoupanca cp = new ContaPoupanca(0, "", 0);
                    cp.ContaPoupancaExibir();
                    ExibirMenu();

                    break;

                default:
                    Console.WriteLine("Escolha uma opção válida!");
                    break;  
            }
   
        }

        public static void ExibirMenu()
        {
            ContaCorrente cc = new ContaCorrente(0, "", 0);
            Console.WriteLine("1-Exibir saldo");
            Console.WriteLine("2-Depositar");
            Console.WriteLine("3-Sacar");

            int op = Convert.ToInt32(Console.ReadLine());

            switch (op) 
            {
                case 1:
                    Console.WriteLine("Exibir saldo");
                    ContaBancaria cb = new ContaBancaria(0, "", 0);
                    

                    break;
                case 2:
                    Console.WriteLine("Depositar");
                    break;
                        case 3:
                    Console.WriteLine("Sacar");
                    break;
            }

        }



    }
}