using MyStore.Domain.StoreContext.Enums;
using System;

namespace MyStore.Domain.StoreContext.Commands.CustomerCommands.Inputs
{
    public class AddAddressCommand
    {
        public Guid Id { get; set; }
        public string Street { get;  set; }
        public string Number { get;  set; }
        public string Complement { get;  set; }
        public string District { get;  set; }
        public string City { get;  set; }
        public string State { get;  set; }
        public string Country { get;  set; }
        public string ZipCode { get;  set; }
        public EAdressType Type { get;  set; }
    }
}
