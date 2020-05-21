using System;
namespace SolidBank.Services
{
    public interface IPaymentService
    {
        void ApplyPayment(int accountId);
    }

    public class PaymentService : IPaymentService
    {
        public void ApplyPayment(int accountId)
        {
            //Do payment;
        }
    }

}
