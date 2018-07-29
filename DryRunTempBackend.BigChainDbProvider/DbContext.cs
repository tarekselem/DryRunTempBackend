using System;
using System.Net.Http;

namespace DryRunTempBackend.BigChainDbProvider
{
    public class DbContextBase : HttpHandler
    {
        public DbContextBase(string apiRoot) : base(apiRoot) { }

        public string GetTransaction(string transactionId)
        {
            return ExecuteGetRequestAsync("transactions/"+transactionId).Result;
        }

        public string GetTransactions(string assetId, string operation)
        {
            return ExecuteGetRequestAsync($"transactions?asset_id={assetId}&operation={operation}").Result;
        }

    }

    public class DbContext : DbContextBase
    {
        public DbContext() : base("https://test.bigchaindb.com/api/v1/") {}


    }
}
