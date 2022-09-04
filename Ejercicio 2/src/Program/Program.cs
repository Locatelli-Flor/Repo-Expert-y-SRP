using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Paciente p1 = new Paciente("Steven Jhonson", "986782342", "5555-555-555", "40");
            Doctor d1 = new Doctor("Armand","Cardiólogo");

            Paciente p2 = new Paciente("Ralf Manson", "", "5555-555-555", "");
            Doctor d2 = new Doctor("","Oftalmólogo");
            
            AppointmentService.CreateAppointment(p1,d1, "Wall Street");
            AppointmentService.CreateAppointment(p2,d2,"Queen Street");

        }
    }
}
