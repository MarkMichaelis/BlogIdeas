#nullable enable
using System;

namespace VanillaCSharpConsole
{
    class Program
    {
        static void Main(string[]? args)
        {
            DoSomething();
            //System.GC.Collect();
        }

        static void DoSomething()
        {
            Thing thing = new Thing();
        }
    }

    class Thing
    {
        ~Thing()
        {
            Console.WriteLine("Executing finalizer...");
            throw new Exception();
        }
    }

}
