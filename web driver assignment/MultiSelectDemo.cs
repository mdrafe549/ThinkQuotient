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
            driver.Url = "https://www.seleniumeasy.com/test/basic-select-dropdown-demo.html";
            IWebElement select_box = driver.FindElement(By.Name("States"));
            SelectElement select = new SelectElement(select_box);
            Boolean status_multiple = select.IsMultiple;
            Console.WriteLine(status_multiple);
            select.SelectByIndex(4);
            select.SelectByValue("California");
            select.SelectByText("New Jersey");
            //select.DeselectAll();
            select.DeselectByIndex(0);
            //Close the Browser
            //driver.Close();
        }
    }
}
