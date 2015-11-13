using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Foundation;

namespace UselessMachine
{
    public interface IUselessMachine
    {
        List<IUselessSwitch> UselessSwitches
        {
            get;
        }

        /// <summary>
        /// A percentage representing the extension state of the finger
        /// where 0 is fully retracted and 1 is fully extended
        /// </summary>
        decimal FingerExtension
        {
            get;
            set;
        }

        /// <summary>
        /// Performs a calibration routine through which the machine
        /// figures out where the switches connected to itself are
        /// </summary>
        /// <returns></returns>
        List<IUselessSwitch> PerformAutoCalibration();

        /// <summary>
        /// Positions the finger in front of the given switch and
        /// extends the finger to actuate the switch
        /// </summary>
        /// <param name="switchId">The switch to actuate</param>
        /// <returns></returns>
        IAsyncAction ActuateSwitch(int switchId);

    }
}
