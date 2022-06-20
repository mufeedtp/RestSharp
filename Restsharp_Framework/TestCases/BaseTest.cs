using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restsharp_Framework.TestCases
{
    public class BaseTest
    {
        public TestContext TestContext { get; set; }

        [SetUp]
        public void BeforeEachTest()
        {
            TestContext = TestContext.CurrentContext;
        }
    }
}
