

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServidorPersonas
{
    class Control
    {
        private List<Persona> personas;

        public void agregarPersona(Persona persona)
        {
            personas.Add(persona);
        }

        public Persona devolverPersona(int id)
        {
            foreach(Persona persona in personas)
            {
                if(persona.Id == id)
                {
                    return persona;
                    break;
                }
            }
            return null;
        }

    }
}
