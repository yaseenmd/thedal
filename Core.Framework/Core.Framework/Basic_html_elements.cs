using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace Core.Framework
{
  
    public class Basic_html_elements
    {
        
      /* this is used to navigate to the particular url
       * url is param.
       * type the url where you want to go*/

        public void openurl(string url)
        {
            var driver = new FirefoxDriver();
            driver.Navigate().GoToUrl(url);
        }


    }
}
