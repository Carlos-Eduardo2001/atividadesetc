using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Data;
namespace ClinicaPodologia
{
    internal class Program
    {
        static int totalRegistrationCount = 0;
        static void Main(string[] args)
        {
            int opcao = 0;
            while (opcao != 7)
            {

                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine(@"
░█████╗░██╗░░░░░██╗███╗░░██╗██╗░█████╗░░█████╗░  ██████╗░███████╗
██╔══██╗██║░░░░░██║████╗░██║██║██╔══██╗██╔══██╗  ██╔══██╗██╔════╝
██║░░╚═╝██║░░░░░██║██╔██╗██║██║██║░░╚═╝███████║  ██║░░██║█████╗░░
██║░░██╗██║░░░░░██║██║╚████║██║██║░░██╗██╔══██║  ██║░░██║██╔══╝░░
╚█████╔╝███████╗██║██║░╚███║██║╚█████╔╝██║░░██║  ██████╔╝███████╗
░╚════╝░╚══════╝╚═╝╚═╝░░╚══╝╚═╝░╚════╝░╚═╝░░╚═╝  ╚═════╝░╚══════╝

██████╗░░█████╗░██████╗░░█████╗░██╗░░░░░░█████╗░░██████╗░██╗░█████╗░
██╔══██╗██╔══██╗██╔══██╗██╔══██╗██║░░░░░██╔══██╗██╔════╝░██║██╔══██╗
██████╔╝██║░░██║██║░░██║██║░░██║██║░░░░░██║░░██║██║░░██╗░██║███████║
██╔═══╝░██║░░██║██║░░██║██║░░██║██║░░░░░██║░░██║██║░░╚██╗██║██╔══██║
██║░░░░░╚█████╔╝██████╔╝╚█████╔╝███████╗╚█████╔╝╚██████╔╝██║██║░░██║
╚═╝░░░░░░╚════╝░╚═════╝░░╚════╝░╚══════╝░╚════╝░░╚═════╝░╚═╝╚═╝░░╚═╝");

                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("1 - Cadastrar Cliente (Ficha Rápida");
                Console.WriteLine("2 - Cadastrar Podólogo"); // Ano, Nome Artista, Quantidade de Album, Quantidade de Vendas
                Console.WriteLine("3 - Cadastrar Procedimento/Serviço"); // Digitar a quantidade de músicas (Nome da música, Duração, Premiação)
                Console.WriteLine("4 - Agendar Consulta");
                Console.WriteLine("5 - Listar Agendamentos");
                Console.WriteLine("6 - Exibir Todos os Cadastros");
                Console.WriteLine("7 - Exit ----> ");
                Console.ResetColor();
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:

                        break;
                    case 2:
                        Funcao_Podologia();

                        break;
                    case 3:

                        break;
                    case 4:
                        Funcao_Agendamento();
                        
                        break;
                    case 5:
                        Listar_Agendamentos();

                        break;
                    case 6:

                        break;
                    case 7:
                        Console.Clear();
                        Console.WriteLine(" Saindo do programa!! Tchau Tchau ! !   :)");
                        break;

                }

            }

        }

