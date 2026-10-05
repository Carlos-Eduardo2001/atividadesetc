using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Security.Principal;
using System.Security.Cryptography;
namespace Biblioteca
{      /*Mapear os requisitos do sistema e implementar no console em C# a estrutura de classes com suas respectivas propriedades, simulando a instanciação de objetos na memória*/
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcao = 0;
            while (opcao != 6)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine(@"
██████╗░██╗██████╗░██╗░░░░░██╗░█████╗░████████╗███████╗░█████╗░░█████╗░
██╔══██╗██║██╔══██╗██║░░░░░██║██╔══██╗╚══██╔══╝██╔════╝██╔══██╗██╔══██╗
██████╦╝██║██████╦╝██║░░░░░██║██║░░██║░░░██║░░░█████╗░░██║░░╚═╝███████║
██╔══██╗██║██╔══██╗██║░░░░░██║██║░░██║░░░██║░░░██╔══╝░░██║░░██╗██╔══██║
██████╦╝██║██████╦╝███████╗██║╚█████╔╝░░░██║░░░███████╗╚█████╔╝██║░░██║
╚═════╝░╚═╝╚═════╝░╚══════╝╚═╝░╚════╝░░░░╚═╝░░░╚══════╝░╚════╝░╚═╝░░╚═╝");

                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("1 - Cadastro Livro");
                Console.WriteLine("2 - Cadastro Jogo");
                Console.WriteLine("3 - Cadastrar Cliente");
                Console.WriteLine("4 - Cadastrar Fornecedor");
                Console.WriteLine("5 - Registrar Empréstimo");
                Console.WriteLine("6 - Sair do programa");
                Console.WriteLine(" ---> ");
                Console.ResetColor();
                opcao = int.Parse(Console.ReadLine());

                switch(opcao)
                {
                    case 1:
                        Cadastro_Livro();
                        break;
                    case 2:
                        Jogos();
                        break;
                    case 3:
                        Cadastro_Cliente();
                        break;
                    case 4:
                        Classe_Fornecedor();
                        break;
                    case 5:
                        Registrar_Emprestimo();
                        break;
                    case 6:
                        Console.Clear();
                        Console.WriteLine(" Saindo do programa ! ! Tchau Tchau ! !");
                        break;
                
                
               }
            }

          }
        static void Cadastro_Livro()
        {
            int id, AnoPublicacao, qtdExemplar;
            string titulo, autor, isbn, genero, continuar = "s";

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(@"
░█████╗░░█████╗░██████╗░░█████╗░░██████╗████████╗██████╗░░█████╗░  ██╗░░░░░██╗██╗░░░██╗██████╗░░█████╗░░██████╗
██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔════╝╚══██╔══╝██╔══██╗██╔══██╗  ██║░░░░░██║██║░░░██║██╔══██╗██╔══██╗██╔════╝
██║░░╚═╝███████║██║░░██║███████║╚█████╗░░░░██║░░░██████╔╝██║░░██║  ██║░░░░░██║╚██╗░██╔╝██████╔╝██║░░██║╚█████╗░
██║░░██╗██╔══██║██║░░██║██╔══██║░╚═══██╗░░░██║░░░██╔══██╗██║░░██║  ██║░░░░░██║░╚████╔╝░██╔══██╗██║░░██║░╚═══██╗
╚█████╔╝██║░░██║██████╔╝██║░░██║██████╔╝░░░██║░░░██║░░██║╚█████╔╝  ███████╗██║░░╚██╔╝░░██║░░██║╚█████╔╝██████╔╝
░╚════╝░╚═╝░░╚═╝╚═════╝░╚═╝░░╚═╝╚═════╝░░░░╚═╝░░░╚═╝░░╚═╝░╚════╝░  ╚══════╝╚═╝░░░╚═╝░░░╚═╝░░╚═╝░╚════╝░╚═════╝░");

            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Cadastre seu livro! ");
            while (continuar.ToLower() == "s") 
        {
            
            
            
                Console.WriteLine("Identificador único: ");
            id = int.Parse(Console.ReadLine());

            Console.WriteLine("Título da obra: ");
            titulo = Console.ReadLine();

            Console.WriteLine("Nome do autor: ");
            autor = Console.ReadLine();

            Console.WriteLine("Código de identificação internacional: ");
            isbn = Console.ReadLine();

            Console.WriteLine("Ano de lançamento: ");
            AnoPublicacao = int.Parse(Console.ReadLine());

            Console.WriteLine("Categoria (ex: Ficção, Ténico): ");
            genero = Console.ReadLine();

            Console.WriteLine("Total de cópias na biblioteca: ");
            qtdExemplar = int.Parse(Console.ReadLine());

                Console.WriteLine("\nDeseja cadastrar outro livro? (s/n)");
                continuar = Console.ReadLine();
                Console.Clear();
            }

            Thread.Sleep(1500);
            }


        static void Jogos()
        {
            string continuar = "s", nome, categoria;
            int id, NumMinJogadores, faixaetaria, NumMaxJogadores, qtdExemplares;




            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(@"
░░░░░██╗░█████╗░░██████╗░░█████╗░░██████╗
░░░░░██║██╔══██╗██╔════╝░██╔══██╗██╔════╝
░░░░░██║██║░░██║██║░░██╗░██║░░██║╚█████╗░
██╗░░██║██║░░██║██║░░╚██╗██║░░██║░╚═══██╗
╚█████╔╝╚█████╔╝╚██████╔╝╚█████╔╝██████╔╝
░╚════╝░░╚════╝░░╚═════╝░░╚════╝░╚═════╝░");


            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Cadastre seu Jogo! ");

            while (continuar.ToLower() == "s") 
         {
                Console.WriteLine("Identificador único: ");
                id = int.Parse(Console.ReadLine());

                Console.WriteLine("Nome do jogo: ");
                nome = Console.ReadLine();

                Console.WriteLine("Tipo (ex: Estratégia, RPG, Tabuleiro): ");
                categoria = Console.ReadLine();

                Console.WriteLine("Idade minima recomendada: ");
                faixaetaria = int.Parse(Console.ReadLine());

                Console.WriteLine("Quantidade mínima de participantes: ");
                NumMinJogadores = int.Parse(Console.ReadLine());

                Console.WriteLine("Quantidade máxima de participantes: ");
                NumMaxJogadores = int.Parse(Console.ReadLine());

                Console.WriteLine("Total de caixas disponíveis: ");
                qtdExemplares = int.Parse(Console.ReadLine());

                Console.WriteLine("\nDeseja cadastrar outro jogo? (s/n)");
                continuar = Console.ReadLine();
                Console.Clear();
         }
            Thread.Sleep(1500);
        }

      static void Cadastro_Cliente()
        {
            string continuar = "s", Email, CPF, Nome, Telefone;
            int id;
            bool Ativo;
            DateTime datanascimento;




            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(@"
░█████╗░░█████╗░██████╗░░█████╗░░██████╗████████╗██████╗░░█████╗░
██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔════╝╚══██╔══╝██╔══██╗██╔══██╗
██║░░╚═╝███████║██║░░██║███████║╚█████╗░░░░██║░░░██████╔╝██║░░██║
██║░░██╗██╔══██║██║░░██║██╔══██║░╚═══██╗░░░██║░░░██╔══██╗██║░░██║
╚█████╔╝██║░░██║██████╔╝██║░░██║██████╔╝░░░██║░░░██║░░██║╚█████╔╝
░╚════╝░╚═╝░░╚═╝╚═════╝░╚═╝░░╚═╝╚═════╝░░░░╚═╝░░░╚═╝░░╚═╝░╚════╝░

░█████╗░██╗░░░░░██╗███████╗███╗░░██╗████████╗███████╗░██████╗
██╔══██╗██║░░░░░██║██╔════╝████╗░██║╚══██╔══╝██╔════╝██╔════╝
██║░░╚═╝██║░░░░░██║█████╗░░██╔██╗██║░░░██║░░░█████╗░░╚█████╗░
██║░░██╗██║░░░░░██║██╔══╝░░██║╚████║░░░██║░░░██╔══╝░░░╚═══██╗
╚█████╔╝███████╗██║███████╗██║░╚███║░░░██║░░░███████╗██████╔╝
░╚════╝░╚══════╝╚═╝╚══════╝╚═╝░░╚══╝░░░╚═╝░░░╚══════╝╚═════╝░");


            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Cadastre seus clientes! ");

            while (continuar.ToLower() == "s")
            {

                Console.WriteLine("Identificador único: ");
                id = int.Parse(Console.ReadLine());

                Console.WriteLine("Nome completo do usuário: ");
                Nome = Console.ReadLine();

                Console.WriteLine("Documento de identificação: ");
                CPF = Console.ReadLine();

                Console.WriteLine("Número de contato");
                Telefone = Console.ReadLine();

                Console.WriteLine("Endereço de e-mail: ");
                Email = Console.ReadLine();

                Console.WriteLine("Data de nascimento (DD/MM/AAAA): ");
                datanascimento =DateTime.Parse(Console.ReadLine(), new System.Globalization.CultureInfo("pt-BR"));

                Console.WriteLine("Situação de cadastro (true/false): ");
                Ativo = bool.Parse(Console.ReadLine());

                if (Ativo == true)
                {
                    Console.WriteLine("Cadastro ativo! ");
                }
                else
                {
                    Console.WriteLine("Por favor atualize o cadastro! ");
                }
                Console.WriteLine("\nDeseja cadastrar outro cliente ? (s/n)");
                continuar = Console.ReadLine();
                Console.Clear();
            }
            Thread.Sleep(1000);
        }





        static void Classe_Fornecedor()
        {
            string continuar = "s", RazaoSocial, CNPJ, Telefone, Email, Endereco;
            int id;


            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(@"
░█████╗░░█████╗░██████╗░░█████╗░░██████╗████████╗██████╗░░█████╗░
██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔════╝╚══██╔══╝██╔══██╗██╔══██╗
██║░░╚═╝███████║██║░░██║███████║╚█████╗░░░░██║░░░██████╔╝██║░░██║
██║░░██╗██╔══██║██║░░██║██╔══██║░╚═══██╗░░░██║░░░██╔══██╗██║░░██║
╚█████╔╝██║░░██║██████╔╝██║░░██║██████╔╝░░░██║░░░██║░░██║╚█████╔╝
░╚════╝░╚═╝░░╚═╝╚═════╝░╚═╝░░╚═╝╚═════╝░░░░╚═╝░░░╚═╝░░╚═╝░╚════╝░

███████╗░█████╗░██████╗░███╗░░██╗███████╗░█████╗░███████╗██████╗░░█████╗░██████╗░
██╔════╝██╔══██╗██╔══██╗████╗░██║██╔════╝██╔══██╗██╔════╝██╔══██╗██╔══██╗██╔══██╗
█████╗░░██║░░██║██████╔╝██╔██╗██║█████╗░░██║░░╚═╝█████╗░░██║░░██║██║░░██║██████╔╝
██╔══╝░░██║░░██║██╔══██╗██║╚████║██╔══╝░░██║░░██╗██╔══╝░░██║░░██║██║░░██║██╔══██╗
██║░░░░░╚█████╔╝██║░░██║██║░╚███║███████╗╚█████╔╝███████╗██████╔╝╚█████╔╝██║░░██║
╚═╝░░░░░░╚════╝░╚═╝░░╚═╝╚═╝░░╚══╝╚══════╝░╚════╝░╚══════╝╚═════╝░░╚════╝░╚═╝░░╚═╝");


            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Cadastre seus fornecedores! ");

            while(continuar.ToLower() == "s")
           {
                Console.WriteLine("Identificador único: ");
                id = int.Parse(Console.ReadLine());

                Console.WriteLine("Nome jurítico da empresa/editora: ");
                RazaoSocial = Console.ReadLine();

                Console.WriteLine("Registro nacional: ");
                CNPJ = Console.ReadLine();

                Console.WriteLine("Telefone corporativo: ");
                Telefone = Console.ReadLine();

                Console.WriteLine("E-mail de contato comercial: ");
                Email = Console.ReadLine();

                Console.WriteLine("Logradouro e cidade: ");
                Endereco = Console.ReadLine();

                Console.WriteLine("\nDeseja cadastrar outro fornecedor ? (s/n)");
                continuar = Console.ReadLine();
                Console.Clear();
            }
            Thread.Sleep(1000);
        }

    static void Registrar_Emprestimo()
        {
            int id, Clienteld, Itemid;
            string Tipoltem;
            DateTime DataEmprestimo, DataDevolucaoPrevista;
            bool Devolvido;

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(@"
██████╗░███████╗░██████╗░██╗░██████╗████████╗██████╗░░█████╗░██████╗░
██╔══██╗██╔════╝██╔════╝░██║██╔════╝╚══██╔══╝██╔══██╗██╔══██╗██╔══██╗
██████╔╝█████╗░░██║░░██╗░██║╚█████╗░░░░██║░░░██████╔╝███████║██████╔╝
██╔══██╗██╔══╝░░██║░░╚██╗██║░╚═══██╗░░░██║░░░██╔══██╗██╔══██║██╔══██╗
██║░░██║███████╗╚██████╔╝██║██████╔╝░░░██║░░░██║░░██║██║░░██║██║░░██║
╚═╝░░╚═╝╚══════╝░╚═════╝░╚═╝╚═════╝░░░░╚═╝░░░╚═╝░░╚═╝╚═╝░░╚═╝╚═╝░░╚═╝

███████╗███╗░░░███╗██████╗░██████╗░███████╗░██████╗████████╗██╗███╗░░░███╗░█████╗░
██╔════╝████╗░████║██╔══██╗██╔══██╗██╔════╝██╔════╝╚══██╔══╝██║████╗░████║██╔══██╗
█████╗░░██╔████╔██║██████╔╝██████╔╝█████╗░░╚█████╗░░░░██║░░░██║██╔████╔██║██║░░██║
██╔══╝░░██║╚██╔╝██║██╔═══╝░██╔══██╗██╔══╝░░░╚═══██╗░░░██║░░░██║██║╚██╔╝██║██║░░██║
███████╗██║░╚═╝░██║██║░░░░░██║░░██║███████╗██████╔╝░░░██║░░░██║██║░╚═╝░██║╚█████╔╝
╚══════╝╚═╝░░░░░╚═╝╚═╝░░░░░╚═╝░░╚═╝╚══════╝╚═════╝░░░░╚═╝░░░╚═╝╚═╝░░░░░╚═╝░╚════╝░");

            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Cadastre os emprestimos! ");
            Console.Write("Quantos empréstimos deseja cadastrar? ");
            int quantidade = int.Parse(Console.ReadLine());

            for (int i = 0; i < quantidade; i++)
            {
                Console.WriteLine($"Identificador único: ");
                id = int.Parse(Console.ReadLine());

                Console.WriteLine("Código do cliente associado: ");
                Clienteld = int.Parse(Console.ReadLine());

                Console.WriteLine("Define se é (Livro ou Jogo): ");
                Tipoltem = Console.ReadLine();

                Console.WriteLine("Código do livro ou jogo emprestado: ");
                Itemid = int.Parse(Console.ReadLine());

                Console.WriteLine("Data/hora da retirada: ");
                DataEmprestimo = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", new System.Globalization.CultureInfo("pt-BR"));

                Console.WriteLine("Data limite para entrega: ");
                DataDevolucaoPrevista = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", new System.Globalization.CultureInfo("pt-BR"));

                Console.WriteLine("Status de devolução: ");
                Devolvido = bool.Parse(Console.ReadLine());

                if (Devolvido == true)
                {
                    Console.WriteLine("Devolvido! ");
                }
                else
                {
                    Console.WriteLine("Pendente! ");
                }
                Console.WriteLine("\nCadastro Realizado com sucesso!");
                Thread.Sleep(2000);
                Console.Clear();

            }
            Thread.Sleep(2000);
           
        }

        }
}
