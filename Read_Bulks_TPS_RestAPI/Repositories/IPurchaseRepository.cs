using Read_Bulks_TPS_RestAPI.Models;

namespace Read_Bulks_TPS_RestAPI.Repositories
{
    public interface IPurchaseRepository
    {
        Task<List<Purchase>> PurchaseStubList();
    }
}
