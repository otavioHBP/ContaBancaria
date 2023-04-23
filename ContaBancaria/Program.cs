using System;
using System.ComponentModel.Design;
using System.Globalization;

namespace ContaBancaria 
{
    internal class Program {
        static void Main(string[] args) {

            ContaBancaria conta;

            Console.Write("Entre com o número da conta bancária: ");
            int Conta = int.Parse(Console.ReadLine());
            
            Console.Write("Entre com o nome do títular da conta: ");
            string nome = Console.ReadLine();

            Console.Write("Haverá depósito inicial (s/n) ? ");
            char resp = char.Parse(Console.ReadLine());

            if ($"{resp}" == "s" || $"{resp}" == "S"){
                Console.Write("Entre com o valor do depósito inicial: ");
                double Dp01 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                conta = new ContaBancaria(Conta, nome, Dp01);                       

            }
            else{
                conta = new ContaBancaria(Conta, nome);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(conta);


            
            Console.WriteLine();
            Console.Write("Entre com o valor para depósito: ");
            double quantia= double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            conta.Deposito(quantia);
            Console.WriteLine("Dados da conta atualizado:");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Entre com o valor para saque (Inclusa taxa de R$ 5.00) : ");
            quantia = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            conta.Saque(quantia);
            Console.WriteLine("Dados da conta atualizado:");
            Console.WriteLine(conta);


        }
    }
}
