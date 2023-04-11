using System;
using System.Collections.Generic;

namespace SRP
{

    class Program
    {
        static void Main()
        {
            Sector sector1 = new Sector("Perro");
            Sector sector2 = new Sector("pinguino");

            Shelf shelf1 = new Shelf("A");
            Shelf shelf2 = new Shelf("B");
            Shelf shelf3 = new Shelf("A");
            Shelf shelf4 = new Shelf("B");

            sector1.SectorShelf(shelf1);
            sector1.SectorShelf(shelf2);

            sector2.SectorShelf(shelf3);
            sector2.SectorShelf(shelf4);

            Book book1 = new Book("Design Patterns","Erich Gamma & Others","001-034");
            Book book2 = new Book("Pro C#","Troelsen","001-035");
            Book book3 = new Book("Percy Jackson", "Rick Riordan", "123-456");
            Book book4 = new Book("Throne of Glass", "Sarah J Maas", "654.321");

            shelf1.ShelveBook(book1);
            shelf2.ShelveBook(book2);
            shelf3.ShelveBook(book3);
            shelf1.ShelveBook(book4);

            Console.WriteLine(sector2.Shelves.ToArray()[0].Books.ToArray()[0].Title);
        }
    }
}