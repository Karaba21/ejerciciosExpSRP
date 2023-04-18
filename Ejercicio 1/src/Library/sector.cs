using System;
using System.Collections.Generic;
namespace SRP
{
    public class Sector
    {
    public string LibrarySector { get ; set; }
    public List<Shelf> shelvesList {get; set;}

    public Sector(String sector)
    {
        this.LibrarySector = sector;
        this.shelvesList = new List<Shelf> ();
    }
    
    public void AddShelf(Shelf shelf)
    {
        this.shelvesList.Add(shelf);
    }
    }
    
}