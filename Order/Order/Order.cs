using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Order
{
    public int Id { get; set; }
    public double Amount { get; set; }
}
public interface IPaymentMethod
{
    void ProcessPayment(Order paymentMethod);
}

public class CreditCardPayment : IPaymentMethod
{
    public void ProcessPayment(Order creditCard)
    {
        Console.WriteLine("Processing credit card payment...");
    }
}
public class PayPalPayment : IPaymentMethod
{
    public void ProcessPayment(Order payPal)
    {
        Console.WriteLine("Processing PayPal payment...");
    }
}
public class BankTransferPayment : IPaymentMethod
{
    public void ProcessPayment(Order bankTranfer)
    {
        Console.WriteLine("Processing bank transfer payment...");
    }
}

public interface IOrderRepository
{
    void Save(Order order);
    Order Load(int orderId);
}

public class OrderRepository : IOrderRepository
{
    public void Save(Order order)
    {
        Console.WriteLine("Saving order to database...");
    }

    public Order Load(int orderId)
    {
        Console.WriteLine("Loading order from database...");
        return new Order { Id = orderId };
    }
}
