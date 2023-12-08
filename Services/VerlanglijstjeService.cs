using Services.Models;

namespace Services
{
    public class VerlanglijstjeService
    {
        public void UpdateWishLists(List<Group> groups, int itemId)
        {
            var groupsToUpdate = groups.FindAll(g => g.Wishlist.Any(p => p.Id == itemId));
            groupsToUpdate.ForEach(g => g.Wishlist.Where(p => p.Id == itemId).ToList().ForEach(p => p.WillBeBought = true));
        }
    }
}