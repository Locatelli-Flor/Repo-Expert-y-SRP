using System;
using System.Text;

namespace Library
{
    public class ValidarConsulta
    {
        public static bool Validar(Paciente paciente, Doctor doctor,string lugar)
        {
            StringBuilder stringBuilder = new StringBuilder("Scheduling appointment...\n");
            bool isValid = true;

            if (string.IsNullOrEmpty(paciente.Nombre) || (string.IsNullOrEmpty(paciente.Id)) || string.IsNullOrEmpty(paciente.Telefono) || string.IsNullOrEmpty(paciente.Edad))
            {
                stringBuilder.Append("Faltan datos del paciente.");
                isValid = false; 
            }

            if (string.IsNullOrEmpty(lugar))
            {
                stringBuilder.Append("Unable to schedule appointment, 'appoinment place' is required\n");
                isValid = false;
            }


            if (string.IsNullOrEmpty(doctor.Nombre) || string.IsNullOrEmpty(doctor.Especialidad))
            {
                stringBuilder.Append("Faltan datos del doctor.");
                isValid = false;
            }

            Console.WriteLine(stringBuilder.ToString());
            return isValid;
        }
   
    
}


    }
    