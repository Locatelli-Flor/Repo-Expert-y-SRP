using System;
using System.Text;

namespace Library
{
    public class AppointmentService
    {
        public static bool CreateAppointment(Paciente paciente, Doctor doctor, string lugar)
        {
            bool validar = ValidarConsulta.Validar(paciente,doctor,lugar);

            if (validar)
            {
                Console.WriteLine("Consulta creada con éxito.");
                return true;
            }
            else
            {
                Console.WriteLine("La consulta no pudo ser creada.");
                return false;
            }
        }
        /* La clase AppointmentService tiene 2 responsabilidades: crear la consula y validar los datos. Entonces, para cumplir con CRC
        se deberían crear 4 clases separadas: una que valida los datos, otra que crea una consulta si los datos son válidos, una clase
        doctor para poder ingresar los datos de cada doctor y una clase paciente para ingresar datos de cada paciente. 
        Link a las tarjetas crc: https://echeung.me/crcmaker/?share=W3sibmFtZSI6IlBhY2llbnRlIiwic3VwZXJjbGFzc2VzIjoiIiwic3ViY2xhc3NlcyI6IiIsInR5cGUiOjEsInJlc3BvbnNpYmlsaXRpZXMiOlsiQ29ub2NlciBsYSBpbmZvcm1hY2nzbiBkZWwgcGFjaWVudGUiXSwiY29sbGFib3JhdG9ycyI6WyIiXX0seyJuYW1lIjoiRG9jdG9yIiwic3VwZXJjbGFzc2VzIjoiIiwic3ViY2xhc3NlcyI6IiIsInR5cGUiOjEsInJlc3BvbnNpYmlsaXRpZXMiOlsiQ29ub2NlciBsYSBpbmZvcm1hY2nzbiBkZWwgZG9jdG9yIl0sImNvbGxhYm9yYXRvcnMiOlsiIl19LHsibmFtZSI6IlZhbGlkYXJDb25zdWx0YSIsInN1cGVyY2xhc3NlcyI6IiIsInN1YmNsYXNzZXMiOiIiLCJ0eXBlIjoxLCJyZXNwb25zaWJpbGl0aWVzIjpbIlZhbGlkYXIgZGF0b3MgZGFkb3MgcG9yIGxhcyBjbGFzZXMgcGFjaWVudGUgeSBkb2N0b3IiLCJSZXRvcm5hciwgZW4gY2FzbyBkZSBxdWUgbG9zIGhheWEsIGRhdG9zIGZhbHRhbnRlcyJdLCJjb2xsYWJvcmF0b3JzIjpbIlBhY2llbnRlIiwiRG9jdG9yIl19LHsibmFtZSI6IkFwcG9pbnRtZW50IHNlcnZpY2UiLCJzdXBlcmNsYXNzZXMiOiIiLCJzdWJjbGFzc2VzIjoiIiwidHlwZSI6MSwicmVzcG9uc2liaWxpdGllcyI6WyJDcmVhciBsYSBjb25zdWx0YSBzaSBsb3MgZGF0b3Mgc29uIHbhbGlkb3MiXSwiY29sbGFib3JhdG9ycyI6WyJWYWxpZGFyQ29uc3VsdGEiXX1d*/


    }
}
