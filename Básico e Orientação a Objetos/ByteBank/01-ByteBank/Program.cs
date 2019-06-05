using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente primeiraContaCorrente = new ContaCorrente(867, 86712540);
            primeiraContaCorrente.Saldo = 200;
            Console.WriteLine(primeiraContaCorrente.Saldo);

            primeiraContaCorrente.Saldo += 100;
            Console.WriteLine(primeiraContaCorrente.Saldo);

            ContaCorrente segundaContaCorrente = new ContaCorrente(8673, 8671254);
            segundaContaCorrente.Saldo = 50;

            Console.WriteLine("primeira conta tem " + primeiraContaCorrente.Saldo);
            Console.WriteLine("segunda conta tem " + segundaContaCorrente.Saldo);

            primeiraContaCorrente.Transferir(50, segundaContaCorrente);

            Console.WriteLine("primeira conta tem " + primeiraContaCorrente.Saldo);
            Console.WriteLine("segunda conta tem " + segundaContaCorrente.Saldo);

            ContaCorrente contaDaCamila = new ContaCorrente(8644, 867125);
            contaDaCamila.Titular = new Cliente();
            contaDaCamila.Titular.Nome = "Camila";

            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

            Console.ReadLine();
        }
    }
}
