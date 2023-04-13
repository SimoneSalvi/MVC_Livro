using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Controllers
{
    public class ShelfController
    {
        
        public Shelf InsertBookShelf(Shelf s, Book b)
        {
            s.books.Add(b);
            return s;
        }

        public void PrintShelf(Shelf s)
        {
            Console.WriteLine(">>> Lista de Livros <<<");
            Console.WriteLine();

            foreach (var item in s.books)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
