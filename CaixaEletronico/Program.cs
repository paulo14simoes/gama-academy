using System;
using System.Collections.Generic;
using System.Linq;
using CaixaEletronico.Entities;

namespace CaixaEletronico
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            ListaDeSaques listaDeSaques = new ListaDeSaques();
            Caixa caixa = new Caixa(listaDeSaques);

            try
            {
                PrintMoedas(caixa.Sacar(1235));
                PrintMoedas(caixa.Sacar(2000));
                PrintMoedas(caixa.Sacar(2050));
                PrintMoedas(caixa.Sacar(1430));
                Console.WriteLine("=============================");
                listaDeSaques.Print();
            }
            catch (InvalidOperationException)
            {
                Console.WriteLine("valor inválido");
            }

            Console.ReadKey();
        }

        private static void PrintMoedas(List<Moeda> moedas)
        {
            var moedasString = moedas.Select(moeda => moeda.Valor.ToString());
            Console.WriteLine(String.Join(", ", moedasString));
        }
    }
}