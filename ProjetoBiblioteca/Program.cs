using System;
using System.Collections.Generic;

namespace ProjetoBibliotecaTDE
{
    public class Livro
    {
        private string titulo;
        private string autor;
        private int anoPublicacao;

        public Livro(string titulo, string autor, int ano)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.anoPublicacao = ano;
        }

        public string GetTitulo()
        {
            return this.titulo;
        }

        public void ExibirInfo()
        {
            Console.WriteLine($"  - Título: {this.titulo}, Autor: {this.autor}, Ano: {this.anoPublicacao}");
        }
    }

    public class Biblioteca
    {
        private List<Livro> acervoDeLivros;
        public string NomeDaBiblioteca;

        public Biblioteca(string nome)
        {
            this.NomeDaBiblioteca = nome;
            this.acervoDeLivros = new List<Livro>();
            Console.WriteLine($"--- Bem-vindo ao sistema da {this.NomeDaBiblioteca}! ---");
            Console.WriteLine("-----------------------------------------------------");
        }

        public void CadastrarLivro(Livro livroParaAdicionar)
        {
            this.acervoDeLivros.Add(livroParaAdicionar);
            Console.WriteLine($"O livro \"{livroParaAdicionar.GetTitulo()}\" foi cadastrado com sucesso!\n");
        }

        public void ListarLivros()
        {
            Console.WriteLine("\n--- Livros atualmente no acervo: ---");

            if (acervoDeLivros.Count == 0)
            {
                Console.WriteLine("  Nenhum livro foi cadastrado ainda.");
                return;
            }

            foreach (var livro in acervoDeLivros)
            {
                livro.ExibirInfo();
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Biblioteca minhaBiblioteca = new Biblioteca("UNIFACEMA");

            while (true)
            {
                Console.WriteLine("\n--- Cadastro de Novo Livro ---");

                Console.Write("Digite o título do livro: ");
                string titulo = Console.ReadLine();

                Console.Write("Digite o autor do livro: ");
                string autor = Console.ReadLine();

                Console.Write("Digite o ano de publicação: ");
                if (!int.TryParse(Console.ReadLine(), out int ano))
                {
                    Console.WriteLine("Ano inválido. Por favor, insira um número.");
                    continue; 
                }

                Livro novoLivro = new Livro(titulo, autor, ano);

               
                minhaBiblioteca.CadastrarLivro(novoLivro);

                Console.Write("Deseja cadastrar outro livro? (s/n): ");
                string continuar = Console.ReadLine();

                
                if (continuar.ToLower() != "s")
                {
                    break; 
                }
            }

            minhaBiblioteca.ListarLivros();


            Console.WriteLine("\n\nExecução finalizada. Pressione qualquer tecla para fechar...");
            Console.ReadKey();
        }
    }
}