using System;

public class PaymentProcessorFactory
{
    public static IPaymentMethod GetPaymentMathod(string paymentMethod)
    {
        return paymentMethod switch
        {
            "CreditCard" => new CreditCardPayment(),
            "PayPal" => new PayPalPayment(),
            "BankTransfer" => new BankTransferPayment(),
            _ => throw new ArgumentException("Invalid payment method")
        };
    }
}

