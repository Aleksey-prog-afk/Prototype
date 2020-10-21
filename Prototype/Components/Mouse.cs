using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype.Components
{
    class Mouse : IComponent
    {
        private string info;
        public Mouse(string info)
        {
            this.info = info;
        }
        public void ShowCmpntInf()
        {
            Console.WriteLine(info);
        }
    }
}
