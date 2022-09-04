using System;

namespace Library
{
    public class Paciente
    {
        public string Nombre {get;set;}
        public string Id {get;set;}
        public string Telefono {get;set;}
        public string Edad {get;set;}

        public Paciente(String nombre, String id, String telefono, String edad)
        {
            this.Nombre = nombre;
            this.Id = id;
            this.Telefono = telefono;
            this.Edad = edad;
        
        }
    
    }
    
}