using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Read_Bulks_TPS_RestAPI.Manager;
using Read_Bulks_TPS_RestAPI.Models;
using Read_Bulks_TPS_RestAPI.Repositories;

namespace Read_Bulks_TPS_RestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PurchaseController : ControllerBase
    {
        private readonly IPurchaseManager _purchaseManager;
       
        public PurchaseController(IPurchaseManager purchaseManager)
        {
            _purchaseManager = purchaseManager;
        }

        //Post request to get data from Stub method
        [HttpPost("getBulkPurchases")]
        public async Task<IActionResult> GetBulkPurchases(RequestBulkPurchase request)
        {
            var res = await _purchaseManager.GetSpecificBulkPurchase(request);
            return Ok(res);
        }
    }
}
