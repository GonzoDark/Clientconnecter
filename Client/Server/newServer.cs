using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace Server
{

    class newServer
    {
        Socket newSocket;
        TcpListener newListener;
        IPAddress newIPAddress;
        static List<ClientData> listClients = new List<ClientData>(); //liste af klienter
        public newServer()
        {
            int port = 5000;
            IPAddress ip = IPAddress.Parse("127.0.0.1");
            TcpListener listener = new TcpListener(ip, port);
            listener.Start();
        }



    }
}
