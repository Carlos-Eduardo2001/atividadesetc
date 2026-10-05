using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reajuste_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Faça um algoritmo que leia um valor qualquer e imprima na tela com um reajuste de 5%
            double reajuste, novovalor, valor;
            Console.WriteLine("Digite um valor para saber quanto é 5% dele: ");
            valor = Double.Parse(Console.ReadLine());
            reajuste = valor * 0.05;
            novovalor = valor + reajuste;
            Console.WriteLine("Valor com reajuste de 5%: " + novovalor);
















        }
    }
}
