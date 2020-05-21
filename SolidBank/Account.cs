using System;
namespace SolidBank
{
    public class BankAccount : BaseAccount, IAccountFormated
    {
        public string AmountFormatted
        {
            get => $"{Amount:C2}";
        }
    }
}
