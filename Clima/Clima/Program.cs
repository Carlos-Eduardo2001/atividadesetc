using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clima
{ //Crie um algoritmo que armazene as temperaturas diárias de uma cidade durante uma semana e unforme o dia mais quente e o mais frio.
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] semana = { "Segunda", "Terça", "Quarta", "Quinta", "Sexta", "Sabado", "Domingo" };
            int max = int.MinValue, min = int.MaxValue, tempMax = 0, tempMin = 0;
            int[] temperatura = new int[7];
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine($"Temperatura de {semana[i]}: ");
                temperatura[i] = int.Parse(Console.ReadLine());

                if (temperatura[i] > max)
                {
                    max = temperatura[i]; tempMax = 0;
                    
                }
                if (temperatura[i] < min) { min = temperatura[i]; tempMin = i;}
            }
            Console.WriteLine($"Dia da semana mais quente: {semana[tempMax]} ({max}ºC)");
            Console.WriteLine($"Dia da semana mais frio: {semana[tempMin]} ({min}°C)");
            }













        
    }
}
