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
using System.IO;
using System.Threading;
using System.Configuration;


namespace DominoTest
{
    public partial class DominoTest : Form
    {
        private const int READ_BUFFER_SIZE = 2048;

        private const int WRITE_BUFFER_SIZE = 2048;

        private byte[] _bufferReceiver = null;

        private byte[] _bufferSender = null;

        private byte _zeroTeminating = 0x00;
 
        private Socket _client = null;

        public DominoTest()
        {
            InitializeComponent();

            tbIPAddress.Text = System.Configuration.ConfigurationManager.AppSettings["ip"];
            tbPort.Text =  System.Configuration.ConfigurationManager.AppSettings["port"];
            tbMessageName.Text = System.Configuration.ConfigurationManager.AppSettings["msg"];

            Cards = new List<card>();
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
            _client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

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
            frame[5] = 0x0D; // Nr following LSB

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

        private byte[] SendVtextDataToMessage(string vtextName,string vtextData)
        {
            byte[] vname = Encoding.ASCII.GetBytes(vtextName);
            byte[] vdata = Encoding.ASCII.GetBytes(vtextData);

            byte[] vnameBuffer = new byte[20];
            Array.Copy(vname, vnameBuffer, vname.Length);

            int frameMbapSize = 6;

            int frameHeaderSize = 2;

            int frameDataSize = 7 + vnameBuffer.Length + 2 + vdata.Length + 1;

            int frameSize = frameMbapSize + frameHeaderSize + frameDataSize;

            byte[] frame = new byte[frameSize];

            frame[0] = 0x00; // Transaction ID MSB
            frame[1] = 0x00; // Transaction ID LSB

            frame[2] = 0x00; // Protocal ID MSB
            frame[3] = 0x00; // Protocal ID LSB

            frame[4] = 0x00; // Nr following MSB
            frame[5] = Convert.ToByte(frameHeaderSize + frameDataSize); // Nr following LSB - 48 bytes

            frame[6] = 0x01; // Unit Identifier
            frame[7] = 0x65; // Fucntion code

            frame[8] = 0x09; // Set_string
            frame[9] = 0x00; // Status
            frame[10] = 0x00; // Identifier Hi
            frame[11] = 0x00; // Identifier Lo
            frame[12] = 0x01; // Number of string
            frame[13] = 0x03; // Variable Vtext-03
            frame[14] = Convert.ToByte(vnameBuffer.Length + 2 + vdata.Length + 1); // Following bytes 39 bytes

            int j = 14;
            for (int i = 0; i < vnameBuffer.Length; i++)
            {
                j++;
                frame[j] = vnameBuffer[i];
            }

            j++;
            frame[j] = 0x00; // Nr of print MSB
            j++;
            frame[j] = 0x00; // Nr of print LSB

            for (int i = 0; i < vdata.Length; i++)
            {
                j++;
                frame[j] = vdata[i];
            }

            frame[frameSize-1] = _zeroTeminating; // Zero terminating
            return frame;
        }

        private byte[] LoadMessageForPrinter(string msgName)
        {
            byte[] msg = Encoding.ASCII.GetBytes(msgName);

            int frameMbapSize = 6;
            
            int frameHeaderSize = 2;

            int frameDataSize = 8 + msg.Length + 1;

            int frameSize = frameMbapSize+ frameHeaderSize + frameDataSize;

            byte[] frame = new byte[frameSize];

            frame[0] = 0x00; // Transaction ID MSB
            frame[1] = 0x00; // Transaction ID LSB
            frame[2] = 0x00; // Protocal ID MSB
            frame[3] = 0x00; // Protocal ID LSB
            frame[4] = 0x00; // Nr following MSB
            frame[5] = Convert.ToByte(frameHeaderSize+frameDataSize);

            frame[6] = 0x01; // Unit Identifier
            frame[7] = 0x65; // Fucntion code

            frame[8] = 0x09; // Set_string
            frame[9] = 0x00; // Status
            frame[10] = 0x00; // Identifier Hi
            frame[11] = 0x00; // Identifier Lo
            frame[12] = 0x01; // Number of string

            frame[13] = 0x01; // File name - 1
            frame[14] = Convert.ToByte(1 + msg.Length + 1); //Print Group + Msg Name + 1
            frame[15] = 0x01; // Print Group

            int j = 15;
            for (int i = 0; i < msg.Length; i++)
            {
                j++;
                frame[j] = msg[i];
            }

            frame[frameSize-1] = _zeroTeminating; // Zero Teminating

            return frame;
        }


        private void btLoadMessage_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] frame = LoadMessageForPrinter(tbMessageName.Text);

