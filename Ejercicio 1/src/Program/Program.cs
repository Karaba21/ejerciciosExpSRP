using System;

namespace SRP
{

    class Program
    {
        static void Main()
        {
            Book book1 = new Book("Design Patterns","Erich Gamma & Others","001-034");
            Book book2 = new Book("Pro C#","Troelsen","001-035");

            Shelf shelf1 = new Shelf ("1");
            Shelf shelf2 = new Shelf ("2");
            Shelf shelf3 = new Shelf ("3");

            Sector IT = new Sector ("IT");
            Sector Design = new Sector("Design");

            IT.AddShelf(shelf1);
            shelf1.AgregarLibro (book1);

            Console.WriteLine($"the book {book1.Title} by {book1.Author} is in the shelf {shelf1.LibraryShelf}");
            

        }
    }
}