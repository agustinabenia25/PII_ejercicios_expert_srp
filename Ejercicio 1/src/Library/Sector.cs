using System;
using System.Collections.Generic;

namespace SRP
{
    public class Sector
    {
        // Cada Sector tiene dos atributos: su nombre y su lista de shelves que contiene.
        public string LibrarySector { get ; set; }
        public List<Shelf> Shelves { get ; set ;}
        // Método constructor de la clase Sector. Para crear cada instancia tengo que asignarle un nombre.
        public Sector(string LibrarySector)
        {
            this.LibrarySector = LibrarySector;
            this.Shelves = new List<Shelf>();     
        }
        // Método que se encarga de agregar shelves a un Sector.
        public void SectorShelf(Shelf shelf)
        {
            this.Shelves.Add(shelf);
        }
    }
}