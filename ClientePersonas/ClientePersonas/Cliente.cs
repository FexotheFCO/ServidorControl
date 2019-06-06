using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientePersonas
{
    class Cliente
    {
        Coneccion coneccion = new Coneccion();
        private List<Persona> personas = new List<Persona>();

        internal List<Persona> Personas { get => personas; set => personas = value; }

        public void agregarPersona(Persona persona)
        {
            personas.Add(persona);
        }

        public void recibirPersona()
        {
            string persona = coneccion.recibirTexto();
            String[] personas2;
            personas2 = persona.Split('|');
            agregarPersona(new Persona(personas2[1], personas2[2], personas2[3],Int32.Parse(personas2[0])));
        }

        public void conectarConSV()
        {
            coneccion.conectarConServidor();
        }
    }
}
