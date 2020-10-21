using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype.Components
{
    class Display : IComponent
    {
        private string info;
        public Display(string info)
        {
            this.info = info;
        }
        public void ShowCmpntInf()
        {
            Console.WriteLine(info);
        }
    }
}
