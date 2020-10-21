using Prototype.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype.Devices
{
    class Laptop : Device
    {
        public Laptop()
        {
            components.Add(new Keyboard("101"));
            components.Add(new Display("HD"));
            components.Add(new TouchPad("2-button"));
            components.Add(new CPU("2cores"));
            components.Add(new RAM("4Gb"));
            components.Add(new ROM("320Gb"));
        }
        private Laptop(Laptop laptop)
        {
            this.components = new List<IComponent>(laptop.components);
        }
        public override Device Clone()
        {
            return new Laptop(this);
        }
    }
}
