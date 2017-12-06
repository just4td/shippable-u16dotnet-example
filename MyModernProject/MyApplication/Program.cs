using MyLibrary;
using System;
using System.Diagnostics;

namespace MyApplication
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                var processName = Process.GetCurrentProcess().ProcessName;
                Console.WriteLine($"Usage: {processName} \"{{\\\"some\\\":\\\"json\\\"}}\"");
            }
            else
            {
                foreach (var json in args)
                {
                    try
                    {
                        Console.WriteLine(JsonFormatter.Format(json));
                    }
                    catch (Exception)
                    {
                        Console.WriteLine($"Invalid JSON: {json}");
                    }
                }
            }
        }
    }
}
