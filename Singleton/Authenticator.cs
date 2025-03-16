using System;

public class Authenticator
{
    private static Authenticator _instance;
    private static readonly object _lock = new object();

    private Authenticator()
    {
        if (_instance != null)
        {
            throw new Exception("Use GetInstance() method to get the instance.");
        }
    }

    public static Authenticator GetInstance()
    {
        if (_instance == null)
        {
            lock (_lock)
            {
                if (_instance == null)
                {
                    _instance = new Authenticator();
                }
            }
        }
        return _instance;
    }

    public void Authenticate(string username, string password)
    {
        Console.WriteLine($"Authenticating user: {username}");
    }
} 