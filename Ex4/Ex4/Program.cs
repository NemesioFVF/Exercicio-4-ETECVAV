using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exemplo de valor em moeda: ###,##");
            Console.Write("Digite o valor em Reais: $");
            Double r = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite a cotação do Dólar: $");
            Double d = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite a cotação do Euro: $");
            Double e = Convert.ToDouble(Console.ReadLine());
            Double rd = r / d;
            Double re = r / e;
            Console.WriteLine("Valor em Dólar: $" + rd);
            Console.WriteLine("Valor em Euro: $" + re);
            Console.ReadKey();
        }
    }
}
