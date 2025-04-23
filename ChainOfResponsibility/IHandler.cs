using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public interface IHandler
    {
        void SetNext(IHandler next);
        bool AskIfResolved();
        bool ConnectWithNextOperator(string request, string message);

        bool Handle(string issue);
    }
}
