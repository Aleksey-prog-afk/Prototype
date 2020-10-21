using Prototype.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype.Devices
{
    class Tablet : Device
    {
        public Tablet()
        {
            components.Add(new Display("UltraHD"));
            components.Add(new CPU("8cores"));
            components.Add(new RAM("2Gb"));
            components.Add(new ROM("128Gb"));
        }
        private Tablet(Tablet tablet)
        {
            this.components = new List<IComponent>(tablet.components);
        }
        public override Device Clone()
        {
            return new Tablet(this);
        }
    }
}
