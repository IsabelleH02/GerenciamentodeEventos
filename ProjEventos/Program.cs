using Models;
using System;
using System.Collections.Generic;

namespace ProjEventos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcao = 0;
            do
            {
                Console.WriteLine("Menu");

                Console.WriteLine("1 - Cadastrar Cliente");
                Console.WriteLine("2 - Cadastrar Vendedor");
                Console.WriteLine("3 - Cadastrar Tipo");
                Console.WriteLine("4 - Cadastrar Endereco");
                Console.WriteLine("5 - Cadastrar Apresentação");
                Console.WriteLine("6 - Cadastrar Ingresso");
                Console.WriteLine("7 - Cadastrar Evento");
                Console.WriteLine("9 - Sair");

                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        CadastroCliente();
                        break;
                    case 2:
                        CadastroVendedor();
                        break;
                    case 3:
                        CadastroTipo();
                        break;
                    case 4:
                        CadastroEndereco();
                        break;
                    case 5:
                        CadastroApresentacao();
                        break;
                    case 6:
                        CadastroIngresso();
                        break;
                    case 7:
                        CadastroEvento();
                        break;
                    default: Console.WriteLine();
                        break;
                }

            } while (opcao != 9);
           
        }

        private static void CadastroEvento()
        {
            Evento ev = new Evento();

            Console.Write("Id: ");
            ev.Id = int.Parse(Console.ReadLine());

            Console.Write("Nome: ");
            ev.nome = Console.ReadLine();

            Console.Write("Data: ");
            ev.data = DateTime.Parse(Console.ReadLine());

            ev.endereco = new Endereco();
            Console.Write("Id Endereço: ");
            ev.endereco.Id = int.Parse(Console.ReadLine());
            Console.Write("Rua/Av Endereço: ");
            ev.endereco.Logradouro = Console.ReadLine();

            ev.tipo = new Models.Tipo();
            Console.Write("Id Tipo: ");
            ev.tipo.Id = int.Parse(Console.ReadLine());
            Console.Write("Descrição Tipo: ");
            ev.tipo.descricao = Console.ReadLine();

            Console.Write("Capacidade: ");
            ev.capacidade = int.Parse(Console.ReadLine());

            Console.Write("Duração: ");
            ev.duracao = int.Parse(Console.ReadLine());

            Console.Write("Quantidade de Apresentações: ");
            int numberOfApresentation = int.Parse(Console.ReadLine());

            List<Apresentacao> apresentacaos = new List<Apresentacao>();

            for (int i = 0; i < numberOfApresentation; i++)
            {
                Apresentacao a = new Apresentacao();
                Console.Write("Id Apresentação: ");
                a.Id = int.Parse(Console.ReadLine());
                Console.Write("Descrição: ");
                a.descricao = Console.ReadLine();
                apresentacaos.Add(a);
            }

            ev.apresentacao = apresentacaos;

        }

        private static void CadastroIngresso()
        {
            Console.Write("Id Evento para gerar o lote: ");
            int idEvent = int.Parse(Console.ReadLine());
            Console.Write("Qtd de Ingressos");
            int qtdIngresso = int.Parse(Console.ReadLine());

            List<Ingresso> tickets = new List<Ingresso>();

            for (int i = 1; i <= qtdIngresso; i++)
            {
                tickets.Add(new Ingresso() { Id = i, evento = new Evento() { Id = idEvent } });
            }
        }

        private static void CadastroApresentacao()
        {
            Apresentacao ap = new Apresentacao();
            Console.Write("ID: ");
            ap.Id = int.Parse(Console.ReadLine());
            Console.Write("Descricao: ");
            ap.descricao = Console.ReadLine();
            Console.Write("Horario que começa a apresentação");
            ap.hora =  DateTime.Parse(Console.ReadLine());
            Console.Write("Duração total da apresentação: ");
            ap.duracao = int.Parse(Console.ReadLine());

        }

        private static void CadastroEndereco()
        {
            Endereco en = new Endereco();

            Console.Write("ID: ");
            en.Id = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual o CEP");
            en.CEP = Console.ReadLine();
            Console.WriteLine("Qual o Bairro");
            en.Bairro = Console.ReadLine();
            Console.WriteLine("Qual o Logradouro");
            en.Logradouro = Console.ReadLine();
            Console.WriteLine("Qual o numero");
            en.numero = Console.ReadLine();
            Console.WriteLine("Qual o Complemento");
            en.complemento = Console.ReadLine();
        }

        private static void CadastroCliente()
        {
            Cliente cli = new Cliente();

            Console.Write("ID: ");
            cli.Id = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual o nome do Cliente");
            cli.Name = Console.ReadLine();
        }
        private static void CadastroVendedor()
        {
            Vendedor ven = new Vendedor();

            Console.Write("ID: ");
            ven.Id = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual o Nome do vendendor");
             ven.Name = Console.ReadLine();
        }

        private static void CadastroTipo()
        {
            Tipo tp = new Tipo();

            Console.Write("ID: ");
            tp.Id = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual o Tipo do evento");
            tp.descricao = Console.ReadLine();
        }
    }
}
