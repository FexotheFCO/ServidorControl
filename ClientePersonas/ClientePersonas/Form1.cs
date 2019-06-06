using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientePersonas
{
    public partial class Form1 : Form
    {
        Cliente cliente;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            actualizarDataGrid();
        }

        private void actualizarDataGrid()
        {
            foreach(Persona persona in cliente.Personas)
            {
                dataGridView1.Rows.Add(persona.Nombre,persona.Apellido,persona.Sexo);
            }
        }
    }
}
