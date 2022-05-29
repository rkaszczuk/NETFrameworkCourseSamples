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
    public class EnumeratorArrayListSampleTests
    {
        [TestMethod()]
        public void IterateByIEnumeratorTest()
        {
            EnumeratorArrayListSample.IterateByIEnumerator();
        }

        [TestMethod()]
        public void ArrayListSampleTest()
        {
            EnumeratorArrayListSample.ArrayListSample();
        }
    }
}