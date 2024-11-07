namespace Entities
{
    public class Order
    {
        public int OrderId { get; set; }
        public int UserId { get; set; }
        public int ShippingAddressId { get; set; }
        public int BillingAddressId { get; set; }
        public DateTime OrderDate { get; set; }
        public string Status { get; set; } // Örn. "Pending", "Shipped", "Delivered"

    }


}
