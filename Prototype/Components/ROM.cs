using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype.Components
{
    class ROM : IComponent
    {
        private string info;
        public ROM(string info)
        {
            this.info = info;
        }
        public void ShowCmpntInf()
        {
            Console.WriteLine(info);
        }
    }
}
