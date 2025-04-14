using System;
using System.Reflection;

class Program
{
    static void Main(string[] args)
    {
        // is a .NET method that returns information about the executable assembly that 
        // was first loaded when the application started (the "entry point" assembly).
        var assembly = Assembly.GetEntryAssembly();
        
        if (assembly?.GetName()?.Version is Version version)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine($"Version: {version}");
        }
        else
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Version: Unknown");
        }
    }
}
