using System;
using SolidBank.Services;
using Splat;

namespace SolidBank
{
    public class CreditBankAccount : BaseAccount, IAccountFormated, IAccountPayment
    {
        public string CreditCardBrand { get; set; }

        public string AmountFormatted
        {
            get
            {
                return $"-{Amount:C2}";
            }
        }

        public void PayAmount(decimal amount)
        {
            var paymentService = Locator.Current.GetService<IPaymentService>();
            paymentService.ApplyPayment(Id);
        }
    }   
}
