using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public abstract class HeroDecorator : Hero
    {
        protected Hero hero;
        protected List<string> contents;
        public HeroDecorator(Hero hero, List<string> contents)
        {
            this.hero = hero;
            this.contents = contents;
        }

        public override string GetDescription() => hero.GetDescription();
        public override int GetPower() => hero.GetPower();
    }
}
