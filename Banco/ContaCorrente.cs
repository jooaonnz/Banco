using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public class ContaCorrente: ContaBancaria
    {
      

        public ContaCorrente (int numeroConta, string titular, double saldo): base (numeroConta , titular, saldo) 
        {
            


        }
        /*

        public override double Depositar()
        {

        }


        public override double Sacar()
          { 


          }*/
        public  void ContaCorrenteExibir()
        {
            Console.WriteLine("Informe o número da sua conta: ");
            int numConta = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Infomre o titular: ");
            string titularConta = Console.ReadLine();

            Console.WriteLine("Informe seu saldo: ");
            double saldoConta = Convert.ToDouble(Console.ReadLine());
            Console.Clear();

         


            ContaCorrente cp = new ContaCorrente(numConta, titularConta, saldoConta);
        
        }

    }
    
}
