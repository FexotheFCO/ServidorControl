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
    }
}
