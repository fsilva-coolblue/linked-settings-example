using System;
using System.Configuration;

namespace ConfigLinkTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Test setting: {ConfigurationManager.AppSettings["TestSetting"]}");
            Console.ReadLine();
        }
    }
}