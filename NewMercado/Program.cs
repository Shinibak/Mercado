using System;
using System.Collections.Generic;
using System.Globalization;

namespace NewMercado
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Carrinho> list = new List<Carrinho>();
            Boolean sair = false;

            while (sair != true)
            {
                Console.WriteLine("01 - Mercado");
                Console.WriteLine("02 - Carrinho");
                Console.WriteLine("03 - Finalizar/Sair");
                int op = int.Parse(Console.ReadLine());

                if (op == 1)
                {
                    Console.Clear();
                    Console.WriteLine("01 | Banana | R$3.00");
                    Console.WriteLine("02 | Arroz  | R$5.00");
                    Console.WriteLine("03 | Feijão | R$10.00");
                    int n = int.Parse(Console.ReadLine());

                    if (n == 1)
                    {
                        int quantidade = 4;
                        double valor = 10.00;
                        list.Add(new Carrinho("banana", quantidade, valor));
                    }
                }
                else if (op == 2)
                {
                    Double j=0;
                    int i = 0;
                    foreach (Carrinho obj in list)
                    {
                        Console.WriteLine(i+" - "+obj);
                        j += list[i].ValorT;
                        i++;
                    }
                    Console.WriteLine(j);
                }
                else if (op == 3)
                {

                }
                else
                {
                    Console.WriteLine("\nOpção Invalida");
                }
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
