using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace DryRunTempBackend.API.Controllers
{
    [Route("api/Wallets")]
    public class WalletsController : Controller
    {
        [HttpGet]
        public ObjectResult GetWallet(string userPublicKey)
        {
            var result = new List<Wallet>();
            return Ok(result);
        }
    }
}