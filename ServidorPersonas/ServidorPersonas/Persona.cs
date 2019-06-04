using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServidorPersonas
{
    class Persona
    {
        private int id;
        private string nombre;
        private string apellido;
        private string sexo;

        public Persona(string nombre, string apellido, string sexo, int id)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.sexo = sexo;
            this.id = id;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        public int Id { get => id; set => id = value; }
    }
}
