namespace AbstractFactory.Interfaces
{
    public interface ISmartphone
    {
        string Brand { get; }
        string Model { get; }
        string Processor { get; }
        int RamSize { get; }
        double ScreenSize { get; }
        int BatteryCapacity { get; }
        double Price { get; }
        void DisplayInfo();
    }
} 