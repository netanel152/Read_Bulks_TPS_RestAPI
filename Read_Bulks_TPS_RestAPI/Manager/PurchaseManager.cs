using Read_Bulks_TPS_RestAPI.Models;
using Read_Bulks_TPS_RestAPI.Repositories;

namespace Read_Bulks_TPS_RestAPI.Manager
{

    //Business logic - Return the filtered list to purchase controller from the stub method. 
    public class PurchaseManager : IPurchaseManager
    {
        private readonly IPurchaseRepository _purchaseRepository;
        public PurchaseManager(IPurchaseRepository purchaseRepository)
        {
            _purchaseRepository = purchaseRepository;
        }
        public Task<List<Purchase>> GetSpecificBulkPurchase(RequestBulkPurchase requestPurchase)
        {
            var result = _purchaseRepository.PurchaseStubList().Result
                .OrderBy(o => o.ItemNo)
                .Where(w => w.PurchaseDate >= requestPurchase.StartFrom)
                .Take(requestPurchase.BulkAmount)
                .ToList();
            if (result.Count == 0)
            {
                throw new Exception("No data found, please check your request and send it again");
            }
            return Task.FromResult(result);
        }
    }
}
