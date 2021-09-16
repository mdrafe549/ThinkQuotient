using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace LaunchChrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Hello Rafe");
            //Lauch Chrome
            IWebDriver driver = new ChromeDriver("C:\\Users\\mdraf\\Desktop\\ZENSAR TRAINING\\training");
            //Maximize the browser
            driver.Manage().Window.Maximize();
            //Launch Url(Open Google
            driver.Url = "https://www.seleniumeasy.com/test/basic-radiobutton-demo.html";
            ReadOnlyCollection<IWebElement> radio_buttons = driver.FindElements(By.Name("optradio"));
            Thread.Sleep(3000);            
            radio_buttons[1].Click();        
           
            Thread.Sleep(3000);
            //Close the Browser
            driver.Close();
        }
    }
}
