using Services.Models;

namespace Services
{
    public class VerlanglijstjeService
    {
        public void UpdateWishLists(List<Group> groups, int itemId)
        {
            var products = groups.Select(g => g.Wishlist.First(p => p.Id == itemId)).ToList();
            products.ForEach(p => UpdateWillBeBought(p));
        }

        private void UpdateWillBeBought(Product product)
        {
            product.WillBeBought = true;
        }
    }
}