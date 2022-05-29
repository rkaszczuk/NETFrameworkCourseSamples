using Microsoft.VisualStudio.TestTools.UnitTesting;
using _01_Collections.Samples.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Collections.Samples.Generic.Tests
{
    [TestClass()]
    public class ListSampleTests
    {
        [TestMethod()]
        public void ListTestTest()
        {
            ListSample.ListTest();
        }

        [TestMethod()]
        public void ListWithComplexTypeTestTest()
        {
            ListSample.ListWithComplexTypeTest();
        }
    }
}