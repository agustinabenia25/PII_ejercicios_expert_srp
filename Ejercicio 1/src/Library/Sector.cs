using System;
using System.Collections.Generic;

namespace SRP
{
    public class Sector
    {
        public string LibrarySector { get ; set; }
        public List<Shelf> Shelves { get ; set ;}

        public Sector(string LibrarySector)
        {
            this.LibrarySector = LibrarySector;
            this.Shelves = new List<Shelf>();     
        }
        public void SectorShelf(Shelf shelf)
        {
            this.Shelves.Add(shelf);
        }
    }
}