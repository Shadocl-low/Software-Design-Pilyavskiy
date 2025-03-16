using AbstractFactory.Interfaces;
using AbstractFactory.Products.Laptop;
using AbstractFactory.Products.EBook;
using AbstractFactory.Products.Smartphone;

namespace AbstractFactory.Factories
{
    public class BalaxyFactory : IDeviceFactory
    {
        public ILaptop CreateLaptop()
        {
            return new BalaxyLaptop();
        }

        public IEBook CreateEBook()
        {
            return new BalaxyEBook();
        }

        public ISmartphone CreateSmartphone()
        {
            return new BalaxySmartphone();
        }
    }
} 