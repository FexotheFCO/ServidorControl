using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace ServidorPersonas
{
    public partial class Form1 : Form
    {
        Servidor servidor = new Servidor();
        Control control = new Control();

        public Form1()
        {
            InitializeComponent();
        }

        private void botonIniciarSV_Click(object sender, EventArgs e)
        {
            consola.Text = consola.Text + "Creando Socket";
            servidor.iniciarSv();
            consola.Text = consola.Text + "Socket creado";
            //Form
            botonEncontrarUsuario.Enabled = true;
            botonIniciarSV.Enabled = false;
        }

        private void BotonEncontrarUsuario_Click(object sender, EventArgs e)
        {
            {
                //Se conecta
                consola.Text = consola.Text + "Buscando a Usuario";
                servidor.conectarConUsuario();
                consola.Text = consola.Text + "Conectado con exito";
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BotonEnviar_Click(object sender, EventArgs e)
        {
            servidor.enviarPersona(new Persona("Agustin", "Torchia", "Masculino", 1));
        }

        private void ButtonCrearPersona_Click(object sender, EventArgs e)
        {
            panelCrearUsuario.Visible = true;
        }

        private void ButtonCancelarCrearPersona_Click(object sender, EventArgs e)
        {
            panelCrearUsuario.Visible = false;
            textBoxApellido.Text = "";
            textBoxNombre.Text = "";
            comboBoxSexo.ResetText();
        }

        private void ButtonAgregarPersona_Click(object sender, EventArgs e)
        {
            if(!textBoxNombre.Text.Equals(null) && !textBoxApellido.Text.Equals(null) && !comboBoxSexo.Text.Equals(null))
            {
                control.agregarPersona(new Persona(textBoxNombre.Text, textBoxApellido.Text, comboBoxSexo.Text, 1));
            }
        }
    }
}
