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

namespace Serwer
{
    public partial class Form1 : Form
    {
        private static byte[] _buffer = new byte[1024];
        private static List<Socket> _clientSocket = new List<Socket>();
        private static Socket _serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        public Form1()
        {

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           // textBox1.Text += "Uruchamiam Serwer....\r\n";
            _serverSocket.Bind(new IPEndPoint(IPAddress.Any, 100));
            _serverSocket.Listen(1);
            _serverSocket.BeginAccept(new AsyncCallback(AcceptCollBack), null);
            //  textBox1.Text += "Serwer uruchomiony\r\nNasłuch na porcie nr 100.\r\n";
          


        }


        private static void AcceptCollBack(IAsyncResult AR) //static
        {
            Socket socket = _serverSocket.EndAccept(AR);
            _clientSocket.Add(socket);
           // textBox1.Text += "Podpięcie klienta\r\n";
            socket.BeginReceive(_buffer,0,_buffer.Length, SocketFlags.None, new AsyncCallback(ReceiveCallback),socket);
            _serverSocket.BeginAccept(new AsyncCallback(AcceptCollBack), null);
        }
        private static void ReceiveCallback(IAsyncResult AR) //static
        {
            Socket socket = (Socket)AR.AsyncState;
            int received = socket.EndReceive(AR);
            byte[] dataBuf = new byte[received];
            Array.Copy(_buffer, dataBuf, received);

            string text = Encoding.ASCII.GetString(dataBuf);
            //textBox1.Text += "odebrana wiadomość: " + text + "\r\n";

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bt_Transakcje_Click(object sender, EventArgs e)
        {

        }

        private void bt_SG_Click(object sender, EventArgs e)
        {
            if (!panel4.Controls.Contains(Ustawienia.Instance))
            {
                panel4.Controls.Add(Ustawienia.Instance);
                Ustawienia.Instance.Dock = DockStyle.Fill;
                Ustawienia.Instance.Dispose();

            }
            else
            {
                Ustawienia.Instance.Dispose();

            }
        }

        private void bt_Ustawienia_Click(object sender, EventArgs e)
        {
            if (!panel4.Controls.Contains(Ustawienia.Instance))
            {
                panel4.Controls.Add(Ustawienia.Instance);
                Ustawienia.Instance.Dock = DockStyle.Fill;
                Ustawienia.Instance.BringToFront();

            }
            else
            {
                Ustawienia.Instance.BringToFront();

            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

      
    }
}
