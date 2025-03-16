Thread thread1 = new Thread(() =>
{
    Authenticator auth1 = Authenticator.GetInstance();
    Console.WriteLine($"Thread 1 instance: {auth1.GetHashCode()}");
    auth1.Authenticate("user1", "password1");
});

Thread thread2 = new Thread(() =>
{
    Authenticator auth2 = Authenticator.GetInstance();
    Console.WriteLine($"Thread 2 instance: {auth2.GetHashCode()}");
    auth2.Authenticate("user2", "password2");
});

Thread thread3 = new Thread(() =>
{
    Authenticator auth3 = Authenticator.GetInstance();
    Console.WriteLine($"Thread 3 instance: {auth3.GetHashCode()}");
    auth3.Authenticate("user3", "password3");
});

thread1.Start();
thread2.Start();
thread3.Start();

thread1.Join();
thread2.Join();
thread3.Join();

Authenticator mainAuth = Authenticator.GetInstance();
Console.WriteLine($"Main thread instance: {mainAuth.GetHashCode()}");

