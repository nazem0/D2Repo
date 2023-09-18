using System;

public class UserOrder
{
    public static void Display()
    {
        User user = new User();
        user.Id = 1;
        user.Name = "Test2";
        Order order = new Order();
        order.Id = 1;
        order.Price = 20;
        order.User=user;
        Console.WriteLine(order);
    }	
}
