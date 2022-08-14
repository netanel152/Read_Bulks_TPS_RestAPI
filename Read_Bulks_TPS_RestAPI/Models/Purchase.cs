namespace Read_Bulks_TPS_RestAPI.Models
{
    //Data model of the purchase
    public class Purchase
    {
        public int ItemNo { get; set; }
        public double Amount { get; set; }
        public DateTimeOffset PurchaseDate  { get; set; }    
    }
}
