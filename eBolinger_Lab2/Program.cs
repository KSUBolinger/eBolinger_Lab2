using System;
using eBolinger_Lab2;

namespace eBolinger_Lab2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            work();
            
            //Console.WriteLine("Hello World!");
        }

        public static void work()
        {
            Manager mrg = new Manager();
            Helper h = mrg.requestHelp();
            h.doWork();
            h.finished();
        }
    }
}
