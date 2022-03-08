using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilaEncadeada
{
    internal class Fila_Livro
    {
        public Livro Head { get; set; }
        public Livro Tail { get; set; }
        int contadorDeLivros = 0;

        public Fila_Livro()
        {
            Head = Tail = null;//Indica que Head e Tail receberão o mesmo valor
        }

        public void Push(Livro aux)
        {
            if (Vazia())
            {
                Head = Tail = aux;
                contadorDeLivros++;
            }
            else
            {
                Tail.Proximo = aux;
                Tail = aux;
                contadorDeLivros++;
            }
        }

        public void Pop()
        {
            if (Vazia())
            {
                Console.WriteLine("Não contém livros nessa pilha");
            }
            else
            {
                Head = Head.Proximo;
                if(Head == null)
                {
                    Tail = null;
                }
                contadorDeLivros--; 
            }
        }

        public void QuantidadeDeLivrosTotal()
        {
            Console.WriteLine("O total de livros é: " + contadorDeLivros);
        }

        public void Print()
        {
            if (Vazia())
            {
                Console.WriteLine("Não contém livros nessa fila");
                Console.ReadKey();
            }
            else
            {
                Livro aux = Head;
                do
                {
                    Console.WriteLine("Os livros que estão na pilha são: ");
                    Console.WriteLine(aux.ToString());
                    Console.ReadKey();
                    aux = aux.Proximo;
                } while (aux != null);
            }
        }

        public void BuscarISBN()
        {
            if (Vazia())
            {
                Console.WriteLine("Nenhum livro para busca");
                Console.ReadLine();
            }
            else
            {
                Livro aux = Head;
                Console.WriteLine("Infome o ISBN do livro para pesquisar: ");
                int buscarISBN = Int32.Parse(Console.ReadLine());
                do
                {
                    if (buscarISBN == aux.ISBN)
                    {
                        Console.WriteLine("---------------------------------------");
                        Console.WriteLine("\n" + aux.ToString());
                        Console.WriteLine("---------------------------------------");
                        Console.ReadLine();
                    }
                    aux = aux.Proximo;
                }while (aux != null);
            }
        }

        public void BuscarNome()
        {
            if (Vazia())
            {
                Console.WriteLine("Nenhum livro para busca");
                Console.ReadLine();
            }
            else
            {
                Livro aux = Head;
                Console.WriteLine("Informe o nome do livro para pesquisar: ");
                string buscarLivro = Console.ReadLine();
                do
                {
                    if (buscarLivro == aux.Titulo)
                    {
                        Console.WriteLine("---------------------------------------");
                        Console.WriteLine("\n" + aux.ToString());
                        Console.WriteLine("---------------------------------------");
                        Console.ReadLine();
                    }
                    aux = aux.Proximo;
                } while(aux != null);
            }
        }

            public bool Vazia()
        {
            if ( (Head == null) && (Tail == null) )
                return true;
            else
                return false;
        }
    }
}
