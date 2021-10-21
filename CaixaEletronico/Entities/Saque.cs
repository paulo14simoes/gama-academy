using System;

namespace CaixaEletronico.Entities
{
    public class Saque : Entity
    {
        public Saque(decimal valor)
        {
            Valor = valor;
            Date = DateTime.Now;
        }

        public DateTime Date { get; set; }
        public decimal Valor { get; set; }

        public override string ToString()
        {
            return $"Data: {Date} - Valor: { Valor }";
        }
    }
}