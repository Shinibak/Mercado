using System;
using System.Globalization;

namespace NewMercado
{
    class Carrinho
    {
        public string Nome {get; set;}
        public int Quantidade { get; set; }
        public Double ValorUnit { get; set; }

        public Double ValorT { get; set; }

        public Carrinho(String nome,int quantidade,double valor)
        {
            Nome = nome;
            Quantidade = quantidade;
            ValorUnit = valor;
        }

        public double ValorTotal()
        {
            ValorT = Quantidade * ValorUnit;
            return ValorT;
        }
        public override string ToString()
        {
            return Nome
                + " | "
                + Quantidade
                + " | R$"
                + ValorUnit.ToString("F2", CultureInfo.InvariantCulture)
                + " | R$"
                + ValorTotal().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
