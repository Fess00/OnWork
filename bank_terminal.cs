using System;
using System.Net;
using System.Net.Sockets;

internal class TerminalTest
{
    private static void Main(string[] args)
    {
        Terminal terminal = new Terminal();
        terminal.Connection();
    }
}

public class Terminal {
    string ip;
    int port;
    Socket socket;

    public Terminal(string ip = "127.0.0.1", int port = 9090) {
        this.ip = ip;
        this.port = port;
    }

    public async void Connection() {
        socket = new Socket(AddressFamily.InterNetwork,
         SocketType.Stream, ProtocolType.Tcp);
        try
        {
            await socket.ConnectAsync(ip, port);
        }
        catch (SocketException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}

public interface ICard {
    double GetBalance();
    void Deposit(double value);
    void Withdraw(double value); 
}

public interface IClient {
    void SetName();
    void SetSurName();
    void SetFName();
    string GetName();
    string GetSurName();
    string GetFName();
    void SetPin();
    string GetPin();
    void SetCardToAccount();
    string[] GetCardList();
}

public class DB {
    private static DB instance;

    private DB(){

    }

    public static DB GetInstance() {
        if (instance == null)
        {
            instance = new DB();
        }

        return instance;
    }
}