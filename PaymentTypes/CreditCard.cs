using System;

namespace PaymentSystem
{
    public class CreditCardPayment : Payment
    {
        public string CreditCardNumber { get; set; }
        public string Email { get; set; }

        public override string MakePayment()
        {
            string message = string.Empty;
            if(this.Amount > 0 && this.CreditCardNumber != null)
            {
                return message = $"Your payment of ${this.Amount} has been processed by visa";
            }
            return message;
        }
    }
}
