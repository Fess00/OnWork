using System;

internal class TerminalTest
{
    private static void Main(string[] args)
    {
        DB db = DB.GetInstance();
    }
}

public class Terminal {
    
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