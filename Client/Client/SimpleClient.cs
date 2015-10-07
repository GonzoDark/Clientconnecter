using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    class SimpleClient
    {
        TcpClient newClient;
        NetworkStream newNetworkStream;
        IFormatter formatter;
        public SimpleClient(string IP, int Port)
        {
            newClient = new TcpClient(IP, Port);
            newNetworkStream = newClient.GetStream();
            formatter = new BinaryFormatter();
        }
    }
}
