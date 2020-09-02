using System;
using System.Collections.Generic;
using System.Text;

namespace eBolinger_Lab2
{
    public class Manager
    {
        private List<Helper> active;
        public Manager()
        {
           
        }

        public static Helper RequestHelp()
        {
            Helper h = new Helper(this);
            return h;
        }
    }
}
