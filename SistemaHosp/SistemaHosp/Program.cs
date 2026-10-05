using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
namespace SistemaHosp
{
    internal class Program
    {
        public static class variaveis
        {

            public static string continuar = "s", status = " ", CPF = " ", NomePaciente;

            public static bool statusleito;

            public static int IDPaciente, alta = 0, internado = 0, transferido = 0, totalmedicos = 0, leito = 0, paciente = 0;
            public static string[] nomesPacientes = new string[100];
            public static string[] CPFsPacientes = new string[100];
            public static string[] statusPacientes = new string[100];

            public static int quantidadePacientes = 0;

        }


        static void Main(string[] args)
        {
            int opcao = 0;
            while (opcao != 8)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine(@"
░██████╗██╗░██████╗████████╗███████╗███╗░░░███╗░█████╗░  ██████╗░███████╗
██╔════╝██║██╔════╝╚══██╔══╝██╔════╝████╗░████║██╔══██╗  ██╔══██╗██╔════╝
╚█████╗░██║╚█████╗░░░░██║░░░█████╗░░██╔████╔██║███████║  ██║░░██║█████╗░░
░╚═══██╗██║░╚═══██╗░░░██║░░░██╔══╝░░██║╚██╔╝██║██╔══██║  ██║░░██║██╔══╝░░
██████╔╝██║██████╔╝░░░██║░░░███████╗██║░╚═╝░██║██║░░██║  ██████╔╝███████╗
╚═════╝░╚═╝╚═════╝░░░░╚═╝░░░╚══════╝╚═╝░░░░░╚═╝╚═╝░░╚═╝  ╚═════╝░╚══════╝

██╗███╗░░██╗████████╗███████╗██████╗░███╗░░██╗░█████╗░░█████╗░░█████╗░░█████╗░
██║████╗░██║╚══██╔══╝██╔════╝██╔══██╗████╗░██║██╔══██╗██╔══██╗██╔══██╗██╔══██╗
██║██╔██╗██║░░░██║░░░█████╗░░██████╔╝██╔██╗██║███████║██║░░╚═╝███████║██║░░██║
██║██║╚████║░░░██║░░░██╔══╝░░██╔══██╗██║╚████║██╔══██║██║░░██╗██╔══██║██║░░██║
██║██║░╚███║░░░██║░░░███████╗██║░░██║██║░╚███║██║░░██║╚█████╔╝██║░░██║╚█████╔╝
╚═╝╚═╝░░╚══╝░░░╚═╝░░░╚══════╝╚═╝░░╚═╝╚═╝░░╚══╝╚═╝░░╚═╝░╚════╝░╚═╝░░╚═╝░╚════╝░

██╗░░██╗░█████╗░░██████╗██████╗░██╗████████╗░█████╗░██╗░░░░░░█████╗░██████╗░
██║░░██║██╔══██╗██╔════╝██╔══██╗██║╚══██╔══╝██╔══██╗██║░░░░░██╔══██╗██╔══██╗
███████║██║░░██║╚█████╗░██████╔╝██║░░░██║░░░███████║██║░░░░░███████║██████╔╝
██╔══██║██║░░██║░╚═══██╗██╔═══╝░██║░░░██║░░░██╔══██║██║░░░░░██╔══██║██╔══██╗
██║░░██║╚█████╔╝██████╔╝██║░░░░░██║░░░██║░░░██║░░██║███████╗██║░░██║██║░░██║
╚═╝░░╚═╝░╚════╝░╚═════╝░╚═╝░░░░░╚═╝░░░╚═╝░░░╚═╝░░╚═╝╚══════╝╚═╝░░╚═╝╚═╝░░╚═╝");

                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("1 - Cadastrar Paciente");
                Console.WriteLine("2 - Cadastrar Médico");
                Console.WriteLine("3 - Cadastrar Leito");
                Console.WriteLine("4 - Registrar internação (Admissão)");
                Console.WriteLine("5 - Dar Alta Hospitalar");
                Console.WriteLine("6 - Listar Pacientes Internados");
                Console.WriteLine("7 - Exibir Relatório Geral do Hospital");
                Console.WriteLine("8 - Sair");
                Console.ResetColor();
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Funcao_Paciente();
                        
                        break;
                    case 2:
                        CADASTRO_MEDICO();
                        
                        break;
                    case 3:
                        Funcao_Leito();
                        
                        break;
                    case 4:
                        REGISTRAR_INTERNACAO();

                        break;
                    case 5:
                        altahospitalar();

                        break;
                    case 6:
                        
                        Console.Clear();

                        Console.WriteLine("========================================");
                        Console.WriteLine("       PACIENTES INTERNADOS");
                        Console.WriteLine("========================================");

                        for (int i = 0; i < variaveis.quantidadePacientes; i++)
                        {
                            if (variaveis.statusPacientes[i].Equals("Internado", StringComparison.OrdinalIgnoreCase))
                            {
                                Console.WriteLine("Nome: " + variaveis.nomesPacientes[i]);
                                Console.WriteLine("CPF: " + variaveis.CPFsPacientes[i]);
                                Console.WriteLine("----------------------------------------");
                            }
                        }

                        Console.WriteLine("\nPressione qualquer tecla para voltar...");
                        Console.ReadKey();

                        break;
                    case 7:
                        Console.Clear();

                        Console.WriteLine("========================================");
                        Console.WriteLine("       RELATÓRIO GERAL DO HOSPITAL");
                        Console.WriteLine("========================================");

                        Console.WriteLine("\nTotal de pacientes que receberam alta: " + variaveis.alta);
                        Console.WriteLine("Total de pacientes internados: " + variaveis.internado);
                        Console.WriteLine("Total de pacientes transferidos: " + variaveis.transferido);
                        Console.WriteLine("Total de médicos disponiveis: " + variaveis.totalmedicos);
                        Console.WriteLine("\n========================================");
                        Console.WriteLine("Pressione qualquer tecla para voltar...");
                        Console.ReadKey();
                        break;
                    case 8:
                        Console.Clear();
                        Console.WriteLine("Saindo do programa!! Tchau Tchau ! !   :)");
                        break;
                }
            }
        }
        //1
        static void Funcao_Paciente()
        {
            string Alergias, ContatoEmergencia, TipoSanguineo;
            int idPaciente;
            DateTime DataNascimento;




            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(@"
███████╗██╗░░░██╗███╗░░██╗░█████╗░░█████╗░░█████╗░  ██████╗░░█████╗░░█████╗░██╗███████╗███╗░░██╗████████╗███████╗
██╔════╝██║░░░██║████╗░██║██╔══██╗██╔══██╗██╔══██╗  ██╔══██╗██╔══██╗██╔══██╗██║██╔════╝████╗░██║╚══██╔══╝██╔════╝
█████╗░░██║░░░██║██╔██╗██║██║░░╚═╝███████║██║░░██║  ██████╔╝███████║██║░░╚═╝██║█████╗░░██╔██╗██║░░░██║░░░█████╗░░
██╔══╝░░██║░░░██║██║╚████║██║░░██╗██╔══██║██║░░██║  ██╔═══╝░██╔══██║██║░░██╗██║██╔══╝░░██║╚████║░░░██║░░░██╔══╝░░
██║░░░░░╚██████╔╝██║░╚███║╚█████╔╝██║░░██║╚█████╔╝  ██║░░░░░██║░░██║╚█████╔╝██║███████╗██║░╚███║░░░██║░░░███████╗
╚═╝░░░░░░╚═════╝░╚═╝░░╚══╝░╚════╝░╚═╝░░╚═╝░╚════╝░  ╚═╝░░░░░╚═╝░░╚═╝░╚════╝░╚═╝╚══════╝╚═╝░░╚══╝░░░╚═╝░░░╚══════╝");

            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("\nRegistre o paciente!");
            
            while (variaveis.continuar.ToLower() == "s")
            {
                Console.WriteLine("\nIdentificador único: ");
                idPaciente = int.Parse(Console.ReadLine());

                Console.WriteLine("\nNome Completo do paciente: ");
                variaveis.NomePaciente = Console.ReadLine();

                Console.WriteLine("\nRegistro do paciente (CPF): ");
                variaveis.CPF = Console.ReadLine();

                Console.WriteLine("\nData de nascimento: ");
                DataNascimento = DateTime.Parse(Console.ReadLine(), new System.Globalization.CultureInfo("pt-BR"));

                Console.WriteLine("\nTipo sanguineo Ex: A+,O-,AB+,etc: ");
                TipoSanguineo = Console.ReadLine();

                Console.WriteLine("\nDescrição de alergias medicamentos/alimentares: ");
                Alergias = Console.ReadLine();

                Console.WriteLine("\nNome e telefone de um familiar/responsável: ");
                ContatoEmergencia = Console.ReadLine();

                
                Console.WriteLine("\nDeseja cadastrar outro paciente(s/n)");
                variaveis.continuar = Console.ReadLine();
                Console.Clear();
            }
            Thread.Sleep(1500);
        }
        //2
        static void CADASTRO_MEDICO()
        {
            int id;

            string nome, crm, especialidade, fone;



            Console.Clear();

            Console.ForegroundColor = ConsoleColor.DarkCyan;

            Console.WriteLine(@"
░█████╗░░█████╗░██████╗░░█████╗░░██████╗████████╗██████╗░░█████╗░  ███╗░░░███╗███████╗██████╗░██╗░█████╗░░█████╗░
██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔════╝╚══██╔══╝██╔══██╗██╔══██╗  ████╗░████║██╔════╝██╔══██╗██║██╔══██╗██╔══██╗
██║░░╚═╝███████║██║░░██║███████║╚█████╗░░░░██║░░░██████╔╝██║░░██║  ██╔████╔██║█████╗░░██║░░██║██║██║░░╚═╝██║░░██║
██║░░██╗██╔══██║██║░░██║██╔══██║░╚═══██╗░░░██║░░░██╔══██╗██║░░██║  ██║╚██╔╝██║██╔══╝░░██║░░██║██║██║░░██╗██║░░██║
╚█████╔╝██║░░██║██████╔╝██║░░██║██████╔╝░░░██║░░░██║░░██║╚█████╔╝  ██║░╚═╝░██║███████╗██████╔╝██║╚█████╔╝╚█████╔╝
░╚════╝░╚═╝░░╚═╝╚═════╝░╚═╝░░╚═╝╚═════╝░░░░╚═╝░░░╚═╝░░╚═╝░╚════╝░  ╚═╝░░░░░╚═╝╚══════╝╚═════╝░╚═╝░╚════╝░░╚════╝░");

            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Cadastre o médico!");
            while (variaveis.continuar.ToLower() == "s")
            {

                Console.WriteLine("\nIdentificador Unico: ");
                id = int.Parse(Console.ReadLine());

                Console.WriteLine("\nNome Completo do(a) Profissional: ");
                nome = Console.ReadLine();

                Console.WriteLine("\nRegistro do Conselho Regional de Medicina(CRM): ");
                crm = Console.ReadLine();

                Console.WriteLine("\nEspecialidade(Ex: Cardiologo,UTI,Cirurgia Geral): ");
                especialidade = Console.ReadLine();

                Console.WriteLine("\nTelefone de Contato Rapido: ");
                fone = Console.ReadLine();

                Console.WriteLine("\n-------------------------------------->");
                Console.WriteLine("\nCadastro Concluido com êxito\nAs Informações Cadastradas foram:");
                Console.WriteLine("\nID: " + id);
                Console.WriteLine("\nNome: " + nome);
                Console.WriteLine("\nCRM: " + crm);
                Console.WriteLine("\nEspecialidade(s): " + especialidade);
                Console.WriteLine("\nMeio de Contato(Fone): " + fone);
                Console.WriteLine("\n-------------------------------------->");
                
                Console.WriteLine("\nDeseja cadastrar outro Médico(s/n)");
                variaveis.continuar = Console.ReadLine();
                Console.Clear();
            }
            Thread.Sleep(1500);


        }
        //3
        static void Funcao_Leito()
        {
            string NumeroQuarto, Tipo;
            bool EstaOcupado;
            int id;



            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(@"
███████╗██╗░░░██╗███╗░░██╗░█████╗░░█████╗░░█████╗░  ██╗░░░░░███████╗██╗████████╗░█████╗░
██╔════╝██║░░░██║████╗░██║██╔══██╗██╔══██╗██╔══██╗  ██║░░░░░██╔════╝██║╚══██╔══╝██╔══██╗
█████╗░░██║░░░██║██╔██╗██║██║░░╚═╝███████║██║░░██║  ██║░░░░░█████╗░░██║░░░██║░░░██║░░██║
██╔══╝░░██║░░░██║██║╚████║██║░░██╗██╔══██║██║░░██║  ██║░░░░░██╔══╝░░██║░░░██║░░░██║░░██║
██║░░░░░╚██████╔╝██║░╚███║╚█████╔╝██║░░██║╚█████╔╝  ███████╗███████╗██║░░░██║░░░╚█████╔╝
╚═╝░░░░░░╚═════╝░╚═╝░░╚══╝░╚════╝░╚═╝░░╚═╝░╚════╝░  ╚══════╝╚══════╝╚═╝░░░╚═╝░░░░╚════╝░");

            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("\nCadastre o leito!");
            while (variaveis.continuar.ToLower() == "s")
            {
                Console.WriteLine("\nNúmero ou identificador do leito: ");
                id = int.Parse(Console.ReadLine());

                Console.WriteLine("\nNúmero ou código do quarto/ala: ");
                NumeroQuarto = Console.ReadLine();

                Console.WriteLine("\nEx: Enfermeira, Apartamento, UTI: ");
                Tipo = Console.ReadLine();

                Console.WriteLine("\nStatus de ocupação (true = Ocupado /false = Livre");
                EstaOcupado = bool.Parse(Console.ReadLine());

                if (EstaOcupado == true)
                {
                    Console.WriteLine("Ocupado!!");
                    variaveis.leito++;
                }
                else
                {
                    Console.WriteLine("Livre!");
                    variaveis.leito--;
                }
                Console.WriteLine("\n-------------------------------------->");
                Console.WriteLine("\nCadastro Concluido com êxito\nAs Informações Cadastradas foram:");
                Console.WriteLine("\nID do leito: " + id);
                Console.WriteLine("\nNúmero/código quarto: " + NumeroQuarto);
                Console.WriteLine("\nDepartamento: " + Tipo);
                Console.WriteLine("\nStatus de ocupação: " + EstaOcupado);
                Console.WriteLine("\n-------------------------------------->");
                Console.WriteLine("\nDeseja cadastrar outro leito ? (s/n)");
                variaveis.continuar = Console.ReadLine();
                Console.Clear();
            }
            Thread.Sleep(2000);
        }



        //4
        static void REGISTRAR_INTERNACAO()

        {

            int id, pacienteld, medicores, leitold;
            DateTime dataentrada, dataalta;
            string diaentrada;

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine(@"
██████╗░███████╗░██████╗░██╗░██████╗████████╗██████╗░░█████╗░██████╗░
██╔══██╗██╔════╝██╔════╝░██║██╔════╝╚══██╔══╝██╔══██╗██╔══██╗██╔══██╗
██████╔╝█████╗░░██║░░██╗░██║╚█████╗░░░░██║░░░██████╔╝███████║██████╔╝
██╔══██╗██╔══╝░░██║░░╚██╗██║░╚═══██╗░░░██║░░░██╔══██╗██╔══██║██╔══██╗
██║░░██║███████╗╚██████╔╝██║██████╔╝░░░██║░░░██║░░██║██║░░██║██║░░██║
╚═╝░░╚═╝╚══════╝░╚═════╝░╚═╝╚═════╝░░░░╚═╝░░░╚═╝░░╚═╝╚═╝░░╚═╝╚═╝░░╚═╝

██╗███╗░░██╗████████╗███████╗███╗░░██╗░█████╗░░█████╗░░█████╗░
██║████╗░██║╚══██╔══╝██╔════╝████╗░██║██╔══██╗██╔══██╗██╔══██╗
██║██╔██╗██║░░░██║░░░█████╗░░██╔██╗██║██║░░╚═╝███████║██║░░██║
██║██║╚████║░░░██║░░░██╔══╝░░██║╚████║██║░░██╗██╔══██║██║░░██║
██║██║░╚███║░░░██║░░░███████╗██║░╚███║╚█████╔╝██║░░██║╚█████╔╝
╚═╝╚═╝░░╚══╝░░░╚═╝░░░╚══════╝╚═╝░░╚══╝░╚════╝░╚═╝░░╚═╝░╚════╝░

░░██╗░█████╗░██████╗░███╗░░░███╗██╗░██████╗░██████╗░█████╗░░█████╗░██╗░░
░██╔╝██╔══██╗██╔══██╗████╗░████║██║██╔════╝██╔════╝██╔══██╗██╔══██╗╚██╗░
██╔╝░███████║██║░░██║██╔████╔██║██║╚█████╗░╚█████╗░███████║██║░░██║░╚██╗
╚██╗░██╔══██║██║░░██║██║╚██╔╝██║██║░╚═══██╗░╚═══██╗██╔══██║██║░░██║░██╔╝
░╚██╗██║░░██║██████╔╝██║░╚═╝░██║██║██████╔╝██████╔╝██║░░██║╚█████╔╝██╔╝░
░░╚═╝╚═╝░░╚═╝╚═════╝░╚═╝░░░░░╚═╝╚═╝╚═════╝░╚═════╝░╚═╝░░╚═╝░╚════╝░╚═╝░░");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Magenta;

            Console.WriteLine("\nIdentificador Unico: ");
            id = int.Parse(Console.ReadLine());

            Console.WriteLine("\nCódigo do Paciente: ");
            pacienteld = int.Parse(Console.ReadLine());

            Console.WriteLine("\nCódigo do Medico Responsavel: ");
            medicores = int.Parse(Console.ReadLine());

            Console.WriteLine("\nCódigo do Leito Alocado: ");
            leitold = int.Parse(Console.ReadLine());

            Console.WriteLine("\nData e hora de Admissão: ");
            dataentrada = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", new System.Globalization.CultureInfo("pt-BR"));

            Console.WriteLine("\nData e Hora da Alta(Nulo Enquanto Internado = 0): ");
            dataalta = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", new System.Globalization.CultureInfo("pt-BR"));

            Console.WriteLine("\nMotivo/quadro na admissão: ");
            diaentrada = Console.ReadLine();

            Console.WriteLine("\nStatus Atual(Internado/Alta/Transferido): ");
            variaveis.status = Console.ReadLine();

            variaveis.nomesPacientes[variaveis.quantidadePacientes] = variaveis.NomePaciente;
            variaveis.CPFsPacientes[variaveis.quantidadePacientes] = variaveis.CPF;
            variaveis.statusPacientes[variaveis.quantidadePacientes] = variaveis.status;

            variaveis.quantidadePacientes++;

            if (variaveis.status.Equals("Alta", StringComparison.OrdinalIgnoreCase))
            {
                variaveis.alta++;
            }

            if (variaveis.status.Equals("Internado", StringComparison.OrdinalIgnoreCase))
            {
                variaveis.internado++;
            }

            if (variaveis.status.Equals("Transferido", StringComparison.OrdinalIgnoreCase))
            {
                variaveis.transferido++;
            }





            Console.WriteLine("\n---------------------------------------->");
            Console.WriteLine("\nCadastro Concluido\nInformações Registradas:");
            Console.WriteLine("\nID; " + id);
            Console.WriteLine("\nCodigo Paciente: " + pacienteld);
            Console.WriteLine("\nCodigo Medico: " + medicores);
            Console.WriteLine("\nCodigo Leito: " + leitold);
            Console.WriteLine("\nData e Hora de Admissão: " + dataentrada);
            Console.WriteLine("\nData e Hora de Alta: " + dataalta);
            Console.WriteLine("\nStatus Atual: " + variaveis.status);
            Console.WriteLine("\n---------------------------------------->");
            Console.WriteLine("\nVOLTANDO AO MENU INICIAL EM 5 SEGUNDOS!");

            Thread.Sleep(5000);

        }

        static void altahospitalar()
        {
            string cpf;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(@"
░█████╗░██╗░░░░░████████╗░█████╗░  ██╗░░██╗░█████╗░░██████╗██████╗░██╗████████╗░█████╗░██╗░░░░░░█████╗░██████╗░
██╔══██╗██║░░░░░╚══██╔══╝██╔══██╗  ██║░░██║██╔══██╗██╔════╝██╔══██╗██║╚══██╔══╝██╔══██╗██║░░░░░██╔══██╗██╔══██╗
███████║██║░░░░░░░░██║░░░███████║  ███████║██║░░██║╚█████╗░██████╔╝██║░░░██║░░░███████║██║░░░░░███████║██████╔╝
██╔══██║██║░░░░░░░░██║░░░██╔══██║  ██╔══██║██║░░██║░╚═══██╗██╔═══╝░██║░░░██║░░░██╔══██║██║░░░░░██╔══██║██╔══██╗
██║░░██║███████╗░░░██║░░░██║░░██║  ██║░░██║╚█████╔╝██████╔╝██║░░░░░██║░░░██║░░░██║░░██║███████╗██║░░██║██║░░██║
╚═╝░░╚═╝╚══════╝░░░╚═╝░░░╚═╝░░╚═╝  ╚═╝░░╚═╝░╚════╝░╚═════╝░╚═╝░░░░░╚═╝░░░╚═╝░░░╚═╝░░╚═╝╚══════╝╚═╝░░╚═╝╚═╝░░╚═╝");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkCyan;

            Console.WriteLine("Nome doPaciente: ");
            variaveis.NomePaciente = Console.ReadLine();

            Console.WriteLine("Digite o CPF do Paciente: ");
            cpf = Console.ReadLine();

            for (int i = 0; i < variaveis.quantidadePacientes; i++)
            {
                if (cpf == variaveis.CPFsPacientes[i])
                {
                    if (variaveis.statusPacientes[i].Equals("Internado", StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine("\nO paciente estava Internado e recebeu alta!");

                        variaveis.statusPacientes[i] = "Alta";

                        variaveis.alta++;
                        variaveis.internado--;
                    }
                }
            
            else if (variaveis.status == "Internado")

            {

                Console.WriteLine("\n O paciente está internado!");

            }

            else if (variaveis.status == "Transferido")

            {

                Console.WriteLine("\n Este paciente foi transferido!");

                variaveis.status = "Transferido";

            }//se nao tiver status que bate com algum aqui no if,nao fuciona.else    {
            else
            {// se o id não tiver certo,nao puxa nada.Console.WriteLine("\nID não encontrado!");
                Console.WriteLine("Status incorreto!");
            }
            Console.WriteLine("\n O paciente " + variaveis.NomePaciente + " está " + variaveis.status);
            Console.WriteLine("\n Deseja consultar outro paciente? (s/n) ");
            variaveis.continuar = Console.ReadLine();
            Thread.Sleep(200);
            Console.Clear();

        }
        
    











        }

    


    }
}
