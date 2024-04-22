
namespace RestaurantApp.Components.Shared
{
    public abstract class MenuItemBase : IMenuItem
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public int Quantity { get; set; }
        public string Category { get; set; }
    }

    public class MenuItem : MenuItemBase
    {}
}

