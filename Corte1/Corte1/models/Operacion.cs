using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corte1.models
{
    internal class Operacion
    {
        public int CalcularEdad(Persona persona)
        {
            int yearActual = 2024; 
            int monthActual = 9;  
            int dayActual = 23;     

            int edad = yearActual - persona.FechaDeNacimiento.Year;

            if (persona.FechaDeNacimiento.Month > monthActual ||
                (persona.FechaDeNacimiento.Month == monthActual && persona.FechaDeNacimiento.Day > dayActual))
            {
                edad--;
            }
            return edad;
        }

        public bool EsMayorDeEdad(Persona persona)
        {
            int edad = CalcularEdad(persona);
            return edad >= 18;
        }
    }
}
