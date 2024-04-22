
namespace RestaurantApp.Components.Shared
{
    public interface IMenuItem
    {
        string Name { get; set; }
        decimal Price { get; set; }
        string ImageUrl { get; set; }
        int Quantity { get; set; }
        string Category { get; set; }
    }
}

