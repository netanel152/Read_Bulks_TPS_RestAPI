using Read_Bulks_TPS_RestAPI.Models;

namespace Read_Bulks_TPS_RestAPI.Repositories
{
    // Stub method to generate data for TPS
    public class PurchaseRepository : IPurchaseRepository
    {
        public Task<List<Purchase>> PurchaseStubList()
        {
            var purchasesList = new List<Purchase>
            {
            new Purchase { ItemNo = 1, Amount = 1, PurchaseDate = DateTimeOffset.Parse("2019-11-26 16:09:31") },
            new Purchase { ItemNo = 2, Amount = 5, PurchaseDate = DateTimeOffset.Parse("2019-11-26 16:09:31") },
            new Purchase { ItemNo = 3, Amount = 56, PurchaseDate = DateTimeOffset.Parse("2019-11-26 16:09:32") },
            new Purchase { ItemNo = 4, Amount = 22, PurchaseDate = DateTimeOffset.Parse("2019-11-26 16:09:32") },
            new Purchase { ItemNo = 5, Amount = 154.5, PurchaseDate = DateTimeOffset.Parse("2019-11-26 16:09:32") },
            new Purchase { ItemNo = 6, Amount = 35.56, PurchaseDate = DateTimeOffset.Parse("2019-11-26 16:09:32") },
            };
            return Task.FromResult(purchasesList);
        }
    }
}