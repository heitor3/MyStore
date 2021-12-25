using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyStore.Domain.StoreContext.Commands.CustomerCommands.Inputs;

namespace MyStore.Tests.Commands
{
    [TestClass]
    public class CreateCustomerCommandsTeste
    {
        [TestMethod]
        public void ShouldValidateWhenCommandIsValid()
        {
            var command = new CreateCustomerCommand
            {
                FirstName = "Heitor",
                LastName = "Pires",
                Document = "16311149133",
                Email = "heitor@gmail.com",
                Phone = "12345678900"
            };

            Assert.AreEqual(true, command.Valid());
        }
    }
}
