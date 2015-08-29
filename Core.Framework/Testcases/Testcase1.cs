using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Core.Framework;

namespace Testcases
{
    [TestFixture]
    public class Testcase1
    {
        string url = "http:demo.testlink.org";
    [Test]

        public void tc_testcase1()
        {
            var basic_html = new Basic_html_elements();
            basic_html.openurl(url);
            
        }


    }
}
