using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientePersonas
{
    class Cliente
    {
        private List<Persona> personas;

        internal List<Persona> Personas { get => personas; set => personas = value; }

        public void agregarPersona(Persona persona)
        {
            personas.Add(persona);
        }

        public void recibirPersona(String persona)
        {
            String[] personas2;
            personas2 = persona.Split('/');
            agregarPersona(new Persona(personas2[0], personas2[1], personas2[2],Int32.Parse(personas2[3])));
        }
    }
}
