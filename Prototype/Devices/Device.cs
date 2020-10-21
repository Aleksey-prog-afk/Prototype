using Prototype.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype.Devices
{
    abstract class Device
    { 
        public List<IComponent> components = new List<IComponent>();

        public abstract Device Clone();
        
        public void ShowInfo()
        {
            foreach(IComponent component in components)
            {
               Console.Write("{0} ", component.GetType().Name);
               component.ShowCmpntInf();
            }
        }
    }
}
