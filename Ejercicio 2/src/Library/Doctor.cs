using System;

namespace Library
{
    public class Doctor
    {
        public string Nombre {get;set;}
        public string Especialidad {get;set;}

        public Doctor(String nombre, String especialidad)
        {
            this.Nombre = nombre;
            this.Especialidad = especialidad;
        
        }
    
    }
    
}