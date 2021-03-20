using System;
using System.Collections.Generic;
using System.Text;

using System.Threading;
using System.Net.Sockets;
using System.Collections;


namespace BroadcastServer
{
    class ClientHandler
    {
        String clientNickname;
        TcpClient clientTcpSocket;
        Hashtable clients;

        ClientHandler(TcpClient socket, Hashtable table, String nickname) {
            this.clientTcpSocket = socket;
            this.clients = table;
            this.clientNickname = nickname;
            new Thread(joinChat).Start();
        }

        private void joinChat() {
        }
    }
}
