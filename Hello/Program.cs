using System;
using System.Linq;

namespace Hello
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = null;
            if (args.Any())
            {
                name = args.First();
            }

            Console.WriteLine(new HelloLib.Hello(name).ToString());
            Console.ReadKey(true);
        }
    }
}
