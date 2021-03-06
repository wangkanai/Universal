﻿using System;
using System.Linq;
using Wangkanai.Universal.Ecommerce;
using Xunit;

namespace Wangkanai.Universal
{
    public class ItemTests
    {
        [Fact]
        public void TestItemToString()
        {
            var item = new Item("product a", "a001", "xxx", 1, 1);
            Assert.Equal("{'id':'1234','name':'product a','sku':'a001','category':'xxx','price':'1','quantity':'1'}",
                item.JsScript("1234"));
        }
        [Fact]
        public void TestItemScript()
        {
            var transaction = new Transaction("1234", "testing", 0.0, 0.0);
            transaction.Items.Add(new Item("product a", "a001", "xxx", 1.0, 1));
            string script ="ga('ecommerce:addItem',{'id':'1234','name':'product a','sku':'a001','category':'xxx','price':'1','quantity':'1'});";          
            Assert.Equal(script, transaction.JsItemsScript().First());
        }
    }
}
