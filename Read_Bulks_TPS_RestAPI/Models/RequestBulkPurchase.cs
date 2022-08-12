namespace Read_Bulks_TPS_RestAPI.Models
{
    public class RequestBulkPurchase
    {
        public DateTime StartFrom { get; set; }
        public int BulkAmount { get; set; }
    }
}
