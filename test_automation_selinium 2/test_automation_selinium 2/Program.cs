using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace test_automation_selinium_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IWebDriver Driver = new ChromeDriver(@"D:\Selenium needs");
            Driver.Url = "https://www.google.com";

            // add  your search keyword
            Driver.FindElement(By.Id("APjFqb")).SendKeys("Egypt");
            //then press Enter 
            Driver.FindElement(By.Id("APjFqb")).SendKeys(Keys.Enter);


            // or click the search button
            // Driver.FindElement(By.Name("btnK")).Click();


        }
    }
}

