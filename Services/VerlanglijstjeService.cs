using Services.Models;

namespace Services
{
    public class VerlanglijstjeService
    {
        public void UpdateWishLists(List<Group> groups, int itemId)
        {
            var products = groups.SelectMany(g => g.Wishlist.Where(p => p.Id == itemId)).ToList();
            products.ForEach(p => UpdateWillBeBought(p));
        }

        private void UpdateWillBeBought(Product product)
        {
            product.WillBeBought = true;
        }
    }
}