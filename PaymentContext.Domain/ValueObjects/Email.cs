using Flunt.Validations;
using PaymentContext.Shared.ValueObjects;

namespace PaymentContext.Domain.ValueObjects
{
    public class Email : ValueObject
    {
        public string Address { get; private set; }

        public Email(string address)
        {
            Address = address;

            AddNotifications(new Contract()  // Contract = Design By Contracts
                .Requires() // este contrato requer que seja um e-mail e que seja válido
                .IsEmail(Address, "Email.Address", "E-mail inválido")
            );
        }
    }
}