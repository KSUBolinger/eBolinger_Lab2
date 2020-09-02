using System;
using System.Collections.Generic;
using System.Text;

namespace eBolinger_Lab2Part2
{
    public class Helper
    {
        public Manager myManager = new Manager();

        public Helper(Manager mrg)
        {
            
        }

        public void doWork()
        {
            Console.WriteLine("Doing Work");
        }

        public void finished()
        {
            Console.WriteLine("Worked Finished");
            myManager.Remove(this);
        }
    }
}
