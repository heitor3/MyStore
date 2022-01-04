using FluentValidator;
using MyStore.Domain.StoreContext.Commands.CustomerCommands.Inputs;
using MyStore.Domain.StoreContext.Commands.CustomerCommands.Outputs;
using MyStore.Domain.StoreContext.Entities;
using MyStore.Domain.StoreContext.ValueObjects;
using MyStore.Shared.Commands;
using System;

namespace MyStore.Domain.StoreContext.Handlers
{
    public class CustomerHandler : 
        Notifiable,
        ICommandHandler<CreateCustomerCommand>,
        ICommandHandler<AddAddressCommand>
    {
        public ICommandResult Handle(CreateCustomerCommand command)
        {
            //verificar se o CPF existe na base

            //verificar se o email existe na base

            //criar VOs
            var name = new Name(command.FirstName, command.LastName);
            var document = new Document(command.Document);
            var email = new Email(command.Email);

            //criar a entidade
            var customer = new Customer(name, document, email, command.Phone);

            //validar entidades e VOs
            AddNotifications(name.Notifications);
            AddNotifications(document.Notifications);
            AddNotifications(email.Notifications);
            AddNotifications(customer.Notifications);

            //persistir o cliente

            //enviar um email de boas vindas

            //retornar o resultado na tela
            return new CreateCustomerCommandResult(Guid.NewGuid(), name.ToString(), email.Address);
        }

        public ICommandResult Handle(AddAddressCommand command)
        {
            throw new System.NotImplementedException();
        }
    }
}
