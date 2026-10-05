using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace verdadeiro_falso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Faça um algoritmo que leia dois valores booleanos (lógicos) e determine se ambos são VERDADEIROS ou FALSO
            bool valor1, valor2;

            Console.Write("Digite o primeiro valor (true/false): ");
            valor1 = bool.Parse(Console.ReadLine());

            Console.Write("Digite o segundo valor (true/false): ");
            valor2 = bool.Parse(Console.ReadLine());

            if (valor1 && valor2)
            {
                Console.WriteLine("Ambos são VERDADEIROS!");
            }
            else if (!valor1 && !valor2)
            {
                Console.WriteLine("Ambos são FALSOS!");
            }
            else
            {
                Console.WriteLine(" Os valores são diferentes.");
            }











        }
    }
}
