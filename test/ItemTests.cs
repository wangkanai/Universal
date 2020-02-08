using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Wangkanai.Universal.Ecommerce;

namespace Wangkanai.Universal.Tests
{
    [TestClass]
    public class ItemTests
    {
        [TestMethod]
        public void TestItemToString()
        {
            var item = new Item("product a", "a001", "xxx", 1, 1);
            Assert.AreEqual("{'id':'1234','name':'product a','sku':'a001','category':'xxx','price':'1','quantity':'1'}",
                item.JsScript("1234"));
        }
        [TestMethod]
        public void TestItemScript()
        {
            var transaction = new Transaction("1234", "testing", 0.0, 0.0);
            transaction.Items.Add(new Item("product a", "a001", "xxx", 1.0, 1));
            string script ="ga('ecommerce:addItem',{'id':'1234','name':'product a','sku':'a001','category':'xxx','price':'1','quantity':'1'});";          
            Assert.AreEqual(script, transaction.JsItemsScript().First());
        }
    }
}
