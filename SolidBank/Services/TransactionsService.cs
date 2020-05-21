using System;
using System.Collections.Generic;

namespace SolidBank.Services
{
    public class TransactionsService
    {
        public TransactionsService()
        {
        }

        public IList<BaseAccount> GetAccounts()
        {
            return new List<BaseAccount>
            {
                new BankAccount{ Amount = 200.10M, Name = "Vacations", Type="Savings", Number="123456789" },
                new BankAccount{ Amount = 1200.50M, Name = "Checking Account", Type="Checking", Number="01274697" },
                new CreditBankAccount{ Amount = 900.26M, Name = "Mastercard Gold", Type="CreditCard", Number="5544187421483214", CreditCardBrand="Mastercard" },
                new CreditBankAccount{ Amount = 100.26M, Name = "Mastercard Gold", Type="CreditCard", Number="5544187421483214", CreditCardBrand="Mastercard" },
            };
        }
    }
}
