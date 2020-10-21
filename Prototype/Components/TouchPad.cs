using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype.Components
{
    class TouchPad : IComponent
    {
        private string info;
        public TouchPad(string info)
        {
            this.info = info;
        }
        public void ShowCmpntInf()
        {
            Console.WriteLine(info);
        }
    }
}
