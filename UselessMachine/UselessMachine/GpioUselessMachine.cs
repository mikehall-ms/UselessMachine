using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Foundation;

namespace UselessMachine
{
    internal class GpioUselessMachine : IUselessMachine
    {
        public decimal FingerExtension
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public List<IUselessSwitch> UselessSwitches
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IAsyncAction ActuateSwitch(int switchId)
        {
            throw new NotImplementedException();
        }

        public List<IUselessSwitch> PerformAutoCalibration()
        {
            throw new NotImplementedException();
        }
    }
}
