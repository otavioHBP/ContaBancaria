using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ContaBancaria {
    internal class ContaBancaria {

        public int NumeroConta { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        public ContaBancaria(int numeroConta, string titular) {
            NumeroConta = numeroConta;
            Titular = titular;
            Saldo = 0.0;
        }

        public ContaBancaria(int numeroConta, string titular, double depositoInicial): this(numeroConta,titular) {
            Deposito(depositoInicial);
        }

        public void Deposito(Double quantia) {
            Saldo += quantia;
        }

        public void Saque(Double quantia) {
            Saldo -= quantia;
            Saldo -= 5.0;
        }

        public override string ToString() {
            return "Conta "
                + NumeroConta
                + " Titular "
                + Titular
                + " Saldo da conta: R$"
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
