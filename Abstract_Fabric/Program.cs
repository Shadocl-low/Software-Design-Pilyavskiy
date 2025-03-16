using System;
using AbstractFactory.Factories;
using AbstractFactory.Interfaces;

Console.WriteLine("Abstract Factory Pattern Demo\n");

IDeviceFactory[] factories =
[
    new IPhoneFactory(),
    new KiaomiFactory(),
    new BalaxyFactory()
];

foreach (var factory in factories)
{
    Console.WriteLine($"\n{factory.GetType().Name} Products:");
    Console.WriteLine("=======================");

    var laptop = factory.CreateLaptop();
    laptop.DisplayInfo();

    var ebook = factory.CreateEBook();
    ebook.DisplayInfo();

    var smartphone = factory.CreateSmartphone();
    smartphone.DisplayInfo();
}

