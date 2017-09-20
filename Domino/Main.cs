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

namespace Domino
{
    public partial class Main : Form
    {
        private const int READ_BUFFER_SIZE = 2048;

        private const int WRITE_BUFFER_SIZE = 2048;

        private byte[] _bufferReceiver = null;

        private byte[] _bufferSender = null;
 
        private Socket _socket = null;

        public Main()
        {
            InitializeComponent();

            tbIPAddress.Text = "192.168.125.201";
     
            tbPort.Text = "502";

            _socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

        }

        private void btConnect_Click(object sender, EventArgs e)
        {
            try
            {
                Connect(tbIPAddress.Text,int.Parse(tbPort.Text));
                btConnect.Enabled = false;
                btDisconnect.Enabled = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Can not connect to IP:"+tbIPAddress.Text);
            }
        }

        private void Connect(string ip,int port)
        {
            _bufferReceiver = new byte[READ_BUFFER_SIZE];
            
            _bufferSender = new byte[WRITE_BUFFER_SIZE];

            _socket.ReceiveBufferSize = READ_BUFFER_SIZE;

            _socket.SendBufferSize = WRITE_BUFFER_SIZE;

            IPEndPoint server = new IPEndPoint(IPAddress.Parse(ip),port);
            
            _socket.Connect(server);
        }

        private void btDisconnect_Click(object sender, EventArgs e)
        {
            try
            {
                Disconnect();
                btConnect.Enabled = true;
                btDisconnect.Enabled = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Can not disconnect");
            }
        }

        private void Disconnect()
        {
            if (_socket.Connected)
            {
                _socket.Close();
            }
        }

        private void btPrint_Click(object sender, EventArgs e)
        {
            byte slaveAddress = 1;
            byte function = 9;
            ushort id = function;


        }

        private byte[] SendVtextToMessage()
        {
            byte[] frame = new byte[46];

            frame[0] = 0x00;
            frame[1] = 0x00;
            frame[2];
            frame[3];
            frame[4];
            frame[5];
            frame[6];
            frame[7];
            frame[8];
            frame[9];
            frame[10];
            frame[11];
            frame[12];
            frame[13];
            frame[14];
            frame[15];
            frame[16];
            frame[17];
            frame[18];
            frame[19];
            frame[20];
            frame[21];
            frame[22];
            frame[23];
            frame[24];
            frame[25];
            frame[26];
            frame[27];
            frame[28];
            frame[29];
            frame[30];
            frame[31];
            frame[32];
            frame[33];
            frame[34];
            frame[35];
            frame[36];
            frame[37];
            frame[38];
            frame[39];
            frame[40];
            frame[41];
            frame[42];
            frame[43];
            frame[44];
            frame[45];
            return frame;
        }

    }
}
