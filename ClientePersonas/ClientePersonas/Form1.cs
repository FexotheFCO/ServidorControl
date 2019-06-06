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
        Cliente cliente = new Cliente();
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
            dataGridView1.Rows.Clear();
            foreach(Persona persona in cliente.Personas)
            {
                dataGridView1.Rows.Add(persona.Nombre,persona.Apellido,persona.Sexo);
            }
        }

        private void ButtonRefresh_Click(object sender, EventArgs e)
        {
            actualizarDataGrid();
        }

        private void ButtonRecibir_Click(object sender, EventArgs e)
        {
            cliente.recibirPersona();
        }

        private void ButtonConectarSV_Click(object sender, EventArgs e)
        {
            cliente.conectarConSV();
        }
    }
}
