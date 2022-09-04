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
        /* Esta clase no sigue el srp ya que la clase Book tiene dos responsabilidades: El identificador de cada objeto Libro y 
        su lugar en una estantería. La estantería (ShelveBook) debería ser una clase a parte. */
    }
}
