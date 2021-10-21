using System;
using System.Collections.Generic;

namespace CaixaEletronico.Entities
{
    internal class Caixa : Entity
    {
        private readonly ListaDeSaques _listaDeSaques;

        public Caixa(ListaDeSaques listaDeSaques)
        {
            _listaDeSaques = listaDeSaques;
        }

        public void RegistraSaque(decimal valor)
        {
            var saque = new Saque(valor);
            _listaDeSaques.Add(saque);
        }

        public List<Moeda> Sacar(decimal valor)
        {
            int[] moedasDisponiveis = { 100, 50, 20, 10, 5 };
            int currentIndex = 0;
            decimal restante = valor;

            var result = new List<Moeda>();

            while (currentIndex < moedasDisponiveis.Length && restante >= 5)
            {
                var valorAtual = moedasDisponiveis[currentIndex];

                if (restante >= valorAtual)
                {
                    restante -= valorAtual;
                    result.Add(new Moeda(valorAtual));
                }
                else
                {
                    currentIndex += 1;
                }
            }

            if (restante != 0)
            {
                throw new InvalidOperationException("valor inválido"); ;
            }

            RegistraSaque(valor);

            return result;
        }
    }
}