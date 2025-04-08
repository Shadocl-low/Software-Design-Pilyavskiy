using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Decorators
{
    class StandartPhysicalWeapon : HeroDecorator
    {
        public StandartPhysicalWeapon(Hero hero) : base(hero, ["Longsword", "Shortsword", "Shield"]) { }

        public override string GetDescription() => base.GetDescription() + $"\nWeapon: {String.Join(", ", contents.ToArray())}";
        public override int GetPower() => base.GetPower() + 8;
    }
}
