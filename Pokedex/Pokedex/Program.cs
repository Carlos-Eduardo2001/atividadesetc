using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nomePokemon = { "Pikachu ", "Bulbasaur", "Charmander", "Squirtle", "Zubat", "Meowth", "Psyduck", "Poliwag", "Machop", "Polihirl" };
            string[] tipoPokemon = { "Elétrico ", "Grama/Veneno ", "Fogo           ", "Água ", "Veneno/Voador", "Normal      ", "Água      ", "Água      ", "Lutador        ", "Água       " };

            string[] pesoPokemon = {
            "6.0 kg",  // Pikachu
            "6.9 kg",  // Bulbasaur
            "8.5 kg",  // Charmander
            "9.0 kg",  // Squirtle
            "7.5 kg",  // Zubat
            "4.2 kg",  // Meowth
            "19.6 kg", // Psyduck
            "12.4 kg", // Poliwag
            "19.5 kg", // Machop
            "20.0 kg", // Poliwhirl
            };



            string[] tamanhoPokemon = {

            "0.4 m",   // Pikachu
            "0.7 m",   // Bulbasaur
            "0.6 m",   // Charmander
            "0.5 m",   // Squirtle
            "0.8 m",   // Zubat
            "0.4 m",   // Meowth
            "0.8 m",   //Psyduck
            "0.6 m", // Poliwag
            "0.8 m", // Machop
            "1.0 m", // Poliwhil
            };

            int[] numeroPokemon =
            {
            25, // Pikachu
            4,  // Bulbasaur
            4,  // Charmander
            7,  // Squirtle
            41, // Zubat
            52, // Meowth
            54, //Psyduck
            60, // Poliwag
            56, // Machop
            61, // Poliwhil 
            };

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nLISTAGEM DE POKEMONS");
            Console.ResetColor();

            for (int i = 0; i < numeroPokemon.Length; i++) // Length -- ele soma o total de itens do vetor
            {
                Console.WriteLine("ID:      " + numeroPokemon[i]);
                Console.WriteLine("Nome:    " + nomePokemon[i]);
                Console.WriteLine("Tipo:    " + tipoPokemon[i]);
                Console.WriteLine("Altura:  " + tamanhoPokemon[i]);
                Console.WriteLine("Peso:    " + pesoPokemon[i]);
                Console.WriteLine("===========================================");






            }
        }
    }
}
