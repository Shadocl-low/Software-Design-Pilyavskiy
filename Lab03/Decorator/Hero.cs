using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public abstract class Hero
    {
        protected string description = "";
        protected int basePower;
        protected Hero() { }
        protected Hero(string description, int basePower)
        {
            this.description = description;
            this.basePower = basePower;
        }

        public virtual string GetDescription() => description;
        public virtual int GetPower() => basePower;
        public virtual string ShowHero() => $"{GetDescription()}\nPower: {GetPower()}\n";
    }
}
