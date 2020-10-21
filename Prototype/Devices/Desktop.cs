using Prototype.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype.Devices
{
    class Desktop : Device
    {
        public Desktop()
        {
            components.Add(new Mouse("2-button"));
            components.Add(new CPU("4cores"));
            components.Add(new RAM("16Gb"));
            components.Add(new ROM("1Tb"));
        }
        private Desktop(Desktop desktop)
        {
            this.components = new List<IComponent>(desktop.components);
        }
        public override Device Clone()
        {
            return new Desktop(this);
        }
    }
}
