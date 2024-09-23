using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corte1.models
{
    internal class Registro
    {
        private Persona[] personas;
        private int i;

        public Registro()
        {
            personas = new Persona[30];
            i = 0;
        }

        public void AgregarPersona(Persona persona)
        {
            if (i < 30)
            {
                personas[i] = persona;
                i++;
            }
            else
            {
                Console.WriteLine("El registro está lleno. No se pueden agregar más personas.");
            }
        }

        public void MostrarPersonas()
        {
            for (int j = 0; j < i; i++)
            {
                Console.WriteLine($"Nombre: {personas[i].Nombres} {personas[i].Apellidos}, Fecha de Nacimiento: {personas[i].FechaDeNacimiento.ToShortDateString()}, Ciudad: {personas[i].Ciudad}");
            }
        }
    }
}
