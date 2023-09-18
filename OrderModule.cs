using System;

public class Order
{ 
	public int Id { get; set; }	
	public  User User { get; set; }

	public decimal Price { get; set; }

    public override string ToString()
    {
        return $"{Id} ,{User.Id},{User.Name}, {Price} ";
    }

}
