using System;
using System.Collections.Generic;

namespace SRP
{
    public class Shelf
    {
        public string SectorShelf { get ; set; }
        public List<Book> Books { get ; set ;}
        public Shelf(string SectorShelf)
        {
            this.SectorShelf = SectorShelf;
            this.Books = new List<Book>();
        }
        public void ShelveBook(Book book)
        {
            this.Books.Add(book);
        }
    }
}