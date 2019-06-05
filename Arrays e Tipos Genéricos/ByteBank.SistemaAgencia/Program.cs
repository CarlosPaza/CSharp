using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] idades = new int[5];

            //idades[0] = 15;
            //idades[1] = 28;
            //idades[2] = 35;
            //idades[3] = 50;
            //idades[4] = 28;

            //int[] idades = new int[] { 15, 28, 35, 50, 28 };

            //Console.WriteLine(idades[1]);
            //Console.WriteLine(idades[2]);

            //int acumulador = 0;
            //for (int indice = 0; indice < idades.Length; indice++)
            //{
            //    acumulador += idades[indice];
            //}
            //int media = acumulador / idades.Length;
            //Console.WriteLine(media);

            //ListaDeContaCorrente lista = new ListaDeContaCorrente();

            //ContaCorrente carlos = new ContaCorrente(111, 2365);

            //lista.Adicionar(new ContaCorrente(345, 23462));
            //lista.Adicionar(carlos);
            //lista.Adicionar(new ContaCorrente(363, 22451));
            //lista.Adicionar(new ContaCorrente(735, 23552));
            //lista.Adicionar(new ContaCorrente(345, 23462));
            //lista.Adicionar(new ContaCorrente(363, 22451));
            //lista.Adicionar(new ContaCorrente(735, 23552));
            //lista.Adicionar(new ContaCorrente(345, 23462));
            //lista.Adicionar(new ContaCorrente(363, 22451));
            //lista.Adicionar(new ContaCorrente(735, 23552));
            //lista.Adicionar(new ContaCorrente(345, 23462));
            //lista.Adicionar(new ContaCorrente(363, 22451));
            //lista.Adicionar(new ContaCorrente(735, 23552));

            //lista.EscreverListaNaTela();

            //Console.WriteLine();

            //lista.Remover(carlos);

            //lista.EscreverListaNaTela();

            //ListaDeContaCorrente lista = new ListaDeContaCorrente();

            //lista.AdicionarVarios(
            //    new ContaCorrente(100, 40010),
            //    new ContaCorrente(101, 40011),
            //    new ContaCorrente(102, 40012),
            //    new ContaCorrente(103, 40013)
            //);

            //for (int i = 0; i < lista.Tamanho; i++)
            //{
            //    ContaCorrente conta = lista[i];
            //    Console.WriteLine($"{conta.Agencia}/{conta.Numero}");
            //}

            Lista<int> idades = new Lista<int>();

            idades.AdicionarVarios(63, 15, 21, 50);
            idades.Remover(15);
            idades.EscreverListaNaTela();

            Lista<string> cursos = new Lista<string>();
            cursos.AdicionarVarios("C# Parte 1", "C# Parte 2", "C# Parte 3");
            cursos.EscreverListaNaTela();

            Lista<ContaCorrente> contas = new Lista<ContaCorrente>();
            contas.AdicionarVarios(new ContaCorrente(124, 54354), new ContaCorrente(201, 44354));
            contas.EscreverListaNaTela();

            Console.ReadLine();
        }
    }
}
