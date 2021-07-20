using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using System.Net.Mime;
using System.Runtime.InteropServices;
using System.Diagnostics;
using OpenQA.Selenium.Support.UI;

namespace OmegelSpamBot
{
    class Sentance
    {
        public static void correction()
        {
            while (true)
            {
                Console.WriteLine("Type 'new' if you want to change the sentances");
                string response = Console.ReadLine();
                if (response == "new")
                {
                    Console.Clear();
                    Console.WriteLine("Enter new text for first sentance\n");
                    string FirstSentance = Console.ReadLine();
                    GetSite.sentance1 = FirstSentance;
                    Console.WriteLine("\n\nSet\n\n");
                    Console.WriteLine("Enter new text for second sentance");
                    string SecondSentance = Console.ReadLine();
                    GetSite.sentance2 = SecondSentance;
                    Console.WriteLine("\n\nSet");
                    Thread.Sleep(1000);
                    Console.Clear();
                }
            }
        }
    }
}
