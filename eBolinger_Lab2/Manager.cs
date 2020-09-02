using System;
using System.Collections.Generic;
using System.Text;

namespace eBolinger_Lab2
{
    public class Manager
    {
        private List<Helper> active;

        public Helper requestHelp()
        {
            Helper h = new Helper(this);
            return h;
        }

        public Helper Remove(Helper h)
        {
            active.Remove(h);
            return h;
        }
    }
}
