using System.Collections.Generic;
using System.Threading.Tasks;
using DryRunTempBackend.API.Helpers;
using Microsoft.AspNetCore.Mvc;

namespace DryRunTempBackend.API.Controllers
{
    [Route("api/Wallets")]
    public class WalletsController : Controller
    {
        private readonly FirebaseHelper _firebaseHelper = new FirebaseHelper("", "");

        [HttpGet]
        public async Task<ObjectResult> GetWallet(string userPublicKey)
        {
            var result = await _firebaseHelper.GetWalletAsync(userPublicKey);

            return Ok(result);
        }

        [HttpPost]
        public async Task<ObjectResult> PostWallet([FromQuery] string userPublicKey)
        {
            var result = await _firebaseHelper.AddWalletAsync(userPublicKey ,new Helpers.Wallet
                        {
                            OwnerId = "123456789",
                            Balance = 5000
                        });

            return Ok(result);
        }
    }
}