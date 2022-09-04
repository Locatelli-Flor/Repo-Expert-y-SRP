using System;

namespace Library
{
    public class Consulta
    {
        public int Identificador {get;set;}
        public Doctor Doc {get;set;}
        public Paciente Pac {get;set;}
        public string Lugar {get;set;}
        public int Contador = 0;

        public Consulta(Doctor doctor, Paciente paciente, string lugar)
        {
            this.Doc = doctor;
            this.Pac = paciente;
            this.Lugar = lugar;
            this.Identificador = Contador;
            Contador ++;
        }
    }
}