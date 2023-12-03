namespace Services.Models
{
    public class Group
    {
        public string GroupName { get; set; }
        public int GroupId { get; set; }
        public List<Product> Wishlist { get; set; }
    }
}