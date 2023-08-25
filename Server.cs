using System;
using System.Net;
using System.Net.Sockets;

internal class ServerTest
{
    private static void Main(string[] args)
    {
        Server server = new Server();
        server.Start();
    }
}

public class Server {
    int port;
    IPEndPoint ipPoint;
    //Socket socket;

    public Server(int port = 9090) {
        this.port = port;
        this.ipPoint = new IPEndPoint(IPAddress.Loopback, port);
    }

    public async void Start() {
        Socket socket = new Socket(AddressFamily.InterNetwork,
         SocketType.Stream, ProtocolType.Tcp);
        socket.Bind(ipPoint);
        socket.Listen(1000);
        System.Console.WriteLine(socket.LocalEndPoint);
        Socket client = await socket.AcceptAsync();
        Console.WriteLine(client.RemoteEndPoint);
    }
}