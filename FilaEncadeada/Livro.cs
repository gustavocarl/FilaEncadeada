using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilaEncadeada
{
    internal class Livro
    {
        public int ISBN { get; set; }
        public string Titulo { get; set; }
        public int AnoPublicacao { get; set; }
        public Livro Proximo { get; set; }

        public Livro(int iSBN, string titulo, int anoPublicacao)
        {
            ISBN = iSBN;
            Titulo = titulo;
            AnoPublicacao = anoPublicacao;
            Proximo = null;
        }

        public override string ToString()
        {
            return "Dados do Livro\n" + "ISBN:\t" + ISBN + "\nTitulo:\t" + Titulo + "\nAno de Publicação:\t" + AnoPublicacao + "\n";
        }
    }
}
