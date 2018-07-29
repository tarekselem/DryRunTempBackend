using System.Threading.Tasks;
using DryRunTempBackend.API.Helpers;
using Microsoft.AspNetCore.Mvc;

namespace DryRunTempBackend.API.Controllers
{
    [Route("api/Transactions")]
    public class TransactionsController : Controller
    {
        private readonly FirebaseHelper _firebaseHelper = new FirebaseHelper("wGtniF0kWu56G7wxjOrPhhG3caBTn9FqWbsYDIwS", "https://tykn-e5043.firebaseio.com");

        [HttpPost]
        public async Task<ObjectResult> PostWallet([FromBody] Helpers.Transaction transaction)
        {
            //Get From balance
            var fromWallet = await _firebaseHelper.GetWalletAsync(transaction.From);

            //Check if transaction amount
            if (transaction.Amount > fromWallet.Balance)
                return BadRequest("The transaction amount is greater than the wallet balance.");

            //Save transaction if ok
            var result = await _firebaseHelper.AddTransactionAsync(transaction);

            //Deducte From wallet balance
            fromWallet.Balance = fromWallet.Balance - transaction.Amount;
            var updatedfromWallet = await _firebaseHelper.UpdateWalletAsync(transaction.From, fromWallet);

            return Ok(result);
        }
    }
}