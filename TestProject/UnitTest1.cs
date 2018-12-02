using System;
using BuilderPattern;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void BuilderOneShouldReturnPartA()
        {
            ConcreteBuilderOne builder1 = new ConcreteBuilderOne();

            Product p = new Product();
            builder1.BuildPartA();

            p = builder1.GetResult();
            Assert.AreEqual(p.getProductList()[0], "PartA");
        }

        public void BuilderTwoShouldReturnPartB()
        {
            ConcreteBuilderOne builder1 = new ConcreteBuilderOne();

            Product p = new Product();
            builder1.BuildPartB();

            p = builder1.GetResult();
            Assert.AreEqual(p.getProductList()[0], "PartB");
        }
    }
}
