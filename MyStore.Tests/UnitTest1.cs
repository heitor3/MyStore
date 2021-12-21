using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyStore.Domain.StoreContext.Entities;
using MyStore.Domain.StoreContext.ValueObjects;

namespace MyStore.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var name = new Name("Heitor", "Pires");
            var document = new Document("12345678911");
            var email = new Email("heitor@gmail.com");
            var c = new Customer(name, document, email, "10999999999");

            var mouse = new Product("Mouse", "Rato", "image.png", 59.90M, 10);
            var teclado = new Product("Teclado", "Tec-Tec", "image.png", 100.90M, 60);
            var headset = new Product("Headset", "Havit-2002d", "image.png", 280.99M, 40);
            var notebook = new Product("Notebook", "Sansung", "image.png", 3540.00M, 20);

            var order = new Order(c);
            order.AddItem(new OrderItem(mouse, 1));
            order.AddItem(new OrderItem(teclado, 1));
            order.AddItem(new OrderItem(headset, 1));
            order.AddItem(new OrderItem(notebook, 1));

            //realizar pedido
            order.Place();

            //simular pagamento
            order.Pay();

            //simular envio
            order.Ship();

            //simular cancelamento
            order.Cancel();

        }
    }
}
