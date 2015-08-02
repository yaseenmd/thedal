using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.Core;
using NUnit.Framework;

namespace Testlibararies
{
    [TestFixture]
    class Program
    {

        [Test]
        public void test1()
        {
            var web_elements = new Basic_WebElements();

            web_elements.gotoUrl("http://www.google.com");
            
        }
    }
}
