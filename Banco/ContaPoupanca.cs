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
              Bonus = 0.005;

            }
     

        

    }
}
