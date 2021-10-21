using System.Collections.Generic;
using System.Linq;
using CaixaEletronico.Interfaces;

namespace CaixaEletronico.Entities
{
    internal class ListaDeSaques : IRepository<Saque>
    {
        private readonly List<Saque> _saques;

        public ListaDeSaques()
        {
            _saques = new List<Saque>();
        }

        public void Add(Saque saque)
        {
            _saques.Add(saque);
        }

        public List<Saque> List()
        {
            return _saques.ToList();
        }

        public void Print()
        {
            foreach (var saque in _saques)
            {
                System.Console.WriteLine(saque);
            }
        }
    }
}