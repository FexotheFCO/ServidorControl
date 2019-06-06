using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ServidorPersonas
{
    class Servidor
    {
        private string ip;
        private int port;
        private string textoRecibido = "";
        private byte[] ByRec;
        Socket socket = null;
        IPEndPoint miDireccion;

        public Servidor()
        {
        }

        public Servidor(string ip, int port, string textoRecibido, string texto, byte[] textoAEnviar, byte[] byRec, Socket socket, IPEndPoint miDireccion)
        {
            this.ip = ip;
            this.port = port;
            this.textoRecibido = textoRecibido;
            ByRec = byRec;
            this.socket = socket;
            this.miDireccion = miDireccion;
        }

        public string Ip { get => ip; set => ip = value; }
        public int Port { get => port; set => port = value; }
        public string TextoRecibido { get => textoRecibido; set => textoRecibido = value; }
        public byte[] ByRec1 { get => ByRec; set => ByRec = value; }
        public Socket Socket { get => socket; set => socket = value; }
        public IPEndPoint MiDireccion { get => miDireccion; set => miDireccion = value; }

        public void iniciarSv()
        {
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            miDireccion = new IPEndPoint(IPAddress.Any, 1234);
        }

        public void conectarConUsuario()
        {
            try
            {
                socket.Bind(miDireccion);
                socket.Listen(1);
                socket = socket.Accept();
            }
            catch (Exception exc)
            {
                Console.WriteLine("ERROR:" + exc.ToString());
            }
        }

        public void enviarPersona(Persona persona)
        {
                string texto = persona.Id + "|" + persona.Nombre + "|" + persona.Apellido + "|" + persona.Sexo;
                byte[] textoEnviar = Encoding.Default.GetBytes(texto);
                socket.Send(textoEnviar, 0, textoEnviar.Length, 0);
        }
    }
}
