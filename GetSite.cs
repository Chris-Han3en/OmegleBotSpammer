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
    class GetSite
    {
        public static string sentance1 = "Ngl idk why you just shouldn't subscribe";
        public static string sentance2 = "**https://www.youtube.com/watch?v=xQXRhsm1sW0&list=PLOhuUu9gX9YqZLrGVWrsrqh95jsI6W1wx**";

        static string url = "https://www.omegle.com/";

        public static void begin()
        {
            ChromeOptions option = new ChromeOptions();
            option.AddArgument("--headless");
            IWebDriver wb = new ChromeDriver(option);
            wb.Navigate().GoToUrl(url);
            
            try
            {
                var TextButton = wb.FindElement(By.XPath("//*[@id=\"textbtn\"]"));
                TextButton.Click();
            }
            catch
            {
                if (!Sentance.IsTyping)
                {
                    Console.WriteLine("No Text button found.");
                }
            }
            try
            {
                var AcceptOne = wb.FindElement(By.XPath("/html/body/div[7]/div/p[1]/label/input"));
                AcceptOne.Click();
                var AcceptTwo = wb.FindElement(By.XPath("/html/body/div[7]/div/p[2]/label/input"));
                AcceptTwo.Click();
                var ConfirmAndContinue = wb.FindElement(By.XPath("/html/body/div[7]/div/p[3]/input"));
                ConfirmAndContinue.Click();
            }
            catch
            {
                if (!Sentance.IsTyping)
                {
                    Console.WriteLine("Verification failed.");
                }
                
            }
            int numberOfTimesSent1 = 1;
            int numberOfTimesSent2 = 1;
            while (true)
            {   
                try
                {
                    new WebDriverWait(wb, TimeSpan.FromSeconds(20)).Until(ExpectedConditions.ElementToBeClickable(By.XPath("/html/body/div[5]/div/div/div[2]/table/tbody/tr/td[2]/div/textarea"))).SendKeys(sentance1);
                    if (!Sentance.IsTyping)
                    {
                        Console.WriteLine($"\nMessage 1 sent with the content of '{sentance1}'. Message 1 has been sent '{numberOfTimesSent1}' times\n");
                    }
                    numberOfTimesSent1++;
                    var send = wb.FindElement(By.XPath("/html/body/div[5]/div/div/div[2]/table/tbody/tr/td[3]/div/button"));
                    send.Click();
                    Thread.Sleep(1000);
                    var box = wb.FindElement(By.XPath("/html/body/div[5]/div/div/div[2]/table/tbody/tr/td[2]/div/textarea"));
                    box.SendKeys(sentance2);
                    if (!Sentance.IsTyping)
                    {
                        Console.WriteLine($"\nMessage 2 sent with the content of '{sentance2}'. Message 2 has been sent '{numberOfTimesSent2}' times\n");
                    }
                    numberOfTimesSent2++;
                    send.Click();
                }
                catch (Exception e)
                {
                    if (!Sentance.IsTyping)
                    {
                        Console.WriteLine($"sending message failed\n\n {e}");
                    }
                }
                Thread.Sleep(5000);
                try
                {
                    var Quit = wb.FindElement(By.XPath("/html/body/div[5]/div/div/div[2]/table/tbody/tr/td[1]/div/button"));
                    Quit.Click();
                    Thread.Sleep(100);
                    Quit.Click();
                    Thread.Sleep(100);
                    Quit.Click();
                }
                catch
                {
                    if (!Sentance.IsTyping)
                    {
                        Console.WriteLine("searching for new chat failed");
                    }
                }
            }
        }
    }
}
