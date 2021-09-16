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
            //By TagName
            //driver.FindElement(By.TagName("input")).SendKeys("Selenium");
            // Store in The List And Then Print the Size
            ReadOnlyCollection<IWebElement> links = driver.FindElements(By.TagName("a"));
            //ReadOnlyCollection<IWebElement> links = driver.FindElements(By.TagName("a"));
            Console.WriteLine(links.Count);
            foreach(IWebElement link in links)
            {
                Console.WriteLine(link.Text);
            }
            //Close the Browser
            driver.Close();
        }
    }
}
