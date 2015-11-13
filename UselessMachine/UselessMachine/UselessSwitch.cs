using System;

namespace UselessMachine
{
    internal class UselessSwitch : IUselessSwitch
    {
        public Guid Id
        {
            get;
            private set;
        }

        public bool IsOn
        {
            get;
            private set;
        }

        private double switchXLocation;
        private double switchYLocation;
    }
}
