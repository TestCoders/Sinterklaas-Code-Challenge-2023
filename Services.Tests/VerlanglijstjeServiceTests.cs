using Microsoft.VisualStudio.TestTools.UnitTesting;
using Services.Helpers;
using Services.Models;

namespace Services.Tests
{
    [TestClass]
    public class VerlanglijstjeServiceTests
    {
        private readonly string _dataPath = @$"{Environment.CurrentDirectory}/verlanglijstje-data-klaas-piet.json";

        [TestMethod]
        public void Update_UsingNeushaartrimmer_ReturnsTrueInAllOccurrences()
        {
            var verlanglijstjesKlaasPiet = FileReader.ReadFile<List<Group>>(_dataPath);

            var verlanglijstjeService = new VerlanglijstjeService();
            verlanglijstjeService.UpdateWishLists(verlanglijstjesKlaasPiet, 3795);

            Assert.IsTrue(verlanglijstjesKlaasPiet[0].Wishlist[2].WillBeBought);
            Assert.IsTrue(verlanglijstjesKlaasPiet[1].Wishlist[1].WillBeBought);
            Assert.IsTrue(verlanglijstjesKlaasPiet[2].Wishlist[0].WillBeBought);
        }

        [TestMethod]
        public void Update_UsingPlayDoh_ReturnsTrueInTwoOccurrences()
        {
            var verlanglijstjesKlaasPiet = FileReader.ReadFile<List<Group>>(_dataPath);

            var verlanglijstjeService = new VerlanglijstjeService();
            verlanglijstjeService.UpdateWishLists(verlanglijstjesKlaasPiet, 6934);

            Assert.IsTrue(verlanglijstjesKlaasPiet[0].Wishlist[1].WillBeBought);
            Assert.IsTrue(verlanglijstjesKlaasPiet[2].Wishlist[2].WillBeBought);
        }
    }
}