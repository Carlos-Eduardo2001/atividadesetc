using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Cadastro_de_Bandas
{
    internal class Program
    {
        /*
         
        se / enquanto / para /caso 
        if / while / for / switch

        Crie um sistema de cadastro de Álbuns de um artista / banda em que será possivel cadastrar um número X de músicas informada pelo usuário.
        Crie um menu de opção para isso.

         */


        static void Main(string[] args)
        {
            int opcao = 0;

            while (opcao != 4)
            {
                Console.Clear();        //Limpa a tela
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(@"
░█████╗░░█████╗░███╗░░██╗████████╗██████╗░░█████╗░██╗░░░░░███████╗  ██████╗░███████╗
██╔══██╗██╔══██╗████╗░██║╚══██╔══╝██╔══██╗██╔══██╗██║░░░░░██╔════╝  ██╔══██╗██╔════╝
██║░░╚═╝██║░░██║██╔██╗██║░░░██║░░░██████╔╝██║░░██║██║░░░░░█████╗░░  ██║░░██║█████╗░░
██║░░██╗██║░░██║██║╚████║░░░██║░░░██╔══██╗██║░░██║██║░░░░░██╔══╝░░  ██║░░██║██╔══╝░░
╚█████╔╝╚█████╔╝██║░╚███║░░░██║░░░██║░░██║╚█████╔╝███████╗███████╗  ██████╔╝███████╗
░╚════╝░░╚════╝░╚═╝░░╚══╝░░░╚═╝░░░╚═╝░░╚═╝░╚════╝░╚══════╝╚══════╝  ╚═════╝░╚══════╝

██████╗░░█████╗░███╗░░██╗██████╗░░█████╗░░██████╗
██╔══██╗██╔══██╗████╗░██║██╔══██╗██╔══██╗██╔════╝
██████╦╝███████║██╔██╗██║██║░░██║███████║╚█████╗░
██╔══██╗██╔══██║██║╚████║██║░░██║██╔══██║░╚═══██╗
██████╦╝██║░░██║██║░╚███║██████╔╝██║░░██║██████╔╝
╚═════╝░╚═╝░░╚═╝╚═╝░░╚══╝╚═════╝░╚═╝░░╚═╝╚═════╝░");

                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("1 - Cadastrar Album da Banda");
                Console.WriteLine("2 - Cadastrar Album do Artista"); // Ano, Nome Artista, Quantidade de Album, Quantidade de Vendas
                Console.WriteLine("3 - Cadastrar Músicas"); // Digitar a quantidade de músicas (Nome da música, Duração, Premiação)
                Console.WriteLine("4 - Sair do programa");
                Console.WriteLine(" ----> ");
                Console.ResetColor();
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:

                        Cadastro_Bandas();

                        break;
                    case 2:
                        Album_Artista();
                        break;
                    case 3:
                        musicas();
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine(" Saindo do programa!! Tchau Tchau ! !   :)");
                        break;
                }

            }

        }

        static void Cadastro_Bandas()
        {
            string nomeBanda, nomeAlbum;
            int qtdMusica;

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(@"
░█████╗░░█████╗░██████╗░░█████╗░░██████╗████████╗██████╗░░█████╗░  ██████╗░███████╗
██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔════╝╚══██╔══╝██╔══██╗██╔══██╗  ██╔══██╗██╔════╝
██║░░╚═╝███████║██║░░██║███████║╚█████╗░░░░██║░░░██████╔╝██║░░██║  ██║░░██║█████╗░░
██║░░██╗██╔══██║██║░░██║██╔══██║░╚═══██╗░░░██║░░░██╔══██╗██║░░██║  ██║░░██║██╔══╝░░
╚█████╔╝██║░░██║██████╔╝██║░░██║██████╔╝░░░██║░░░██║░░██║╚█████╔╝  ██████╔╝███████╗
░╚════╝░╚═╝░░╚═╝╚═════╝░╚═╝░░╚═╝╚═════╝░░░░╚═╝░░░╚═╝░░╚═╝░╚════╝░  ╚═════╝░╚══════╝

██████╗░░█████╗░███╗░░██╗██████╗░░█████╗░░██████╗
██╔══██╗██╔══██╗████╗░██║██╔══██╗██╔══██╗██╔════╝
██████╦╝███████║██╔██╗██║██║░░██║███████║╚█████╗░
██╔══██╗██╔══██║██║╚████║██║░░██║██╔══██║░╚═══██╗
██████╦╝██║░░██║██║░╚███║██████╔╝██║░░██║██████╔╝
╚═════╝░╚═╝░░╚═╝╚═╝░░╚══╝╚═════╝░╚═╝░░╚═╝╚═════╝░");

            Console.ResetColor();

            Console.WriteLine("Digite o Nome da Banda: ");
            nomeBanda = Console.ReadLine();

            Console.WriteLine("Digite o Nome da Album: ");
            nomeAlbum = Console.ReadLine();

            Console.WriteLine("Digite o Número de Músicas: ");
            qtdMusica = int.Parse(Console.ReadLine());



            Console.WriteLine("\n Cadastro realizado com Sucesso ! ! !");
            Console.WriteLine("\n" + nomeBanda);
            Console.WriteLine("\n" + nomeAlbum);
            Console.WriteLine("\n" + qtdMusica);

            Thread.Sleep(2000);

        }



        static void Album_Artista()
        {
            string nomeArtista, nomeAno;
            int qtdVendas, qtdAlbum;

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(@"
░█████╗░██╗░░░░░██████╗░██╗░░░██╗███╗░░░███╗  ░█████╗░██████╗░████████╗██╗░██████╗████████╗░█████╗░
██╔══██╗██║░░░░░██╔══██╗██║░░░██║████╗░████║  ██╔══██╗██╔══██╗╚══██╔══╝██║██╔════╝╚══██╔══╝██╔══██╗
███████║██║░░░░░██████╦╝██║░░░██║██╔████╔██║  ███████║██████╔╝░░░██║░░░██║╚█████╗░░░░██║░░░███████║
██╔══██║██║░░░░░██╔══██╗██║░░░██║██║╚██╔╝██║  ██╔══██║██╔══██╗░░░██║░░░██║░╚═══██╗░░░██║░░░██╔══██║
██║░░██║███████╗██████╦╝╚██████╔╝██║░╚═╝░██║  ██║░░██║██║░░██║░░░██║░░░██║██████╔╝░░░██║░░░██║░░██║
╚═╝░░╚═╝╚══════╝╚═════╝░░╚═════╝░╚═╝░░░░░╚═╝  ╚═╝░░╚═╝╚═╝░░╚═╝░░░╚═╝░░░╚═╝╚═════╝░░░░╚═╝░░░╚═╝░░╚═╝");

            Console.ResetColor();

            Console.WriteLine("Digite o nome do Artista: ");
            nomeArtista = Console.ReadLine();

            Console.WriteLine("Digite o Ano do Album: ");
            nomeAno = Console.ReadLine();

            Console.WriteLine("Digite a quantidade de Albuns: ");
            qtdAlbum = int.Parse(Console.ReadLine());

            Console.WriteLine("Quantidade de vendas do Album: ");
            qtdVendas = int.Parse(Console.ReadLine());


            Console.WriteLine("\n Cadastro realizado com Sucesso ! ! !");
            Console.WriteLine("\n" + nomeArtista);
            Console.WriteLine("\n" + nomeAno);
            Console.WriteLine("\n" + qtdAlbum);
            Console.WriteLine("\n" + qtdVendas);

            Thread.Sleep(1500);

        }
        
        static void musicas()
        {

            string nomeMusica, premiacao, continuar = "s";
            int qtdMusica =0;
            double duracao;




            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(@"
███╗░░░███╗██╗░░░██╗░██████╗██╗░█████╗░░█████╗░░██████╗
████╗░████║██║░░░██║██╔════╝██║██╔══██╗██╔══██╗██╔════╝
██╔████╔██║██║░░░██║╚█████╗░██║██║░░╚═╝███████║╚█████╗░
██║╚██╔╝██║██║░░░██║░╚═══██╗██║██║░░██╗██╔══██║░╚═══██╗
██║░╚═╝░██║╚██████╔╝██████╔╝██║╚█████╔╝██║░░██║██████╔╝
╚═╝░░░░░╚═╝░╚═════╝░╚═════╝░╚═╝░╚════╝░╚═╝░░╚═╝╚═════╝░");


            Console.ResetColor();

            while (continuar.ToLower() == "s")
          {
            Console.WriteLine("Digite o nome da música: ");
            nomeMusica = Console.ReadLine();

            Console.WriteLine("Digite a quantidade de músicas: ");
            qtdMusica = int.Parse(Console.ReadLine());

            Console.WriteLine("Tempo de duração da música: ");
            duracao = double.Parse(Console.ReadLine());

            Console.WriteLine("A música ganhou alguma premiação ? (se sim digite qual) ");
            premiacao = Console.ReadLine();


                qtdMusica++;






                Console.WriteLine("\nCadastro de música com sucesso!");
                Console.WriteLine("Total de músicas: " + qtdMusica);
                Console.WriteLine("Nome da música: " + nomeMusica);
                Console.WriteLine("Tempo de música: " + duracao);
                Console.WriteLine("Premiação: " + premiacao);

                Console.WriteLine("\nDeseja cadastrar outra música? (s/n)");
                continuar = Console.ReadLine();
                
            }

            Console.WriteLine("\nTotal de músicas cadastradas: " + qtdMusica);

            Thread.Sleep(2000);
        }
    }
 }