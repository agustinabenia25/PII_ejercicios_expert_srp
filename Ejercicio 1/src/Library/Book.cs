using System;
using System.Collections.Generic;

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
/*
    Como estaba, el codigo no cumplia con el principio EXPERT.
    La clase Book no tiene necesidad de saber donde se guardan los libros.
    Solo necesita saber las caracteristicas de cada libro.
*/