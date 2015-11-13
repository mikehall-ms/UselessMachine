using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UselessMachine
{
    public sealed class UselessMachineFactory
    {
        public IUselessMachine GetDefault()
        {
            return new GpioUselessMachine();
        }
    }
}
