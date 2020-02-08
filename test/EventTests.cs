using System;

namespace Wangkanai.Universal.Tests
{
    public class EventTests
    {
        [Fact]
        public void TestEventCategoryOnly()
        {
            Event categoryevent = new Event("button","click","submit","1");
            Assert.AreEqual("'event','button','click','submit','1'", categoryevent.ToString());
        }
    }
}
