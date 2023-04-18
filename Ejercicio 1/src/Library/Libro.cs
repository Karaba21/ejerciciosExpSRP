using System;

namespace SRP
{
    public class Book
    {

        public string Title { get ; }
        public string Author { get ; }
        public string Code { get ;  }
        
        public Book(String title, String author, String code)
        {
            this.Title = title;
            this.Author = author;
            this.Code = code;
        }

    }
}
//separamos las clases para que hayan 3 y asi la clase book solo tiene una responsabilidad (que es conocer los datos del libro)
//