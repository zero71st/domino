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
 
        private Socket _client = null;

        public Main()
        {
            InitializeComponent();

            tbIPAddress.Text = "192.168.125.201";
     
            tbPort.Text = "502";

            _client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

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

            _client.ReceiveBufferSize = READ_BUFFER_SIZE;

            _client.SendBufferSize = WRITE_BUFFER_SIZE;

            IPEndPoint server = new IPEndPoint(IPAddress.Parse(ip),port);
            
            _client.Connect(server);
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
            if (_client.Connected)
            {
                _client.Close();
            }
        }

        private byte[] Reboot()
        {
            byte[] frame = new byte[10];

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

            frame[37] = 0x31; // First byte vtext content
            frame[38] = 0x32;
            frame[39] = 0x33;
            frame[40] = 0x34;

            frame[41] = 0x35;
            frame[42] = 0x36;
            frame[43] = 0x37; 
            frame[44] = 0x38;

            frame[45] = 0x39;
            frame[46] = 0x30;
            frame[47] = 0x31;
            frame[48] = 0x32;

            frame[49] = 0x33;
            frame[50] = 0x34;
            frame[51] = 0x35;
            frame[52] = 0x36; // End byte vtext content

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
            try
            {
                byte[] frame = LoadMessageForPrinting();
                tbSendMsg.Text = Display(frame);
                SendToServer(frame);
            }
            catch (Exception ex)
            {
                Alert(ex.Message);
            }
        }

        private void btSendVtextData_Click(object sender, EventArgs e)
        {
            SendVtextDataToMessage();
        }

        private int SendToServer(byte[] frame)
        {
            return _client.Send(frame, 0, frame.Length, SocketFlags.None);
        }
        
        private byte[] ReceiveFromServer()
        {
            NetworkStream stream = new NetworkStream(_client);

            if(stream.CanRead)
            {
                int receiveSize = _client.Receive(_bufferReceiver, 0, SocketFlags.None);
                Array.Resize(ref _bufferReceiver, receiveSize);
            }
            return _bufferReceiver;
        }

        private void btReboot_Click(object sender, EventArgs e)
        {
            try
            {
               byte[] frame = Reboot();
               tbSendMsg.Text = Display(frame);
               SendToServer(frame);
               byte[] receiveBuff = ReceiveFromServer();
               tbReceiveMsg.Text = Display(receiveBuff);
            }
            catch (Exception ex)
            {
                Alert(ex.Message);
            }
        }

        private string Display(byte[] data)
        {
            string msg = string.Empty;
            foreach (var item in data)
            {
                msg += String.Format("{0:X2} ", item);
            }

            return msg;
        }

        private void Alert(string msg)
        {
            MessageBox.Show(msg, "Failed", MessageBoxButtons.OK);
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
