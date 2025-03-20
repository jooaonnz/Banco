using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public class ContaBancaria
    {
        private int _numroConta;
        private string _titular;
        private double _saldoInicial;
        private double _taxaSaque;
        private double _BonusDeposito;

        protected double Bonus
        {
            get { return _BonusDeposito; }
            set { _BonusDeposito = value; }

        }


        public int NumroConta
        {

            get { return _numroConta; }
            set { _numroConta = value; }

        }

        public string Titulr
        {
            get { return _titular; }
            set { _titular = value; }


        }

        public double Saldo
        {
            get { return _saldoInicial; }
            set { _saldoInicial = value; }
        }
        public double TaxaSaque
        {
            get { return _taxaSaque; }
            set { _taxaSaque = value; }
        }


        public ContaBancaria(int numeroConta, string titular, double saldo)
        {
            _numroConta = numeroConta;
            _titular = titular;
            _saldoInicial = saldo;

        }

     

        public double Depositar(double valor)
        {
            Saldo += valor + (valor * Bonus);
            return Saldo;

        }

      
        protected double Taxa(double valor)
        {
            TaxaSaque = valor;
            return TaxaSaque;

        }

        public double Sacar(double valor)
        {

            return Saldo -= (valor + TaxaSaque);      
        }
        


        public void ExibirSaldo()
        {
            Console.WriteLine($"Saldo:{Saldo}");
        
        
        }

        public void ContaExibir()
        {
            
            Console.WriteLine("Informe o número da sua conta: ");
            int numConta = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Infomre o titular: ");
            string titularConta = Console.ReadLine();

            Console.WriteLine("Informe seu saldo: ");           
            Saldo = Convert.ToDouble(Console.ReadLine());

            Console.Clear();

        }


    }
}
