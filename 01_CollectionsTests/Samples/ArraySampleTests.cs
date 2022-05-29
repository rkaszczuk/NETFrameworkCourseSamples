using Microsoft.VisualStudio.TestTools.UnitTesting;
using _01_Collections.Samples;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Collections.Samples.Tests
{
    [TestClass()]
    public class ArraySampleTests
    {
        [TestMethod()]
        public void ArrayDeclarationsTest()
        {
            ArraySample.ArrayDeclarations();
        }

        [TestMethod()]
        public void ArrayResizeTest()
        {
            ArraySample.ArrayResize();
        }
    }
}