using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading;

namespace Libraries
{
    public class End
    {
        public static void End_Method()
        {
            //add restart functionality
            Console.WriteLine("Game has ended.");
            Thread.Sleep(3000);
            System.Environment.Exit(0);
        }
    }
}
