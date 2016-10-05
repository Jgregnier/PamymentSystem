using System;

namespace PaymentSystem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string paymentType = args[0];

            if(paymentType == "p")
            {
                var payPalPayment = new PayPalPayment
                {
                    Email = args[1],
                    Password = args[2],
                    Amount = Convert.ToDecimal(args[3])
                };

                Console.WriteLine(payPalPayment.MakePayment());
            }
            if (paymentType == "c")
            {
                var creditCardPayment = new CreditCardPayment
                {
                    Email = args[0],
                    CreditCardNumber = args[1],
                    Amount = Convert.ToDecimal(args[2])
                };

                Console.WriteLine(creditCardPayment.MakePayment());
            }
        }
    }
}
