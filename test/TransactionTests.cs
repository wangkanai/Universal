using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Analytics.Ecommerce;

namespace Analytics.Tests
{
    [TestClass]
    public class TransactionTests
    {
        [TestMethod]
        public void TestCalculationRevenue()
        {
            var transaction = new Transaction("1234", "testing", 1.0, 1.0);
            transaction.Items.Add(new Item("product a", "a001", "fertilizer", 1.0, 1));
            Assert.AreEqual(3.0, transaction.Revenue);
        }
        [TestMethod]
        public void TestCalcuationTwoItems()
        {
            var transaction = new Transaction("1234", "testing", 1.0, 1.0);
            transaction.Items.Add(new Item("product a", "a001", "fertilizer", 1.0, 1));
            transaction.Items.Add(new Item("product b", "b001", "fertilizer", 1.0, 1));
            Assert.AreEqual(4.0, transaction.Revenue);
        }
        [TestMethod]
        public void TestJsTransactionScript()
        {
            var transaction = new Transaction("1234", "testing", 1.0, 1.0);
            Assert.AreEqual("ga('ecommerce:addTransaction',{'id':'1234','affiliation':'testing','revenue':'2','shipping':'1','tax':'1'});",
                transaction.JsTransactionScript());
        }
        [TestMethod]
        public void TestJsEcommerceScript()
        {
            var transaction = new Transaction("1234", "testing", 1.0, 1.0);
            transaction.Items.Add(new Item("product a", "a001", "fertilizer", 1.0, 1));
            transaction.Items.Add(new Item("product b", "b001", "fertilizer", 1.0, 1));
            Console.WriteLine(transaction.ToString());
        }
        [TestMethod]
        public void TestEcommerceScriptBlock()
        {
            var analytic = Analytic.Instance;
                        var transaction = new Transaction("1234", "testing", 1.0, 1.0);
            transaction.Items.Add(new Item("product a", "a001", "fertilizer", 1.0, 1));
            transaction.Items.Add(new Item("product b", "b001", "fertilizer", 1.0, 1));
            var session = new Session();
            session.Transaction = transaction;
            Console.WriteLine(analytic.Render(session));
        }
    }
}
