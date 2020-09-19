using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading;

namespace Libraries
{
    public class Exit
    {
        public static void Exit_Main()
        {
            Console.WriteLine("Exiting Game....");
            Thread.Sleep(2000);
            System.Environment.Exit(0);
        }
    }
}
