using System;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace Domino.TCP
{
    public class Server
    {
        public string  IP { get; private set; }
        public int Port { get; private set; }

        private Socket _client;
        
        public Server(string ipAddress,int port)
        {
            IP = ipAddress;
            Port = port;
        }

        public void Connect()
        {
            try
            {
                
                var server = new IPEndPoint(IPAddress.Parse(IP), Port);
                _client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                _client.Connect(server);
            }
            catch (Exception ex)
            {
                throw new Exception("Can not connect to domino IP: "+ex.Message);
            }
        }

        private byte[] GetRebootFrame()
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

        private  byte[] Response()
        {
            NetworkStream stream = new NetworkStream(_client);

            byte[] receiveBuffer = new byte[2048];

            int result  = _client.Receive(receiveBuffer, receiveBuffer.Length, SocketFlags.None);

            Array.Resize(ref receiveBuffer,result);

            return receiveBuffer;
        }

        private byte[] Reboot()
        {
            try
            {
                byte[] frame = GetRebootFrame();

                int result = _client.Send(frame);

                return Response();
            }
            catch (Exception ex)
            {
                throw new Exception("Can not reboot "+ex.Message);
            }
        }

        public void Disconnect()
        {
            if (_client == null)
                return;
            if (_client.Connected)
                 _client.Close();
        }
    }
}
