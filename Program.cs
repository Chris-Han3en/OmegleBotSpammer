using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Net;
using System.Net.Mime;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Linq;

namespace OmegelSpamBot
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.Title = "Omegel Spam";

            Thread getsite = new Thread(() => GetSite.begin());
            getsite.Start();

            Thread sentance = new Thread(() => Sentance.correction());
            sentance.Start();

        }
    }
}
