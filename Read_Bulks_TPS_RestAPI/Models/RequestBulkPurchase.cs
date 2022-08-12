namespace Read_Bulks_TPS_RestAPI.Models
{
    // Request data to send to backand
    public class RequestBulkPurchase
    {
        public DateTime StartFrom { get; set; }
        public int BulkAmount { get; set; }
    }
}
