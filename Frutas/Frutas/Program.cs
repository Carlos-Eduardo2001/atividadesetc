using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frutas
{     //"Implemente um sistema que armazene as quantidades de 5 tipos de frutas em 3 cestas e calcule o total de frutas de cada tipo"
    internal class Program
    {
        static void Main(string[] args)
        {   
            string[] tipos = { "Banana", "Melancia", "Maçã", "Morango", "Mamão" };

            int[,] frutas = new int[5, 3];

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"\n{tipos[i]}:");
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine($"Cesta {j + i}: ");
                    frutas[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("\nTotal de cada fruta: ");
            for(int i =0; i <5; i++)
            {
                int total = frutas[1, 0] + frutas[i, 2];
                Console.WriteLine($"{tipos[i]}: {total}");
            }
            }



            
           
            
                










        
    }
}
