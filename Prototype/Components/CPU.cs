using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype.Components
{
    class CPU : IComponent
    {
        private string info;
        public CPU(string info)
        {
            this.info = info;
        }
        public void ShowCmpntInf()
        {
            Console.WriteLine(info);
        }
    }
}
