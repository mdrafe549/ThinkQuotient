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
            driver.Url = "https://formstone.it/components/dropdown/demo/";
            IWebElement select_box = driver.FindElement(By.Id("demo_basic"));
            SelectElement select = new SelectElement(select_box);
            //select.SelectByIndex(1);
            //select.SelectByValue("2");
            select.SelectByText("Two");
            //Close the Browser
            driver.Close();
        }
    }
}
