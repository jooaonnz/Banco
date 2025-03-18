using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public class ContaBancaria
    {
        private int _numroConta;
        private string _titular;
        private double _saldo;



        public ContaBancaria(int numeroConta, string titular, double saldo)
        {
            this._numroConta = numeroConta;
            this._titular = titular;
            this._saldo = saldo;
            
        }
        
       

        public double ExibirSaldo(double saldo)
        {
            

        }
        
    }
}
