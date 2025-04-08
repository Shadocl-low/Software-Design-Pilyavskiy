using Decorator.Heroes;
using Decorator.Decorators;
using Decorator;

Hero warrior = new Warrior();
Hero mage = new Mage();
Hero palladin = new Palladin();


warrior = new HeavyArmor(warrior);
warrior = new StandartPhysicalWeapon(warrior);
warrior = new MagicalSupplies(warrior);

mage = new LightArmor(mage);
mage = new MageWeapon(mage);
mage = new MagicalSupplies(mage);

palladin = new HeavyArmor(palladin);
palladin = new StandartPhysicalWeapon(palladin);
palladin = new FirstAidKit(palladin);
palladin = new FirstAidKit(palladin);


Console.ForegroundColor = ConsoleColor.DarkRed;
Console.WriteLine(warrior.ShowHero());

Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine(mage.ShowHero());

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine(palladin.ShowHero());

Console.ResetColor();
