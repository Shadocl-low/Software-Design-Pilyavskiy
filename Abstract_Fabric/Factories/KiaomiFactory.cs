using AbstractFactory.Interfaces;
using AbstractFactory.Products.Laptop;
using AbstractFactory.Products.EBook;
using AbstractFactory.Products.Smartphone;

namespace AbstractFactory.Factories
{
    public class KiaomiFactory : IDeviceFactory
    {
        public ILaptop CreateLaptop()
        {
            return new KiaomiLaptop();
        }

        public IEBook CreateEBook()
        {
            return new KiaomiEBook();
        }

        public ISmartphone CreateSmartphone()
        {
            return new KiaomiSmartphone();
        }
    }
} 