        static void Funcao_Podologia()
        {
            int id;
            string Nome, RegistroProfissional, Especialidade, Telefone, continuar = "s";

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(@"
███████╗██╗░░░██╗███╗░░██╗░█████╗░░█████╗░░█████╗░
██╔════╝██║░░░██║████╗░██║██╔══██╗██╔══██╗██╔══██╗
█████╗░░██║░░░██║██╔██╗██║██║░░╚═╝███████║██║░░██║
██╔══╝░░██║░░░██║██║╚████║██║░░██╗██╔══██║██║░░██║
██║░░░░░╚██████╔╝██║░╚███║╚█████╔╝██║░░██║╚█████╔╝
╚═╝░░░░░░╚═════╝░╚═╝░░╚══╝░╚════╝░╚═╝░░╚═╝░╚════╝░

██████╗░░█████╗░██████╗░░█████╗░██╗░░░░░░█████╗░░██████╗░██╗░█████╗░
██╔══██╗██╔══██╗██╔══██╗██╔══██╗██║░░░░░██╔══██╗██╔════╝░██║██╔══██╗
██████╔╝██║░░██║██║░░██║██║░░██║██║░░░░░██║░░██║██║░░██╗░██║███████║
██╔═══╝░██║░░██║██║░░██║██║░░██║██║░░░░░██║░░██║██║░░╚██╗██║██╔══██║
██║░░░░░╚█████╔╝██████╔╝╚█████╔╝███████╗╚█████╔╝╚██████╔╝██║██║░░██║
╚═╝░░░░░░╚════╝░╚═════╝░░╚════╝░╚══════╝░╚════╝░░╚═════╝░╚═╝╚═╝░░╚═╝");

            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Cadastre a função do Podologo (Profissional)! ");
            while (continuar.ToLower() == "s")
            {
                Console.WriteLine("\nIdentificador do profssional: ");
                id = int.Parse(Console.ReadLine());

                Console.WriteLine("\nNome do especialista: ");
                Nome = Console.ReadLine();

                Console.WriteLine("\nNúmero do conselho/regristro técnico: ");
                RegistroProfissional = Console.ReadLine();

                Console.WriteLine("\nEx: Podopediatria, Pé Diabético, Esportiva: ");
                Especialidade = Console.ReadLine();

                Console.WriteLine("\nContato corporativo: ");
                Telefone = Console.ReadLine();
                Console.WriteLine("\nDeseja cadastrar outro profissional? (s/n)");
                continuar = Console.ReadLine();
                Console.Clear();
            }
            Thread.Sleep(1500);
        }

    
        static void Funcao_Agendamento()
        {
            int id, Clienteld, Podologold, Procedimentoid;
            string continuar = "s",Status;
            DateTime DataHora;





            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(@"
███████╗██╗░░░██╗███╗░░██╗░█████╗░░█████╗░░█████╗░
██╔════╝██║░░░██║████╗░██║██╔══██╗██╔══██╗██╔══██╗
█████╗░░██║░░░██║██╔██╗██║██║░░╚═╝███████║██║░░██║
██╔══╝░░██║░░░██║██║╚████║██║░░██╗██╔══██║██║░░██║
██║░░░░░╚██████╔╝██║░╚███║╚█████╔╝██║░░██║╚█████╔╝
╚═╝░░░░░░╚═════╝░╚═╝░░╚══╝░╚════╝░╚═╝░░╚═╝░╚════╝░

░█████╗░░██████╗░███████╗███╗░░██╗██████╗░░█████╗░███╗░░░███╗███████╗███╗░░██╗████████╗░█████╗░
██╔══██╗██╔════╝░██╔════╝████╗░██║██╔══██╗██╔══██╗████╗░████║██╔════╝████╗░██║╚══██╔══╝██╔══██╗
███████║██║░░██╗░█████╗░░██╔██╗██║██║░░██║███████║██╔████╔██║█████╗░░██╔██╗██║░░░██║░░░██║░░██║
██╔══██║██║░░╚██╗██╔══╝░░██║╚████║██║░░██║██╔══██║██║╚██╔╝██║██╔══╝░░██║╚████║░░░██║░░░██║░░██║
██║░░██║╚██████╔╝███████╗██║░╚███║██████╔╝██║░░██║██║░╚═╝░██║███████╗██║░╚███║░░░██║░░░╚█████╔╝
╚═╝░░╚═╝░╚═════╝░╚══════╝╚═╝░░╚══╝╚═════╝░╚═╝░░╚═╝╚═╝░░░░░╚═╝╚══════╝╚═╝░░╚══╝░░░╚═╝░░░░╚════╝░");

            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Cadastre os agendamentos! ");

            while (continuar.ToLower() == "s")
            {

                Console.WriteLine("\nCódigo do agendamento: ");
                id = int.Parse(Console.ReadLine());

                Console.WriteLine("\nCódigo do paciente cadastrado: ");
                Clienteld = int.Parse(Console.ReadLine());

                Console.WriteLine("\nCódigo do profissional responsável: ");
                Podologold = int.Parse(Console.ReadLine());

                Console.WriteLine("\nCódigo do procedimento a ser realizado: ");
                Procedimentoid = int.Parse(Console.ReadLine());

                Console.WriteLine("\nData e horário marcados: ");
                DataHora = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", new System.Globalization.CultureInfo("pt-BR"));

                Console.WriteLine("\nAgendamento, Concluido, Cancelado: ");
                Status = Console.ReadLine();


                Console.WriteLine("\nDeseja cadastrar mais algum agendamento? (s/n)");
                continuar = Console.ReadLine();
                totalRegistrationCount++;
                Console.Clear();
             }
            Thread.Sleep(1500);
           }

        static void Listar_Agendamentos()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(@"
██╗░░░░░██╗░██████╗████████╗░█████╗░██████╗░
██║░░░░░██║██╔════╝╚══██╔══╝██╔══██╗██╔══██╗
██║░░░░░██║╚█████╗░░░░██║░░░███████║██████╔╝
██║░░░░░██║░╚═══██╗░░░██║░░░██╔══██║██╔══██╗
███████╗██║██████╔╝░░░██║░░░██║░░██║██║░░██║
╚══════╝╚═╝╚═════╝░░░░╚═╝░░░╚═╝░░╚═╝╚═╝░░╚═╝

░█████╗░░██████╗░███████╗███╗░░██╗██████╗░░█████╗░███╗░░░███╗███████╗███╗░░██╗████████╗░█████╗░░██████╗
██╔══██╗██╔════╝░██╔════╝████╗░██║██╔══██╗██╔══██╗████╗░████║██╔════╝████╗░██║╚══██╔══╝██╔══██╗██╔════╝
███████║██║░░██╗░█████╗░░██╔██╗██║██║░░██║███████║██╔████╔██║█████╗░░██╔██╗██║░░░██║░░░██║░░██║╚█████╗░
██╔══██║██║░░╚██╗██╔══╝░░██║╚████║██║░░██║██╔══██║██║╚██╔╝██║██╔══╝░░██║╚████║░░░██║░░░██║░░██║░╚═══██╗
██║░░██║╚██████╔╝███████╗██║░╚███║██████╔╝██║░░██║██║░╚═╝░██║███████╗██║░╚███║░░░██║░░░╚█████╔╝██████╔╝
╚═╝░░╚═╝░╚═════╝░╚══════╝╚═╝░░╚══╝╚═════╝░╚═╝░░╚═╝╚═╝░░░░░╚═╝╚══════╝╚═╝░░╚══╝░░░╚═╝░░░░╚════╝░╚═════╝░");

            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkCyan;

            Console.WriteLine($"Total de Agendamentos: 




















        }













        }



}
    

