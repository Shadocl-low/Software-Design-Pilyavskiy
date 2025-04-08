using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Decorators
{
    public class MagicalSupplies : HeroDecorator
    {
        public MagicalSupplies(Hero hero) : base(hero, ["Shild Amulet", "Health Potion", "Ring of Power"]) { }

        public override string GetDescription() => base.GetDescription() + $"\nMagical Supplieses: {String.Join(", ", contents.ToArray())}";
        public override int GetPower() => base.GetPower() + 7;
    }
}
