using Prototype.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype.Devices
{
    class Notebook : Device
    {
        public Notebook()
        {
            components.Add(new Keyboard("108"));
            components.Add(new Display("FullHD"));
            components.Add(new TouchPad("1-button"));
            components.Add(new CPU("2cores"));
            components.Add(new RAM("8Gb"));
            components.Add(new ROM("512Gb"));
        }
        private Notebook(Notebook notebook)
        {
            this.components = new List<IComponent>(notebook.components);
        }
        public override Device Clone()
        {
            return new Notebook(this);
        }
    }
}
