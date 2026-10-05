using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondiPagamento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Faça um algoritmo que leia o valor de um produto e determine o valor que deve ser pago, conforme a escolha da forma de pagamento pelo comprador
              e imprima na tela o valor final do produto a ser pago. Utilize os códigos da tabela de condições de pagamento para efetuar o cálculo adequedo.

                       Tabela de Código de Condições de Pagamento
             1- Á vista em Dinheiro ou Pix, recebe 15% de desconto
             2- Á vista no cartão de crédito, recebe 10% de desconto
             3- Parcelado no cartão em duas vezes, preço normal do produto sem juros
             4- Parcelado no cartão em três vezes ou mais, preço normal do produto mais juros de 10%*/

            double valor, valorfinal;
            int codigo;

            Console.WriteLine("Digite o preço do produto: ");
            valor = double.Parse(Console.ReadLine());

            Console.WriteLine("\nEscolha a forma de pagamento: ");
            Console.WriteLine("1- Á vista em Dinheiro ou Pix, recebe 15% de desconto ");
            Console.WriteLine("2- Á vista no cartão de crédito, recebe 10% de desconto ");
            Console.WriteLine("3- Parcelado no cartão em duas vezes, preço normal do produto sem juros");
            Console.WriteLine("4- Parcelado no cartão em três vezes ou mais, preço normal do produto mais juros de 10% ");

            Console.WriteLine("\nDigite o código de pagamento: ");
            codigo = int.Parse(Console.ReadLine());

             if (codigo == 1)
            {
                // 15% de desconto
                valorfinal = valor - (valor * 0.15);
                Console.WriteLine("Pagamento à vista em dinheiro ou Pix. ");
            }

            else if (codigo ==2)
            {
                // 10% de desconto
                valorfinal = valor - (valor * 0.10);
                Console.WriteLine("Pagamento a vista no cartão de crédito. ");
            }
            else if(codigo ==3)
            {
                // preço normal, sem juros
                valorfinal = valor;
            }
            else if(codigo ==4)
            {
                //10% de juros
                valorfinal = valor + (valor * 0.10);
                Console.WriteLine("Pagamento parcelado em três vezes ou mais. ");
            }
            else












        }
    }
}
