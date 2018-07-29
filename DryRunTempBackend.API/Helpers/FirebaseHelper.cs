using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
using System;
using System.Threading.Tasks;

namespace DryRunTempBackend.API.Helpers
{
    public class FirebaseHelper
    {
        private readonly IFirebaseClient _client;
        public FirebaseHelper(string authSecret, string basePath)
        {
            var firebaseConfig = new FirebaseConfig { AuthSecret = authSecret, BasePath = basePath };
            _client = new FirebaseClient(firebaseConfig);
        }

        public async Task<Wallet> GetWalletAsync(string userPublicKey)
        {
            var response = await _client.GetAsync($"wallets/{userPublicKey}");
            var result = response.ResultAs<Wallet>();
            return result;
        }

        public async Task<Wallet> AddWalletAsync(string userPublicKey, Wallet walletItem)
        {
            var response = await _client.SetAsync($"wallets/{userPublicKey}", walletItem);
            var result = response.ResultAs<Wallet>();
            return result;
        }

        public async Task<Wallet> UpdateWalletAsync(string userPublicKey, Wallet walletItem)
        {
            var response = await _client.UpdateAsync($"wallets/{userPublicKey}", walletItem);
            var result = response.ResultAs<Wallet>();
            return result;
        }

        public async Task<Transaction> AddTransactionAsync(Transaction transactionItem)
        {
            var response = await _client.SetAsync($"transactions/{transactionItem.Id}", transactionItem);
            var result = response.ResultAs<Transaction>();
            return result;
        }
    }

    public class Wallet
    {
        public string OwnerId { get; set; }
        public decimal Balance { get; set; }
    }

    public class Transaction
    {
        public int Id { get; set; }
        public string From { get; set; }
        public DateTime TimeStamp { get; set; }
        public string To { get; set; }
        public decimal Amount { get; set; }
        public bool IsConfirmed { get; set; }
        public string ExecutionToken { get; set; }
        public string ActorType { get; set; }
    }
}
