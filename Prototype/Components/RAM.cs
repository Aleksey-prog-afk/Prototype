using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype.Components
{
    class RAM : IComponent
    {
        private string info;
        public RAM(string info)
        {
            this.info = info;
        }
        public void ShowCmpntInf()
        {
            Console.WriteLine(info);
        }
    }
}
