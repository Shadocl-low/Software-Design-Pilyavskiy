using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Decorators
{
    public class HeavyArmor : HeroDecorator
    {
        public HeavyArmor(Hero hero) : base(hero, ["Steel Helmet", "Chainmail Chestplate", "Plate Leggings", "Iron Gauntlets", "Steel Boots"]) { }

        public override string GetDescription() => base.GetDescription() + $"\nHeavy Armor: {String.Join(", ",  contents.ToArray())}";
        public override int GetPower() => base.GetPower() + 5;
    }
}
