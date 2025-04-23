using DesignPatterns.Mediator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public interface ICommandCentre
    {
        void Notify(object sender, string ev);
    }
}
