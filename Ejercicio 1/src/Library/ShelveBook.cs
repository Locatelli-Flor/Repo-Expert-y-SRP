using System;
using System.Collections.Generic;

namespace SRP
{
    public class ShelveBook
    {
    
        public static List<Object> Estanteria = new List<Object>();
        public string LibrarySector { get ; set; }
        public string LibraryShelve { get ; set; }

        public ShelveBook(String sector, String shelve)
        {
            this.LibrarySector = sector;
            this.LibraryShelve = shelve;
        }
        public static void AsignarLugar(Book libro, String sector, String shelve)
        {
            Estanteria.Add((libro,sector,shelve));
        }

    }

}