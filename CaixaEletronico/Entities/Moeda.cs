namespace CaixaEletronico.Entities
{
    public class Moeda : Entity
    {
        public Moeda(decimal valor)
        {
            Valor = valor;
        }

        public decimal Valor { get; set; }
    }
}