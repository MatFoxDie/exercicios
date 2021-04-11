using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CadastroBanco
{
    class Conta
    {
        public int Numero { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        public Conta()
        {

        }
        public Conta(int numero, string titular, double saldo)
        {
            Numero = numero;
            Titular = titular;
            Saldo = saldo;
        }

        public Conta(int numero, string titular)
        {
            Numero = numero;
            Titular = titular;
        }

        

        public override string ToString()
        {
            return "Conta "
                + Numero
                + ", Titular: "
                + Titular
                + ", Saldo: "
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }

        public void Deposito(double SaldoDeposito)
        {
            Saldo += SaldoDeposito;
        }

        public void Saque(double SaldoSaque)
        {
            Saldo -= SaldoSaque+5;
        }

    }
}
