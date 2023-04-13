using System.Collections.Generic;
using System.ComponentModel.Design;
using Controllers;
using Models;

internal class Program
{
    private static void Main(string[] args)
    {

        ShelfController shelfController = new ShelfController();
        BookController bookController = new BookController();
        Shelf s = new();
        Book book = new Book();


        int op = 0;
        do
        {
            op = Menu();
            switch (op)
            {
                case 0:
                    op = op;
                    Console.WriteLine("Saindo..");
                    break;
                case 1:
                    Console.WriteLine("Informe o nome do Livro:");
                    string l = Console.ReadLine();

                    Console.WriteLine("Informe o autor do Livro:");
                    string a = Console.ReadLine();

                    Book b = bookController.CreateBook(l, a);
                    s = shelfController.InsertBookShelf(s, b);
                    Console.WriteLine("Livro cadastrado com sucesso!");
                    break;
                case 2:
                    shelfController.PrintShelf(s);
                    break;
                case 3:
                    FindByName(shelfController, s);
                    break;
            }
        } while (op != 0);
    }

    private static void FindByName(ShelfController shelfController, Shelf s)
    {
        Book book = new Book();
        Console.WriteLine("Qual o nome do Livro?");
        string n = Console.ReadLine();

        book = shelfController.GetBook(n, s);

        if (book != null)
        {
            Console.WriteLine(book.ToString());
        }
        else
        {
            Console.WriteLine("O livro não existe!");
        }
    }

    private static int Menu()
    {
        int op = 0;
        Console.WriteLine("Selecione a opção:" +
                          "\n[1] Inserir novo livro na estante" +
                          "\n[2] Visualizar todos os livros da estante" +
                          "\n[3] Buscar por título" +
                          "\n[0] Sair");
        op = int.Parse(Console.ReadLine());
        return op;
    }
}