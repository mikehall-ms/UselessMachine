using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UselessMachine
{
    public interface IUselessSwitch
    {
        Guid Id
        {
            get;
        }

        bool IsOn
        {
            get;
        }
    }
}
