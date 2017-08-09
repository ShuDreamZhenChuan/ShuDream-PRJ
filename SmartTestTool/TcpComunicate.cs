using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;

namespace SmartTestTool
{
    class TcpComunicate:TcpClient
    {

        string ipaddress;
        int port;

        public TcpComunicate(string ipaddress,int port)
        {
            this.ipaddress = ipaddress;
            this.port = port;
        }

        public bool  connectToServer()
        {
            this.Connect(IPAddress.Parse(ipaddress), port);

            if (this.Connected == true)
                return true;
            else
                return false;
        
        }
       
        public void senddata(string data)
        {
            if (this.Connected == false)
                return;
            NetworkStream _stream = this.GetStream();
            
            byte[] senddata=Encoding.Unicode.GetBytes(data);

            _stream.Write(senddata, 0, senddata.Length);
        }
    }
}
