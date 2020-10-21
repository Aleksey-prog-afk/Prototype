using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype.Components
{
    class Keyboard : IComponent
    {
        private string info;
        public Keyboard(string info)
        {
            this.info = info;
        }
        public void ShowCmpntInf()
        {
            Console.WriteLine(info);
        }
    }
}
