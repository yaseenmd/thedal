using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Firefox;

namespace Framework.Core
{
    public class Basic_WebElements
    {
        /* <Summary>
         This method will lauch browser and go to particular url
         <param name="url"> type the url <param>
         <summary>  */

        public void gotoUrl(string url)
        {
            var driver = new FirefoxDriver();
            driver.Navigate().GoToUrl(url);
            //test
            //Test
            //fuck
        }
    }
}
