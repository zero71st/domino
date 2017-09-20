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

        private byte[] Reboot()
        {
            byte[] frame = new byte[9];

            frame[0] = 0x00; // Transaction ID MSB
            frame[1] = 0x00; // Transaction ID LSB

            frame[2] = 0x00; // Protocal ID MSB
            frame[3] = 0x00; // Protocal ID LSB

            frame[4] = 0x00; // Nr following MSB
            frame[5] = 0x04; // Nr following LSB

            frame[6] = 0x01; // Unit Identifier
            frame[7] = 0x65; // Fucntion code
            frame[8] = 0x0A; // Reboot
            frame[9] = 0x00; // Zero Teminating

            return frame;
        }

        private byte[] SendVtextDataToMessage()
        {
            byte[] frame = new byte[54];

            frame[0] = 0x00; // Transaction ID MSB
            frame[1] = 0x00; // Transaction ID LSB

            frame[2] = 0x00; // Protocal ID MSB
            frame[3] = 0x00; // Protocal ID LSB

            frame[4] = 0x00; // Nr following MSB
            frame[5] = 0x30; // Nr following LSB - 48 bytes

            frame[6] = 0x01; // Unit Identifier
            frame[7] = 0x65; // Fucntion code
            frame[8] = 0x09; // Set_string
            frame[9] = 0x00; // Status

            frame[10] = 0x00; // Identifier Hi
            frame[11] = 0x00; // Identifier Lo
            frame[12] = 0x01; // Number of string

            frame[13] = 0x03; // Variable Vtext-03
            //frame[14] = 0x1E; // Following bytes 30 bytes
            frame[14] = 0x27; // Following bytes 39 bytes

            frame[15] = 0x50; // P - First byte for Vtext Name (20 bytes)
            frame[16] = 0x49; // I 
            frame[17] = 0x4E; // N
            frame[18] = 0x31; // 1
            frame[19] = 0x00;
            frame[20] = 0x00;
            frame[21] = 0x00;
            frame[22] = 0x00;
            frame[23] = 0x00;
            frame[24] = 0x00;
            frame[25] = 0x00;
            frame[26] = 0x00;
            frame[27] = 0x00;
            frame[28] = 0x00;
            frame[29] = 0x00;
            frame[30] = 0x00;
            frame[31] = 0x00;
            frame[32] = 0x00;
            frame[33] = 0x00;
            frame[34] = 0x00; // End tyte for Vtext Name

            frame[35] = 0x00; // Nr of print MSB
            frame[36] = 0x00; // Nr of print LSB

            frame[37] = 0x01; // First byte vtext content
            frame[38] = 0x02;
            frame[39] = 0x03;
            frame[40] = 0x04;

            frame[41] = 0x05;
            frame[42] = 0x06;
            frame[43] = 0x07; 
            frame[44] = 0x08;

            frame[45] = 0x09;
            frame[46] = 0x00;
            frame[47] = 0x01;
            frame[48] = 0x02;

            frame[49] = 0x03;
            frame[50] = 0x04;
            frame[51] = 0x05;
            frame[52] = 0x06; // End byte vtext content

            frame[53] = 0x00; // Zero terminating
            return frame;
        }

        private byte[] LoadMessageForPrinting()
        {
            byte[] frame = new byte[19];

            frame[0] = 0x00; // Transaction ID MSB
            frame[1] = 0x00; // Transaction ID LSB

            frame[2] = 0x00; // Protocal ID MSB
            frame[3] = 0x00; // Protocal ID LSB

            frame[4] = 0x00; // Nr following MSB
            frame[5] = 0x10; // Nr following LSB

            frame[6] = 0x01; // Unit Identifier
            frame[7] = 0x65; // Fucntion code
            frame[8] = 0x09; // Set_string
            frame[9] = 0x00; // Status

            frame[10] = 0x00; // Identifier Hi
            frame[11] = 0x00; // Identifier Lo
            frame[12] = 0x01; // Number of string

            frame[13] = 0x01; // File name
            frame[14] = 0x04; // Following bytes
            frame[15] = 0x01; // Print Group

            frame[16] = 0x64; // d
            frame[17] = 0x7A; // z

            frame[18] = 0x00; // Zero Teminating

            return frame;
        }

        private void btLoadMessage_Click(object sender, EventArgs e)
        {
            LoadMessageForPrinting();
        }

        private void btSendVtextData_Click(object sender, EventArgs e)
        {
            SendVtextDataToMessage();
        }

        private void btReboot_Click(object sender, EventArgs e)
        {
            Reboot();
        }
    }
}
