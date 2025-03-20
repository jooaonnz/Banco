using System.Xml;

namespace Banco
{
    public class Program
    {

        public static void Main(string[] args)
        {
            Inicio();
            
        }

            public static void Inicio()
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
                        cc.ContaExibir();
                        ExibirMenu(cc);

                        break;

                    case 2:
                        Console.WriteLine("Conta poupança \n");
                        ContaPoupanca cp = new ContaPoupanca(0, "", 0);
                        cp.ContaExibir();
                        ExibirMenu(cp);

                        break;

                    default:
                        Console.WriteLine("Escolha uma opção válida!");
                        break;
                }

            }



            public static void ExibirMenu(ContaBancaria conta)
            {
                int op = -1;


                while (op != 0)
                {

                    Console.WriteLine("1-Exibir saldo");
                    Console.WriteLine("2-Depositar");
                    Console.WriteLine("3-Sacar");
                    Console.WriteLine("4-Criar nova conta");
                    Console.WriteLine();
                    Console.WriteLine("0-Para sair");

                    op = Convert.ToInt32(Console.ReadLine());

                    switch (op)
                    {
                        case 0:
                            Console.WriteLine("Saindo");
                            break;
                        case 1:
                            Console.WriteLine("Exibir saldo");
                            conta.ExibirSaldo();

                            break;
                        case 2:
                            Console.WriteLine("Depositar");
                            Console.WriteLine("Digite a quantia: ");
                            double quantia = Convert.ToDouble(Console.ReadLine());
                            conta.Depositar(quantia);

                            break;
                        case 3:
                            Console.WriteLine("Sacar");
                            Console.WriteLine("Digite a quantia:");
                            double saque = Convert.ToDouble(Console.ReadLine());
                            conta.Sacar(saque);

                            break;
                        case 4:
                            Inicio();
                            break;
                    }
                }
            }


        
    }
}