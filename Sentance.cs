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
        public static bool IsTyping = false;

        public static void correction()
        {
            while (true)
            {
                Thread.Sleep(2000);
                Console.Clear();
                Console.WriteLine("Type 'new' if you want to change the sentances. Type 'quit' if you want to close the software.\n");
                string response = Console.ReadLine();
                if (response == "new")
                {
                    IsTyping = true;
                    Console.Clear();
                    Console.WriteLine("Enter new text for first sentance\n");
                    string FirstSentance = Console.ReadLine();
                    GetSite.sentance1 = FirstSentance;
                    Console.WriteLine("Set\n");
                    Console.WriteLine("Enter new text for second sentance\n");
                    string SecondSentance = Console.ReadLine();
                    GetSite.sentance2 = SecondSentance;
                    Console.WriteLine("\nSet");
                    Thread.Sleep(1000);
                    Console.Clear();
                    IsTyping = false;
                }
                else if (response == "quit")
                {
                    Environment.Exit(1);
                }
            }
        }
    }
}
