using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Decorators
{
    class MageWeapon : HeroDecorator
    {
        public MageWeapon(Hero hero) : base(hero, ["Wooden Staff", "Spellbook", "Enchanted Dagger"]) { }

        public override string GetDescription() => base.GetDescription() + $"\nWeapon: {String.Join(", ", contents.ToArray())}";
        public override int GetPower() => base.GetPower() + 8;
    }
}
