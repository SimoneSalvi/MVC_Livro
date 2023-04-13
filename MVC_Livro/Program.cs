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
            }
        } while (op != 0);
    }

    private static int Menu()
    {
        int op = 0;
        Console.WriteLine("Selecione a opção:" +
                          "\n[1] Inserir novo livro na estante" +
                          "\n[2] Visualizar todos os livros da estante" +
                          "\n[0] Sair");
        op = int.Parse(Console.ReadLine());
        return op;
    }
}