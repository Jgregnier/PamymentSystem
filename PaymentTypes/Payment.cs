using System;

namespace PaymentSystem
{
    public class Payment
    {
        public decimal Amount { get; set; }
        public virtual string MakePayment()
        {
            return $"You paid ${this.Amount} in cash.";
        }
        public string SendConfirmation(string email)
        {
            return "You purchased several nice items";
        }
    }
}
