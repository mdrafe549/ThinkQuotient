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
             // BY CSS Selector Xpath
            //driver.FindElement(By.CssSelector("input.gLFyf")).SendKeys("Selenium");
            //By Attribute
            //driver.FindElement(By.CssSelector("input[role='combobox']")).SendKeys("Selenium");
            //Starts with
            //driver.FindElement(By.CssSelector("input[role^='combo']")).SendKeys("Selenium");
            //Contains
            //driver.FindElement(By.CssSelector("input[role*='mbo']")).SendKeys("Selenium");
            //Ends-With
            driver.FindElement(By.CssSelector("input[role$='box']")).SendKeys("Selenium");

            //Close the Browser
            driver.Close();
        }
    }
}
