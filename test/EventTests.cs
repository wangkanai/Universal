using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Wangkanai.Universal.Tests
{
    [TestClass]
    public class EventTests
    {
        [TestMethod]
        public void TestEventCategoryOnly()
        {
            Event categoryevent = new Event("button","click","submit","1");
            Assert.AreEqual("'event','button','click','submit','1'", categoryevent.ToString());
        }
    }
}
