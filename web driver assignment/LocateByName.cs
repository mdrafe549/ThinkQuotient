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
            driver.Url = "https://www.google.co.in/";
	     //Enter Selenium in search box: Locate By Name
            //IWebElement search_box = driver.FindElement(By.Name("q"));
            //search_box.SendKeys("Selenium");
            driver.FindElement(By.Name("q")).SendKeys("Selenium");
            //Close the Browser
            driver.Close();
        }
    }
}
