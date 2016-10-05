using System;

namespace PaymentSystem
{
    public class PayPalPayment : Payment
    {
        public string Password { get; set; }
        public string Email { get; set; }
        public override string MakePayment()
        {
            string message = string.Empty;
            if(this.Amount > 0 && this.Password != null)
            {
                message = $"Your payment of ${this.Amount} has been processed by PayPal";
            }
            return message;
        }
    }
}
