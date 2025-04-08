using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Decorators
{
    public class FirstAidKit : HeroDecorator
    {
        public FirstAidKit(Hero hero) : base(hero, ["Bandage", "Painkiller", "Antiseptic"]) { }

        public override string GetDescription() => base.GetDescription() + $"\nFirst Aid Kit: {String.Join(", ", contents.ToArray())}";
        public override int GetPower() => base.GetPower() + 2;
    }
}
