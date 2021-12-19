using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyStore.Domain.StoreContext.Entities;

namespace MyStore.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var c = new Customer(
              "Heitor",
              "Pires",
              "12345678901",
              "heitor@teste.com",
              "16123456789",
              "rua dos devs, 123");

            var order = new Order(c);

        }
    }
}
