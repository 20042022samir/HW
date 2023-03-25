

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace GT.work
{
    internal static class Helper
    {
        public static void Helpes()
        {
            Console.ForegroundColor= ConsoleColor.White;
            Console.WriteLine("salam zehmet olmasa emelliyyatlardan birini secin");
            Console.ForegroundColor= ConsoleColor.Green;
            Console.WriteLine("1-->Pizzalari gosterin");
            Console.WriteLine("2-->piiza yaradin");
        }

        public static void Maiin()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("hansi boyda olmasini istediyinizi secin");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("1-->" + Extra.Ortaboy);
            Console.WriteLine("2-->" + Extra.BoyukBoy);
            Console.WriteLine("3-->" + Extra.KicikBoy);
            Console.ForegroundColor = ConsoleColor.White;
        }
     
        
      
    }
}
