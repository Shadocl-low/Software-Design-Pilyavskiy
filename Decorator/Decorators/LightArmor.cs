using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Decorators
{
    public class LightArmor : HeroDecorator
    {
        public LightArmor(Hero hero) : base(hero, ["Leather Hood", "Padded Vest", "Reinforced Trousers", "Fingerless Gloves", "Soft Boots"]) { }

        public override string GetDescription() => base.GetDescription() + $"\nLight Armor: {String.Join(", ", contents.ToArray())}";
        public override int GetPower() => base.GetPower() + 4;
    }
}
