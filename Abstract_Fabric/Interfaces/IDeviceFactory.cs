namespace AbstractFactory.Interfaces
{
    public interface IDeviceFactory
    {
        ILaptop CreateLaptop();
        IEBook CreateEBook();
        ISmartphone CreateSmartphone();
    }
} 