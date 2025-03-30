using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

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


        public int NumeroConta
        {

            get { return _numroConta; }
            set { _numroConta = value; }

        }

        public string Titular
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

        public static List<ContaBancaria> contasBancarias = new List<ContaBancaria>();

        public void Exibirpreencher(int op)
        {


            Console.WriteLine("Informe o número da sua conta: ");
            int numeroConta = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o titular: ");
            string titular = Console.ReadLine();

            Console.WriteLine("Informe seu saldo: ");
            Saldo = Convert.ToDouble(Console.ReadLine());

            if (op == 1)
            {
                ContaCorrente contaNova = new(numeroConta, titular, Saldo);
                contasBancarias.Add(contaNova);
            }
            if (op == 2)
            {
                ContaPoupanca contaNova = new(numeroConta, titular, Saldo);
                contasBancarias.Add(contaNova);


            }
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
            Console.WriteLine($"R$:{Saldo}");

        }


        public void ExibirConta()
        {
            
            foreach (var l in contasBancarias) 
            {
                string tipoConta = l is ContaCorrente ? "Conta Corrente" : l is ContaPoupanca ? "Conta Poupança" : "ERRR";

                Console.WriteLine($"Tipo: {tipoConta}");
                Console.WriteLine($"Numero da conta: {l.NumeroConta}");
                Console.WriteLine($"Titular: {l.Titular}");
                Console.WriteLine($"Saldo atual: {l.Saldo}");
                Console.WriteLine();

            }


        }

    

    }
}
