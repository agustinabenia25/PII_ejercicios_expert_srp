using System;
using System.Collections.Generic;

namespace SRP
{
    public class Shelf
    {
        // Cada Shelf tiene dos atributos: su nombre y su lista de libros que contiene.
        public string ShelfName { get ; set; }
        public List<Book> Books { get ; set ;}
        // Método constructor de la clase Shelf. Para crear cada instancia tengo que asignarle un nombre.
        public Shelf(string SectorShelf)
        {
            this.ShelfName = SectorShelf;
            this.Books = new List<Book>();
        }
        // Método que se encarga de agregar libros a una Shelf.
        public void ShelveBook(Book book)
        {
            this.Books.Add(book);
        }
    }
}