                tbSendMsg.Text = Display(frame);
                SendToServer(frame);
                byte[] receiveBuffer = ReceiveFromServer();
                tbReceiveMsg.Text = Display(receiveBuffer);
            }
            catch (Exception ex)
            {
                Alert(ex.Message);
            }
        }

        private void btSendVtextData_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] frame = SendVtextDataToMessage(tbVtextName.Text, tbVtextData.Text);

                tbSendMsg.Text = Display(frame);
                SendToServer(frame);
                byte[] receiveBuffer = ReceiveFromServer();
                tbReceiveMsg.Text = Display(receiveBuffer);
            }
            catch (Exception ex)
            {
                Alert(ex.Message);
            }
        }

        private int SendToServer(byte[] frame)
        {
            return _client.Send(frame, 0, frame.Length, SocketFlags.None);
        }
        
        private byte[] ReceiveFromServer()
        {
            NetworkStream stream = new NetworkStream(_client);

            byte[] bufferReceiver = null;

            if(stream.CanRead)
            {
                int bufferSize = _client.Receive(_bufferReceiver,_bufferReceiver.Length, SocketFlags.None);
                bufferReceiver = new byte[bufferSize];
                Array.Copy(_bufferReceiver, bufferReceiver, bufferSize);
            }
            return bufferReceiver;
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


        public List<card> Cards { get; set; }

        private void btLoad_Click(object sender, EventArgs e)
        {
            Cards.Clear();
            if(dlgOpen.ShowDialog() ==  System.Windows.Forms.DialogResult.OK)
            {
                List<string> lines = new List<string>(File.ReadAllLines(dlgOpen.FileName));

                var data = lines.Skip(1).ToList();

                int cardPerSheet = 2;

                int totalSheets = (data.Count / cardPerSheet);

            //    int skip = 0;

                for (int i = 0; i < totalSheets; i++)
                {
                    IEnumerable<string> item = data.Skip(i*2).Take(cardPerSheet).ToList();

                    var card = new card
                    {
                        vtext1 = item.First().Substring(0, 15),
                        vtext2 = item.First().Substring(15, 16),
                        vbar1 = item.First().Substring(0, 15),
                        vtext3 = item.Last().Substring(0, 15),
                        vtext4 = item.Last().Substring(15, 16),
                        vbar2 = item.Last().Substring(0,15)
                    };

                 //   skip = skip * 2;
                    Cards.Add(card);
                }

                gvCards.DataSource = Cards.ToList();
            }
        }

        public class card
        {
            public string vtext1 { get; set; }
            public string vtext2 { get; set; }
            public string vbar1 { get; set; }
            public string vtext3 { get; set; }
            public string vtext4 { get; set; }
            public string vbar2 { get; set; }
        }

        private void btRun_Click(object sender, EventArgs e)
        {
            foreach (var card in Cards)
            {
                try
                {
                    int delay = int.Parse(tbDelay.Text);

                    byte[] frame = null;

                    frame = SendVtextDataToMessage("vtext1", card.vtext1);
                    SendToServer(frame);
                    Thread.Sleep(delay);

                    frame = SendVtextDataToMessage("vtext2", card.vtext2);
                    SendToServer(frame);
                    Thread.Sleep(delay);

                    //frame =SendVtextDataToMessage("vbar1", card.vbar1);
                    //SendToServer(frame);
                    ////Thread.Sleep(100);

                    frame = SendVtextDataToMessage("vtext3", card.vtext3);
                    SendToServer(frame);
                    Thread.Sleep(delay);

                    frame = SendVtextDataToMessage("vtext4", card.vtext4);
                    SendToServer(frame);
                    Thread.Sleep(delay);

                    //frame = SendVtextDataToMessage("vbar2", card.vbar2);
                    //SendToServer(frame);
                    ////Thread.Sleep(100);

                }
                catch (Exception ex)
                {
                    Alert("Error" + ex.Message);
                }
            }
            MessageBox.Show("Finished");
        }

        private void btActivateGroup_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] frame = ActivateGroup();
                tbSendMsg.Text = Display(frame);
                SendToServer(frame);
                byte[] receiveBuff = ReceiveFromServer();
                tbReceiveMsg.Text = Display(receiveBuff);
            }
            catch (Exception)
            {
                throw;
            }
        }

        private byte[] ActivateGroup()
        {
            int frameMbapSize = 6;

            int frameHeaderSize = 2;

            int frameDataSize = 11;

            int frameSize = frameMbapSize + frameHeaderSize + frameDataSize;

            byte[] frame = new byte[frameSize];

            frame[0] = 0x00; // Transaction ID MSB
            frame[1] = 0x00; // Transaction ID LSB
            frame[2] = 0x00; // Protocal ID MSB
            frame[3] = 0x00; // Protocal ID LSB
            frame[4] = 0x00; // Nr following MSB
            frame[5] = Convert.ToByte(frameHeaderSize + frameDataSize);

            frame[6] = 0x01; // Unit Identifier
            frame[7] = 0x65; // Fucntion code

            frame[8] = 0x07; // Set_string
            frame[9] = 0x00; // Status
            frame[10] = 0x00; // Identifier Hi
            frame[11] = 0x00; // Identifier Lo
            frame[12] = 0x01; // Quantity of variable 01

            frame[13] = 0x00; // Connection Group 0 = all
            frame[14] = 0x01; // Group1 - 01 ON
            frame[15] = 0xFF; // Group2 - FF Unchanged
            frame[16] = 0xFF; // Group3 - FF Unchanged
            frame[17] = 0xFF; // Group4 - FF Unchanged
            frame[18] = _zeroTeminating;

            return frame;
        }

        private byte[] DeactivateGroup()
        {
            int frameMbapSize = 6;

            int frameHeaderSize = 2;

            int frameDataSize = 11;

            int frameSize = frameMbapSize + frameHeaderSize + frameDataSize;

            byte[] frame = new byte[frameSize];

            frame[0] = 0x00; // Transaction ID MSB
            frame[1] = 0x00; // Transaction ID LSB
            frame[2] = 0x00; // Protocal ID MSB
            frame[3] = 0x00; // Protocal ID LSB
            frame[4] = 0x00; // Nr following MSB
            frame[5] = Convert.ToByte(frameHeaderSize + frameDataSize);

            frame[6] = 0x01; // Unit Identifier
            frame[7] = 0x65; // Fucntion code

            frame[8] = 0x07; // Set_string
            frame[9] = 0x00; // Status
            frame[10] = 0x00; // Identifier Hi
            frame[11] = 0x00; // Identifier Lo
            frame[12] = 0x01; // Quantity of variable 01

            frame[13] = 0x00; // Connection Group 0 = all
            frame[14] = 0xFF; // Group1 - FF Unchanged
            frame[15] = 0xFF; // Group2 - FF Unchanged
            frame[16] = 0xFF; // Group3 - FF Unchanged
            frame[17] = 0xFF; // Group4 - FF Unchanged
            frame[18] = _zeroTeminating;

            return frame;
        }

        private void btDeactivateGroup_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] frame = DeactivateGroup();
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

        private void btReadFwVersion_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] frame = ReadFirmwareVersion();
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

        private byte[] ReadFirmwareVersion()
        {
            int frameMbapSize = 6;

            int frameHeaderSize = 2;

            int frameDataSize = 5;

            int frameSize = frameMbapSize + frameHeaderSize + frameDataSize;

            byte[] frame = new byte[frameSize];

            frame[0] = 0x00; // Transaction ID MSB
            frame[1] = 0x00; // Transaction ID LSB
            frame[2] = 0x00; // Protocal ID MSB
            frame[3] = 0x00; // Protocal ID LSB
            frame[4] = 0x00; // Nr following MSB
            frame[5] = Convert.ToByte(frameHeaderSize + frameDataSize);

            frame[6] = 0x01; // Unit Identifier
            frame[7] = 0x04; // Fucntion code

            frame[8] = 0x00; // Set_string
            frame[9] = 0x1E; // Status
            frame[10] = 0x00; // Identifier Hi
            frame[11] = 0x10; // Identifier Lo
            frame[frameSize-1] = _zeroTeminating;

            return frame;
        }
    }
}
