using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace imc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Faça um algoritmo que calcule o IMC(Indice de Massa Corporal) de uma pessoa, leia o seu peso e altura e imprima na tela sua condição
            double peso, altura, imc;
            string nome;
            Console.WriteLine("Digite o seu nome: ");
            nome = Console.ReadLine();
            Console.Clear();

            Console.Write("Digite seu peso em kg: ");
            peso = double.Parse(Console.ReadLine());

            Console.Write("Digite sua altura em metros: ");
            altura = double.Parse(Console.ReadLine());

            imc = peso / (altura * altura);

            if (imc < 18.5)
            {
                Console.WriteLine("Condição: Abaixo do peso! ");
            }
            else if (imc >= 18.6 & imc <=24.9)
            {
                Console.WriteLine("Condição: Peso Ideal (parabéns)");
            }
            else if (imc >= 25.0 & imc <= 29.9)
            {
                Console.WriteLine("Condição: Levemente acima do peso: ");
            }
            else if (imc >= 30 & imc <= 34.9)
            {
                Console.WriteLine("Condição: Obesidade gra 1 ");
            }
            else if (imc >= 35.0 & imc <= 39.9)
            {
                Console.WriteLine("Condição: Obesidade grau 2 (Severa)");
            }
            else
            {
                Console.WriteLine("Condição: Obesidade grau 3 (Móbida)");
            }

            Console.WriteLine("\nOlá " + nome + " seu IMC é " + imc);
        }
    }
}
