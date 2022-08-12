using Read_Bulks_TPS_RestAPI.Models;

namespace Read_Bulks_TPS_RestAPI.Manager
{
    public interface IPurchaseManager
    {
        Task<List<Purchase>> GetSpecificBulkPurchase(RequestBulkPurchase requestPurchase);
    }
}