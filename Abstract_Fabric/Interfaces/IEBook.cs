namespace AbstractFactory.Interfaces
{
    public interface IEBook
    {
        string Brand { get; }
        string Model { get; }
        double ScreenSize { get; }
        int StorageSize { get; }
        bool Backlight { get; }
        double Price { get; }
        void DisplayInfo();
    }
} 