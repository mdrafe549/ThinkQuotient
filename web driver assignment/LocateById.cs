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
            driver.Url = "https://accounts.google.com/signup/v2/webcreateaccount?service=mail&continue=https%3A%2F%2Fmail.google.com%2Fmail%2F%26ogbl%2F&ltmpl=default&biz=false&flowName=GlifWebSignIn&flowEntry=SignUp";
            //driver.FindElement(By.Id("firstName")).SendKeys("Rafe");
               //OR 
            driver.FindElement(By.CssSelector("#firstName")).SendKeys("Rafe");

            Thread.Sleep(3000);
            //Close the Browser
            driver.Close();
        }
    }
}
