using Microsoft.AspNetCore.Mvc;

namespace DryRunTempBackend.API.Controllers
{
    [Route("api/Payments")]
    public class PaymentsController : Controller
    {
        [HttpPost]
        public ObjectResult PostPayment([FromBody] PaymentTransaction model)
        {
            return Ok("");
        }
    }
}