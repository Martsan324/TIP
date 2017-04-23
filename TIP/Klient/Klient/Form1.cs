using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klient
{
    public partial class Form1 : Form
    {
        private static Socket _clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        public Form1()
        {
            InitializeComponent();
        }

        private void Polacz_Click(object sender, EventArgs e)
        {
            LoopConnect();
        }
        private  void LoopConnect()
        {
           
                try
                {
                    _clientSocket.Connect(IPAddress.Loopback, 100);
                string req = "Ala ma kota";
                byte[] buffer = Encoding.ASCII.GetBytes(req);
                _clientSocket.Send(buffer);
                }
                catch(SocketException)
                {
                    Konsola.Text += "Połączenie nie powiodło sie+ \r\n"; 
                }
                Konsola.Text += "Nawiązano połączenie. \r\n";
            
        }

        private void Konsola_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
