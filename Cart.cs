public class Cart //cart for course selection
{
    public int CartId { get; set; }
    public int UserId { get; set; }
    public List<CartItem> CartItems { get; set; }
}

public class CartItem  //cart item 
{
    public int CartItemId { get; set; }
    public int CartId { get; set; }
    public int CourseId { get; set; }
    public int Quantity { get; set; }

    public Course Course { get; set; }
}
