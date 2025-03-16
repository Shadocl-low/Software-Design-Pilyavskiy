using AbstractFactory.Interfaces;
using AbstractFactory.Products.Laptop;
using AbstractFactory.Products.EBook;
using AbstractFactory.Products.Smartphone;

namespace AbstractFactory.Factories
{
    public class IPhoneFactory : IDeviceFactory
    {
        public ILaptop CreateLaptop()
        {
            return new IPhoneLaptop();
        }

        public IEBook CreateEBook()
        {
            return new IPhoneEBook();
        }

        public ISmartphone CreateSmartphone()
        {
            return new IPhoneSmartphone();
        }
    }
} 