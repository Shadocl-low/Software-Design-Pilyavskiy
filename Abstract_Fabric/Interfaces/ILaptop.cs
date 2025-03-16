namespace AbstractFactory.Interfaces
{
    public interface ILaptop
    {
        string Brand { get; }
        string Model { get; }
        string Processor { get; }
        int RamSize { get; }
        double Price { get; }
        void DisplayInfo();
    }
} 