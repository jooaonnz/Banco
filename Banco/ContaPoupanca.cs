using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public class ContaPoupanca : ContaBancaria
    {
      

            public ContaPoupanca(int numeroConta, string titular, double saldo) : base(numeroConta, titular, saldo)
            {


            }
       /*  public double Depositar(double SaldoConta)
          {

            

          }*/

        public void ContaPoupancaExibir()
        {
            Console.WriteLine("Informe o número da sua conta: ");
            int numConta = Convert.ToInt32(Console.ReadLine());
           
            Console.WriteLine("Infomre o titular: ");
            string titularConta = Console.ReadLine();

            Console.WriteLine("Informe seu saldo: ");
            double saldoConta = Convert.ToDouble(Console.ReadLine());
            Console.Clear();

            double sal = ExibirSaldo(saldoConta);

            ContaCorrente cc = new ContaCorrente(numConta,titularConta,saldoConta);

           
        }

    }
}
