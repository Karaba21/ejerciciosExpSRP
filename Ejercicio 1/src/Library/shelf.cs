using System;
using System.Collections.Generic;
using SRP;

namespace SRP
{
    public class Shelf
    {
    public string LibraryShelf { get ; set; }
    public List<Book> listaLibros { get ; set ; }  

    public Shelf(String shelf)
    {
        this.LibraryShelf = shelf;
        this.listaLibros = new List<Book>(); 
    }

    public void AgregarLibro(Book book) //tipo de lo que agrego primero, y segundo el nombre que le doy a cada coso
    {
        this.listaLibros.Add(book);
    }
    }
    
}