using System.Collections.Generic;

namespace DryRunTempBackend.API.Controllers
{
    public class Wallet
    {
        public decimal Balance { get; set; }
        public IEnumerable<Transaction> Transactions{ get; set; }

    }
}