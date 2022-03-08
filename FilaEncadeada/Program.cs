using System;

namespace FilaEncadeada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcao, isbn, anoDePublicacao;//Criação de 3 variáveis do tipo int
            string tituloDoLivro;//Criação de uma variável do tipo string
            Fila_Livro filaDeLivros = new Fila_Livro();//Criação de um objeto do Tipo Fila_Livro

            void menu()
            {
                Console.Clear();
                Console.WriteLine("Por favor selecione uma opção do menu: ");
                Console.WriteLine("1 - Cadastrar Livros\n2 - Remover Livros\n3 - Imprimir toda realação de Livros" +
                    "\n4 - Recuperar a quantidade de livros da pilha\n5 - Buscar um livro por ISBN\n6 - Buscar um livro por título" +
                    "\n7 - Sair");
            }

            void InserirLivro()
            {
                Console.WriteLine("Cadastro de Livros");
                Console.WriteLine("Insira o ISBN do Livro: ");
                isbn = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Insira o título do Livro: ");
                tituloDoLivro = Console.ReadLine();
                Console.WriteLine("Insira o Ano de Publicação do Livro");
                anoDePublicacao = Int32.Parse(Console.ReadLine());
                filaDeLivros.Push(new Livro(isbn, tituloDoLivro, anoDePublicacao));
            }

            void RemoverLivro()
            {
                Console.WriteLine("Removendo um livro da Pilha");
                filaDeLivros.Pop();
                Console.ReadLine();
            }

            void ImprimirLivros()
            {
                Console.WriteLine("Imprimir a relação de Livros Cadastrados");
                filaDeLivros.Print();
                Console.ReadLine();
            }

           void QuantidadeDeLivrosNaPilha()
            {
                Console.WriteLine("Quantidade de Livros na Pilha");
                filaDeLivros.QuantidadeDeLivrosTotal();
                Console.ReadKey();
            }

            do
            {
                menu();
                opcao = Int32.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        InserirLivro();
                        break;
                    case 2:
                        RemoverLivro();
                        break;
                    case 3:
                        ImprimirLivros();
                        break;
                    case 4:
                        QuantidadeDeLivrosNaPilha();
                        break;
                    case 5:
                        filaDeLivros.BuscarISBN();
                        break;
                    case 6:
                        filaDeLivros.BuscarNome();
                        break;
                    case 7:
                        break;
                }
            } while (opcao != 7);
            Console.ReadKey();
        }
    }
}