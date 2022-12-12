public class MessageSender
{
    public void PrintMessage(int wait)
    {
        Console.WriteLine($"You have to wait{wait} days");
        
        if (wait == 0)
        {
            Console.WriteLine("Your order has arrived, you can pick it up!");
        }
    }
}

public class Order
{
    public bool Condition { get; set; } = true;
}

public class Facade
{
    MessageSender? sender;
    Order? order;
    int wait = 10;
    public Facade(Order? order, int wait)
    {
        this.order = order;
        this.wait = wait;
    }


    public void StatusQuestion()
    {
        Console.WriteLine("Have you placed an order?");
        order.Condition = Convert.ToBoolean(Console.ReadLine());
    }

    public void Reguest()
    {
        while (true)
        if (order?.Condition == false)
        {
            sender?.PrintMessage(wait);
            wait--;
        }
        else if (order?.Condition == true)
        {
                sender?.PrintMessage(wait);
                break;
        }
    }
}